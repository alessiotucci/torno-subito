using System.Text.Json;
using esercizioAspNet.web.model2;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace esercizioAspNet.web.model2
{
    public class Titoli
    {

        public List<TitoliDiStudio> titoliDiStudio   { get; set; }

        public Titoli()
        {
            titoliDiStudio = new List<TitoliDiStudio>();
        }
    }
}
