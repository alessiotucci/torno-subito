using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorialBlazor.Shared
{
    public class History

    {
        public float Value1 { get; set; }
        public float Value2 { get; set; }
        public string Operation { get; set; }

        public float Result { get; set; }
        public DateTime DateAndTime { get; set; }
        public History(float value1, float value2, string operation, float  result, DateTime dateandtime)
        {
            value1 = Value1;
            value2 = Value2;
            Operation = operation;
            DateAndTime = dateandtime;
            Result = result;
        }

    }
}
