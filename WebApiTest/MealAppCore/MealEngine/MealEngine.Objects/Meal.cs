using MealApplication.MealEngine.MealEngine.Objects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApiTest.MealEngine.MealEngine.Objects
{
    public abstract class Meal
    {
        public List<MealItem> MealItens = new List<MealItem>();

        protected string[] _ArrayRequest;

        protected void LoadOrder()
        {
            foreach (string _selectionItem in _ArrayRequest)
            {
                if (double.TryParse(_selectionItem, out _))
                {
                    if (MealItens.Any(x => x.SequenceNumber == int.Parse(_selectionItem)))
                    {
                        MealItens.Single(x => x.SequenceNumber == int.Parse(_selectionItem)).Quantity += 1;
                    }
                    else
                    {
                        if (MealItens.Any(x => x.MealItemName == "error"))
                        {
                            MealItens.Single(x => x.MealItemName == "error").Quantity += 1;
                        }
                        else
                        {
                            MealItens.Add(new MealItem { MealItemName = "error", SequenceNumber = MealItens.Count + 1, Quantity = 1, OrderLimit = 1 });
                        }
                    }
                }
            }
        }

        protected string GenerateMenuOrderedSequence(List<MealItem> listFoodSelection)
        {
            var returList = new List<string>();
            Boolean ErrorFound = false;
            var listFoodSelectionOrdered = listFoodSelection.OrderBy(m => m.SequenceNumber).ToList();

            foreach (MealItem foodItem in listFoodSelectionOrdered)
            {
                if (ErrorFound)
                {
                    break;
                }
                //Em caso do item ter pelo menos um indicado no pedido entra na lista
                if (foodItem.Quantity > 0)
                {
                    returList.Add(foodItem.MealItemName);
                    //Se caso possui erro , entra no retorno na sequencia
                    if (foodItem.Error)
                    {
                        //o erro deve aparecer no retorno apenas uma vez
                        if (!returList.Exists(x => x.Equals("error")))
                        {
                            returList.Add("error");
                            ErrorFound = true; //Controla para parar -case exista erro ele é informado apenas 1 vez
                        }
                    }
                    else
                    {
                        //Caso a quantidade ultrapasse 1 unidades apresenta no retorno a quantidade de vezes
                        if (foodItem.Quantity > 1)
                        {
                            returList[returList.FindIndex(ind => ind.Equals(foodItem.MealItemName))] = foodItem.MealItemName + "(x" + foodItem.Quantity + ")";
                        }
                    }
                }
            }
            string returnString = string.Join(", ", returList);
            return returnString;
        }

        public override string ToString()
        {
            return GenerateMenuOrderedSequence(MealItens);

        }
    }
}
