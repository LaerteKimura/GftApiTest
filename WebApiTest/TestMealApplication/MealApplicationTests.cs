using System;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApiTest.MealEngine.MealEngine.CoreEngine;

namespace TestMealApplication
{
    [TestClass]
    public class MealApplicationTests
    {

        private MealOrder _mealOrderTest;

        public MealApplicationTests()
        {
            _mealOrderTest = new MealOrder();
        }

        // Validando recebimento de variaveis
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CanGenerateOrder_MissingMealTime_ShowError()
        {
            var mealTime = string.Empty;
            _mealOrderTest.GetMeal(mealTime);
      
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CanGenerateOrder_InvalidMealTime_ShowError()
        {
            _mealOrderTest.GetMeal("afternoon");
        }

       

        [TestMethod]
        [ExpectedException(typeof(TargetParameterCountException))]
        public void CanGenerateOrder_MissingSequenceNumbers_ShowError()
        {
            _mealOrderTest.GetMeal(WebApiTest.MealEngine.Objects.EnumeratorsMeal.Meal.morning.ToString());
        }



        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CanGenerateOrder_InvalidParametersRequest_ShowError()
        {
            var meal = _mealOrderTest.GetMeal("morning", "night");

        }
        //check

        //Validando entradas e resultados
        //Morning
        [TestMethod]
        public void IsValidMorningSelection_ParamSeq123_Pass()
        {
            var sequence = "1,2,3";
            var meal = _mealOrderTest.GetMeal(WebApiTest.MealEngine.Objects.EnumeratorsMeal.Meal.morning.ToString(), sequence.Split(','));

            Assert.AreEqual("eggs, toast, coffee", meal.ToString());
        }



        [TestMethod]
        public void IsValidMorningSelection_ParamSeq213_Pass()
        {

            var sequence = "2,1,3";
            var meal = _mealOrderTest.GetMeal(WebApiTest.MealEngine.Objects.EnumeratorsMeal.Meal.morning.ToString(), sequence.Split(','));

            Assert.AreEqual("eggs, toast, coffee", meal.ToString());
        }

        [TestMethod]
        public void IsValidMorningSelection_ParamSeq1234_Pass()
        {

            var sequence = "1,2,3,4";
            var meal = _mealOrderTest.GetMeal(WebApiTest.MealEngine.Objects.EnumeratorsMeal.Meal.morning.ToString(), sequence.Split(','));

            Assert.AreEqual("eggs, toast, coffee, error", meal.ToString());
        }

        [TestMethod]
        public void IsValidMorningSelection_ParamSeq12333_Pass()
        {
            var sequence = "1,2,3,3,3";
            var meal = _mealOrderTest.GetMeal(WebApiTest.MealEngine.Objects.EnumeratorsMeal.Meal.morning.ToString(), sequence.Split(','));
         

            Assert.AreEqual("eggs, toast, coffee(x3)", meal.ToString());
        }


        [TestMethod]
        public void IsValidMorningSelection_ParamSeq1223_Pass()
        {
            var sequence = "1,2,2,3";
            var meal = _mealOrderTest.GetMeal(WebApiTest.MealEngine.Objects.EnumeratorsMeal.Meal.morning.ToString(), sequence.Split(','));


            Assert.AreEqual("eggs, toast, error", meal.ToString());
        }

        [TestMethod]
        public void IsValidMorningSelection_ParamSeq1123_Pass()
        {
            var sequence = "1,1,2,3";
            var meal = _mealOrderTest.GetMeal(WebApiTest.MealEngine.Objects.EnumeratorsMeal.Meal.morning.ToString(), sequence.Split(','));


            Assert.AreEqual("eggs, error", meal.ToString());
        }




        //Validando entradas e resultados
        //Night
        [TestMethod]
        [ExpectedException(typeof(TargetParameterCountException))]
        public void CanGenerateOrderNight_MissingSequenceNumbers_ShowError()
        {
            _mealOrderTest.GetMeal(WebApiTest.MealEngine.Objects.EnumeratorsMeal.Meal.night.ToString());
        }



        [TestMethod]
        public void IsValidNightSelection_ParamSeq1234_Pass()
        {
            var sequence = "1,2,3,4";
            var meal = _mealOrderTest.GetMeal(WebApiTest.MealEngine.Objects.EnumeratorsMeal.Meal.night.ToString(), sequence.Split(','));

            Assert.AreEqual("steak, potato, wine, cake", meal.ToString());
        }

        [TestMethod]
        public void IsValidNightSelection_ParamSeq1342_Pass()
        {
 
            var sequence = "1,3,4,2";
            var meal = _mealOrderTest.GetMeal(WebApiTest.MealEngine.Objects.EnumeratorsMeal.Meal.night.ToString(), sequence.Split(','));

            Assert.AreEqual("steak, potato, wine, cake", meal.ToString());
        }

        [TestMethod]
        public void IsValidNightSelection_ParamSeq1224_Pass()
        {
           
            var sequence = "1,2,2,4";
            var meal = _mealOrderTest.GetMeal(WebApiTest.MealEngine.Objects.EnumeratorsMeal.Meal.night.ToString(), sequence.Split(','));

            Assert.AreEqual("steak, potato(x2), cake", meal.ToString());
        }

        [TestMethod]
        public void IsValidNightSelection_ParamSeq1235_Pass()
        {
            
            var sequence = "1,2,3,5";
            var meal = _mealOrderTest.GetMeal(WebApiTest.MealEngine.Objects.EnumeratorsMeal.Meal.night.ToString(), sequence.Split(','));

            Assert.AreEqual("steak, potato, wine, error", meal.ToString());
        }

        [TestMethod]
        public void IsValidNightSelection_ParamSeq11235_Pass()
        {
            var sequence = "1,1,2,3,5";
            var meal = _mealOrderTest.GetMeal(WebApiTest.MealEngine.Objects.EnumeratorsMeal.Meal.night.ToString(), sequence.Split(','));
           
            Assert.AreEqual("steak, error", meal.ToString());
        }
    }
}
