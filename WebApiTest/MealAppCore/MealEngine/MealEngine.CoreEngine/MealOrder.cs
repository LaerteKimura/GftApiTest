using System;
using System.Linq;
using System.Reflection;
using WebApiTest.MealEngine.MealEngine.CoreEngine.Interfaces;
using WebApiTest.MealEngine.MealEngine.Objects;
using WebApiTest.MealEngine.Objects;

namespace WebApiTest.MealEngine.MealEngine.CoreEngine
{
    public class MealOrder : IMealOrder
    {
        public Meal GetMeal(string mealTime, params string[] ArrayRequest)
        {
            //Verifica se é um tipo de refeição valida antes de prosseguir 
            if (mealTime.ToUpper() != EnumeratorsMeal.Meal.night.ToString().ToUpper() && mealTime.ToUpper() != EnumeratorsMeal.Meal.morning.ToString().ToUpper())
            {
                throw new ArgumentOutOfRangeException("Invalid Parameter for type of meal");
            }

            //Verifica se foi recebido os parametros
            if (!ArrayRequest.Any())
            {
                throw new TargetParameterCountException("Sequence of meal is missing or parameters is null.");
            }

            if (!int.TryParse(ArrayRequest[0], out _)){
                throw new ArgumentOutOfRangeException("Sequence of meal is missing or parameters is null.");
            }

            // Verifica que tipo de refeicao foi recebida e inicia a construcao da classe correspondente
                if (mealTime.ToUpper() == EnumeratorsMeal.Meal.morning.ToString().ToUpper()) {
                return (Meal)new MorningMeal(ArrayRequest);
            }else
            {
                return (Meal)new NightMeal(ArrayRequest);
            };

        }
    }
}
