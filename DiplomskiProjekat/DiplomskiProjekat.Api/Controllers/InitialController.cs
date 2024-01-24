using DiplomskiProjekat.Application.UseCases.Commands;
using DiplomskiProjekat.Implementation;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DiplomskiProjekat.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InitialController : ControllerBase
    {
        private readonly UseCaseHandler _useCaseHandler;

        public InitialController(UseCaseHandler handler)
        {
            _useCaseHandler = handler;
        }
        // POST api/<InitialController>
        [HttpPost]
        public void Post([FromServices] IFillDatabaseCommand command)
        {
            _useCaseHandler.HandleCommand(command, 0);
        }

    }
}
