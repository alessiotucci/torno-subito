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
        private History ciao = new History();
        

        [HttpGet]
        public IEnumerable<History> GetHistory()
        {
      
            return ListHistory;
            
        }
        [HttpGet("{id}")]
        public IActionResult GetHistoryById(Guid id)
        {
            var history = ListHistory.FirstOrDefault(h => h.Id == id);

            if (history == null)
            {
                return NotFound(); // Return a 404 Not Found response if the history item is not found
            }
            return Ok(history);

        }


        [HttpPost]
        public IActionResult AddToHistory([FromBody] History history)
        {
            //if (history == null)
            //{
             //   return BadRequest("Invalid history data");
            //}

            // Add the received history data to your list
            ListHistory.Add(history);

            return Ok(history);
        }

        [HttpDelete("{id}")]

        public IActionResult Delete(Guid Id)
        {
            var HistoryToRemove = ListHistory.FirstOrDefault(x => x.Id == Id);
            if (HistoryToRemove == null)
            {
                return NotFound(); // Return a 404 response if the item with the given ID is not found
            }
            else 
            {
                ListHistory.Remove(HistoryToRemove);
                return Ok();
            }
           
        }
        [HttpPut("{id}")]

        public IActionResult Edit(Guid Id, History UpdatedHistory)
        
       {
            var HistoryToUpdate = ListHistory.FirstOrDefault(y => y.Id == Id);
            if (HistoryToUpdate == null)
            { 
                return NotFound();
            }
            else
            {
                HistoryToUpdate.Value1 = UpdatedHistory.Value1;
                HistoryToUpdate.Value2 = UpdatedHistory.Value2;
                HistoryToUpdate.Operation = UpdatedHistory.Operation;
                HistoryToUpdate.Result = UpdatedHistory.Result;
            }
            return Ok();
       }

    }
}
