using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorialBlazor.Shared
{
    public class History

    {
        [Key]
        public Guid Id { get; set; }
        public float Value1 { get; set; }
        public float Value2 { get; set; }
        public string Operation { get; set; }

        public float Result { get; set; }
        public DateTime DateAndTime { get; set; }
        

    }
}
