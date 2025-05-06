using Microsoft.AspNetCore.Mvc;

namespace APICowMilk.Controllers
{
    public class MilkController : ControllerBase
    {
        [HttpGet("GetMeMilk")]

        public IActionResult GetGotMilk()
        {
            return Ok("Here is milk :) ");
        }

    }
}
