/*
**********************************
* Author: Damira Mamuzić
* Project Task: City
**********************************
* Description:
*  
*  The program has endpoints to:
*      1. Takes two parameters (Resident name, City name) from Route and return response with status OK and text
*          "Resident {Resident name} lives in {City name} City :: from route"
*      2. Takes two parameters (Resident name, City name) from Query and return response with status OK and text
*          "Resident {Resident name} lives in {City name} City :: from query"
*      3. Takes one parameter (City name) from Body and return response with status OK and tekst
*          "Hello from {City name} City!"
*
**********************************
*/

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiCity.Controllers
{
    [ApiController]
    public class CityController : ControllerBase
    {
        [HttpGet]
        [Route("/cities/{residentName}/{cityName}")]
        public IActionResult RouteGet([FromRoute] string residentName, [FromRoute] string cityName)
        {
            return Ok($"Resident {residentName} lives in {cityName} City :: from route");
        }

        [HttpGet]
        [Route("/query")]
        public IActionResult QueryGet([FromQuery] string residentName, [FromQuery] string cityName)
        {
            return Ok($"Resident {residentName} lives in {cityName} City :: from query");
        }

        [HttpPost]
        [Route("/post")]
        public IActionResult GetFromBody([FromBody] string cityName)
        {
            return Ok($"Hello from {cityName} City!");
        }
    }
}
