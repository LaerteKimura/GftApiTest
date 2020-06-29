using MealApplication.MealEngine.MealEngine.Objects;
using System.Collections.Generic;
using WebApiTest.MealEngine.Objects;

namespace WebApiTest.MealEngine.MealEngine.Objects
{
    public class MorningMeal : Meal
    {
     
        public MorningMeal(params string[] ArrayRequest)
        {
            _ArrayRequest = ArrayRequest;

            MealItens.Add(new MealItem { MealItemName = EnumeratorsMeal.entree.eggs.ToString(), SequenceNumber = 1, Quantity = 0, OrderLimit = 1 });
            MealItens.Add(new MealItem { MealItemName = EnumeratorsMeal.side.toast.ToString(), SequenceNumber = 2, Quantity = 0, OrderLimit = 1 });
            MealItens.Add(new MealItem { MealItemName = EnumeratorsMeal.drink.coffee.ToString(), SequenceNumber = 3, Quantity = 0, OrderLimit = 9999 });

            LoadOrder();

        }
    }
}
