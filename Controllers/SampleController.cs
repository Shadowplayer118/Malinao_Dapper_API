using Microsoft.AspNetCore.Mvc;

namespace Malinao_Dapper_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SampleController : ControllerBase{
        public SampleController(){
        }
        [HttpGet ("WhoAmI")]
        public IActionResult WhoAmI(){
            return Ok("I am boy");
        }
         [HttpPost ("NiceToMeetYou")]
        public IActionResult NiceToMeetYou(string ? YourName){

            if(string.IsNullOrEmpty(YourName)){
                return BadRequest("Dumb  Nigga");
            }
            else{
                return Ok($"Nice to meet you {YourName}");
            }
        }
    }
}