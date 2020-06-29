using Microsoft.AspNetCore.Mvc;
using WebApiTest.MealEngine.MealEngine.CoreEngine;

namespace WebApiTest.Controllers
{

    [ApiController]
        [Route("api/[controller]")]
        public class MealReturnController : ControllerBase
        {
            [HttpGet("{ParamentrosEntrada}")]
            public MealReturn Get([FromRoute] string ParamentrosEntrada)
            {
            
            string[] arrParamentrosEntrada = ParamentrosEntrada.Split(',');

            var appMeal = new AppMeals();

            var mealReturned = new MealReturn();

            mealReturned.retorno = appMeal.Executar(arrParamentrosEntrada);

            return mealReturned;

            }
        }
    }

