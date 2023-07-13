using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using not_working.model2;
using System.Text.Json;

namespace not_working.Pages
{
    public class TryModel : PageModel
    {
        public List<Sede> Lista { get; set; }

        public TryModel()
        {
            //public IActionResult Onpost()
            //{ }
            string nomeFile = "./wwwroot/json/sedi.json";

            using (FileStream oggettoFileSystem = System.IO.File.OpenRead(nomeFile))
            {
                var oggetto = JsonSerializer.Deserialize<Sedi>(oggettoFileSystem);
                // Lista = obj.ListaSedi.Where(x =>Descrizione.Contains(ParamDescrizione)).ToList();
                Lista = oggetto.ListaSedi;
            }
            // return Page();
        }

        public void OnGet()
        {

        }
    }
}
