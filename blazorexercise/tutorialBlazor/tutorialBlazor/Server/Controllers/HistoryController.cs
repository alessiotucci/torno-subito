using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using tutorialBlazor.Shared;
using System.Collections.Generic; // Add this namespace


namespace tutorialBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoryController : ControllerBase
    {
        public static List<History> ListHistory = new List<History>();


        [HttpGet]




        public IEnumerable<History> Get()
        {
            DateTime date = DateTime.MinValue;
            History history1 = new History(2, 3, "addition", date);
 

           // Enumerable 
            List<History> list = new List<History>();
            list.Add(history1);


            return list; 
              
        }
        [HttpPost("SaveHistory")]
        public IActionResult SaveHistory([FromBody] History historyEntry)
        {
            ListHistory.Add(historyEntry);
            return Ok();
        }

    }
}
