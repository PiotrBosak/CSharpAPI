
using ApdbTest2.Exceptions;
using ApdbTest2.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApdbTest2.Controllers
{
    [ApiController]
    [Route("api/cars/")]
    public class CarController : ControllerBase
    {

        private readonly ICarService _service;

        public CarController(ICarService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public IActionResult ListRentals(int id)

        {
            try
            {
                var car = _service.GetCar(id);
                return Ok(car);
            }
            catch (NoSuchCarException)
            {
                return NotFound("there is no car with provided id");
            }
            catch (NoClientWithGivenIdException)
            {
                return BadRequest();
            }

        }


    }
}