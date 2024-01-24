using DiplomskiProjekat.Api.Core;
using DiplomskiProjekat.Implementation;
using DiplomskiProjekat.Implementation.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DiplomskiProjekat.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly JwtManager _jwtManager;
        private readonly UseCaseHandler _useCaseHandler;

        public UserController(JwtManager jwtManager, UseCaseHandler useCaseHandler)
        {
            _jwtManager = jwtManager;
            _useCaseHandler = useCaseHandler;
        }

        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UserController>
        [HttpPost("/api/token")]
        [AllowAnonymous]
        public IActionResult Token([FromBody] TokenRequestDto request)
        {
            try
            {
                var token = _jwtManager.MakeToken(request.Email, request.Password);
                return Ok(new { token });
            }
            catch (UnauthorizedAccessException)
            {
                return Unauthorized();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
