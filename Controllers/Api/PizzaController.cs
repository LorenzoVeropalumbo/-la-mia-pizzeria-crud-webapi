using la_mia_pizzeria_static.Models;
using la_mia_pizzeria_static.Models.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace la_mia_pizzeria_static.Controllers.Api
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        IdbPizzeriaRepository _pizzaRepository;

        public PizzaController(IdbPizzeriaRepository pizzatRepository)
        {
            _pizzaRepository = pizzatRepository;
        }

        public IActionResult Get()
        {
            List<Pizza> pizza = _pizzaRepository.AllWithoutRelationship();
            return Ok(pizza);

        }
    }
}
