using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using esercizioAspNet.web.model2;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace esercizioAspNet.web.Pages
{
    public class SediModel : PageModel // check the syntax of c# and exended class

    {
        public List<Sede> Lista { get; set; }

        public SediModel()
        {
            //public IActionResult Onpost()
            //{ }
            string nomeFile = "./wwwroot/json/sedi.json";

            using (FileStream oggettoFileSystem = System.IO.File.OpenRead(nomeFile))
            {
                var oggetto   = JsonSerializer.Deserialize<Sedi>(oggettoFileSystem);
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