using ApdbTest2.Dtos;
using ApdbTest2.Exceptions;
using ApdbTest2.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApdbTest2.Controllers
{
    [ApiController]
    [Route("api/clients/")]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _service;

        public ClientController(IClientService service)
        {
            _service = service;
        }


            [HttpPost("addClient")]
        public IActionResult AddClient(ClientDto dto)
        {
            try
            {
                _service.AddClient(dto);
                return NoContent();
            }
            catch (CityWasNotAddedException)
            {
                return StatusCode(500);
            }
            catch (InvalidClientDataException)
            {
                return BadRequest("your data is not correct");
            }
        }
        
    }
    }
