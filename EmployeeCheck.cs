using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgram
{
    public class EmployeeCheck
    {
        public static void EmployeeAbsentOrPresent()
        {
            int num;
            Random random = new Random();
            num = random.Next(2);
            if (num == 1)
            {
                Console.WriteLine("Employee is present");

            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
