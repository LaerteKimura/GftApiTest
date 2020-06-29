using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApiTest.MealEngine.MealEngine.CoreEngine;
using WebApiTest.MealEngine.MealEngine.Objects;

namespace WebApiTest.Controllers
{
    
        [ApiController]
        [Route("api/[controller]")]
        public class MealReturnController : ControllerBase
        {
            [HttpGet("{ParamentrosEntrada}")]
            public IEnumerable<MealReturn> Get([FromRoute] string ParamentrosEntrada)
            {
            
            string[] arrParamentrosEntrada = ParamentrosEntrada.Split(',');

            var appMeal = new AppMeals();    

            return Enumerable.Range(1,1).Select(index => new MealReturn
            {
                retorno = appMeal.Executar(arrParamentrosEntrada)
               
            });


            }
        }
    }

