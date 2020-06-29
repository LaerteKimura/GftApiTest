using MealApplication.MealEngine.MealEngine.Objects;
using System.Collections.Generic;
using WebApiTest.MealEngine.Objects;

namespace WebApiTest.MealEngine.MealEngine.Objects
{
    public class NightMeal : Meal
    {
        public NightMeal(params string[] ArrayRequest)
        {
            _ArrayRequest = ArrayRequest;

            MealItens.Add(new MealItem { MealItemName = EnumeratorsMeal.entree.steak.ToString(), SequenceNumber = 1, Quantity = 0, OrderLimit = 1 });
            MealItens.Add(new MealItem { MealItemName = EnumeratorsMeal.side.potato.ToString(), SequenceNumber = 2, Quantity = 0, OrderLimit = 9999 });
            MealItens.Add(new MealItem { MealItemName = EnumeratorsMeal.drink.wine.ToString(), SequenceNumber = 3, Quantity = 0, OrderLimit = 1 });
            MealItens.Add(new MealItem { MealItemName = EnumeratorsMeal.dessert.cake.ToString(), SequenceNumber = 4, Quantity = 0, OrderLimit = 1 });


            LoadOrder();
        }
    }
}
