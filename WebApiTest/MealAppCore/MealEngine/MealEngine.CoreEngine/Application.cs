using System;
using System.Linq;
using System.Reflection;
using WebApiTest.MealEngine.MealEngine.CoreEngine.Interfaces;

namespace WebApiTest.MealEngine.MealEngine.CoreEngine
{
    public class AppMeals : IAppMeal
    {

        public AppMeals()
        {
            
        }

        public string Executar(string[] requestParameters)
        {
            IMealOrder _mealOrderReceived = new MealOrder();

            if (requestParameters.Count() == 0)
            {
                return ("Error -> Insuficient parameters |  Erro ->  Parâmetros insuficientes");   
            }

            //separa o tipo de refeição da sequencia
            var mealTimeRequested = requestParameters[0];
            string[] orderNumbers = new string[requestParameters.Length - 1];


            //gerando nova lista de sequencia mantendo a imutabilidade da lista recebida
            for (int i = 0; i < requestParameters.Count(); i++)
            {
                if (i > 0)
                {
                    orderNumbers[i - 1] = requestParameters[i];
                }
            }

            //envia para a classe de Order para identificar o tipo de refeição e processar
            try
            {
                var meal = _mealOrderReceived.GetMeal(mealTimeRequested, orderNumbers);
                return (meal.ToString());
            }
            
            //caso as classes dispararem erro devolve no retorno
            catch (ArgumentOutOfRangeException err)
            {
                return ("ERROR : " + err.Message);
            }
            catch (TargetParameterCountException err)
            {
                return("ERROR : " + err.Message);
            }
        }
    }
}
