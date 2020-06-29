using WebApiTest;
using WebApiTest.Controllers;
using WebApiTest.MealEngine.MealEngine.CoreEngine;
using Xunit;

namespace TestApiTest
{
    /// <summary>
    /// Testes da aplicacao meal devem estar validados para que este teste seja validado
    /// </summary>
    public class MealReturnControllerTest
    {
        MealReturnController _controller;
        MealOrder _mealOrderTest;

       
        public MealReturnControllerTest()
        {
            _mealOrderTest = new MealOrder();
        }
        // Set up Prerequisites   
        [Fact]
        public void Get_WhenCalled_ReturnsOkResult()
        {
            var sequence = "1,2";
            var meal = _mealOrderTest.GetMeal(WebApiTest.MealEngine.Objects.EnumeratorsMeal.Meal.night.ToString(), sequence.Split(','));
            _controller = new MealReturnController();
           
            var okResult = _controller.Get("night,1,2");

            Assert.Equal(meal.ToString(), okResult.retorno);
        }


        //check

        //Validando entradas e resultados
        //Morning
        [Fact]
        public void IsValidMorningSelection_ParamSeq123_Pass()
        {
            var sequence = "1,2,3";
            var meal = _mealOrderTest.GetMeal(WebApiTest.MealEngine.Objects.EnumeratorsMeal.Meal.morning.ToString(), sequence.Split(','));
            _controller = new MealReturnController();

            var okResult = _controller.Get("morning,1,2,3");

            Assert.Equal(meal.ToString(), okResult.retorno);

        }



        [Fact]
        public void IsValidMorningSelection_ParamSeq213_Pass()
        {

            var sequence = "2,1,3";
            var meal = _mealOrderTest.GetMeal(WebApiTest.MealEngine.Objects.EnumeratorsMeal.Meal.morning.ToString(), sequence.Split(','));
            _controller = new MealReturnController();

            var okResult = _controller.Get("morning,2,1,3");

            Assert.Equal(meal.ToString(), okResult.retorno);

        }

        [Fact]
        public void IsValidMorningSelection_ParamSeq1234_Pass()
        {

            var sequence = "1,2,3,4";
            var meal = _mealOrderTest.GetMeal(WebApiTest.MealEngine.Objects.EnumeratorsMeal.Meal.morning.ToString(), sequence.Split(','));
            _controller = new MealReturnController();

            var okResult = _controller.Get("morning,1,2,3,4");

            Assert.Equal(meal.ToString(), okResult.retorno); 
        }

        [Fact]
        public void IsValidMorningSelection_ParamSeq12333_Pass()
        {
            var sequence = "1,2,3,3,3";
            var meal = _mealOrderTest.GetMeal(WebApiTest.MealEngine.Objects.EnumeratorsMeal.Meal.morning.ToString(), sequence.Split(','));
            _controller = new MealReturnController();

            var okResult = _controller.Get("morning,1,2,3,3,3");

            Assert.Equal(meal.ToString(), okResult.retorno);
        }


        [Fact]
        public void IsValidMorningSelection_ParamSeq1223_Pass()
        {
            var sequence = "1,2,2,3";
            var meal = _mealOrderTest.GetMeal(WebApiTest.MealEngine.Objects.EnumeratorsMeal.Meal.morning.ToString(), sequence.Split(','));
            _controller = new MealReturnController();

            var okResult = _controller.Get("morning,1,2,2,3");

            Assert.Equal(meal.ToString(), okResult.retorno);
        }

        [Fact]
        public void IsValidMorningSelection_ParamSeq1123_Pass()
        {
            var sequence = "1,1,2,3";
            var meal = _mealOrderTest.GetMeal(WebApiTest.MealEngine.Objects.EnumeratorsMeal.Meal.morning.ToString(), sequence.Split(','));
            _controller = new MealReturnController();

            var okResult = _controller.Get("morning,1,1,2,3");

            Assert.Equal(meal.ToString(), okResult.retorno);
        }




        //Validando entradas e resultados
        //Night
      
        [Fact]
        public void IsValidNightSelection_ParamSeq1234_Pass()
        {
            var sequence = "1,2,3,4";
            var meal = _mealOrderTest.GetMeal(WebApiTest.MealEngine.Objects.EnumeratorsMeal.Meal.night.ToString(), sequence.Split(','));
            _controller = new MealReturnController();

            var okResult = _controller.Get("night,1,2,3,4");

            Assert.Equal(meal.ToString(), okResult.retorno);
        }

        [Fact]
        public void IsValidNightSelection_ParamSeq1342_Pass()
        {

            var sequence = "1,3,4,2";
            var meal = _mealOrderTest.GetMeal(WebApiTest.MealEngine.Objects.EnumeratorsMeal.Meal.night.ToString(), sequence.Split(','));
            _controller = new MealReturnController();

            var okResult = _controller.Get("night,1,3,4,2");

            Assert.Equal(meal.ToString(), okResult.retorno);
        }

        [Fact]
        public void IsValidNightSelection_ParamSeq1224_Pass()
        {

            var sequence = "1,2,2,4";
            var meal = _mealOrderTest.GetMeal(WebApiTest.MealEngine.Objects.EnumeratorsMeal.Meal.night.ToString(), sequence.Split(','));
            _controller = new MealReturnController();

            var okResult = _controller.Get("night,1,2,2,4");

            Assert.Equal(meal.ToString(), okResult.retorno);
        }

        [Fact]
        public void IsValidNightSelection_ParamSeq1235_Pass()
        {

            var sequence = "1,2,3,5";
            var meal = _mealOrderTest.GetMeal(WebApiTest.MealEngine.Objects.EnumeratorsMeal.Meal.night.ToString(), sequence.Split(','));
            _controller = new MealReturnController();

            var okResult = _controller.Get("night,1,2,3,5");

            Assert.Equal(meal.ToString(), okResult.retorno);
        }

        [Fact]
        public void IsValidNightSelection_ParamSeq11235_Pass()
        {
            var sequence = "1,1,2,3,5";
            var meal = _mealOrderTest.GetMeal(WebApiTest.MealEngine.Objects.EnumeratorsMeal.Meal.night.ToString(), sequence.Split(','));
            _controller = new MealReturnController();

            var okResult = _controller.Get("night,1,1,2,3,5");

            Assert.Equal(meal.ToString(), okResult.retorno);

        }





    }
}
