using WebApiTest.MealEngine.MealEngine.Objects;


namespace WebApiTest.MealEngine.MealEngine.CoreEngine.Interfaces
{
    public interface IMealOrder
    {
        Meal GetMeal(string mealTimeRequested, params string[] orderNumbers);
    }
}
