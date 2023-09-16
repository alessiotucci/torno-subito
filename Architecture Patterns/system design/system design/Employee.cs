using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace system_design
{
    internal class Employee : IEmployee
    {
        void IEmployee.GetEmployee(int parametro1)
        {
            Console.WriteLine("sto recuperando con la GET");
        }

        void IEmployee.SaveEmployee(int parametro2)
        {
            throw new NotImplementedException();
        }
    }
}
