using esercizioAspNet.web.model2;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace esercizioAspNet.web.Pages
{
    public class titoliModel : PageModel
    {
        public List<TitoliDiStudio> Lista { get; set; }

        public titoliModel()
        {
            string nomeDelFile = "./wwwroot/json/titoloDiStudio.json";
            //string nomeFile = "./wwwroot/json/sedi.json";


            using (FileStream oggFilSysm = System.IO.File.OpenRead(nomeDelFile))
            {
                var thisy = JsonSerializer.Deserialize<Titoli>(oggFilSysm);
                Lista = thisy.titoliDiStudio;
            }
        }
        public void OnGet()
        {

        }

    }
}
