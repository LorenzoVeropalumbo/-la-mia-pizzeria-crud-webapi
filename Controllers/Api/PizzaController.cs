using la_mia_pizzeria_static.Models;
using la_mia_pizzeria_static.Models.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace la_mia_pizzeria_static.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        IdbPizzeriaRepository _pizzaRepository;

        public PizzaController(IdbPizzeriaRepository pizzatRepository)
        {
            _pizzaRepository = pizzatRepository;
        }
        
        // Questa funzione è già implementata con la search
        //public IActionResult Get()
        //{
        //    List<Pizza> pizza = _pizzaRepository.All();
        //    return Ok(pizza);

        //}

        public IActionResult Search(string? title)
        {

            List<Pizza> pizzas = _pizzaRepository.SearchByTitle(title);

            return Ok(pizzas);

        }

        [HttpGet("{id}")]
        public IActionResult Detail(int id)
        {
            Pizza pizza = _pizzaRepository.GetById(id);
            
            return Ok(pizza);

        }
    }
}
