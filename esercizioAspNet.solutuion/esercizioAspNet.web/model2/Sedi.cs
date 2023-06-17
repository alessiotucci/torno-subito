using System.Text.Json;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace esercizioAspNet.web.model2
{
    public class Sedi
    {
        public List<Sede> ListaSedi { get; set; }

        public Sedi()
        {
            ListaSedi = new List<Sede>();
        }

    }

}