using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgram
{
    public class EmpyeeWage
    {
        public static void CalculateEmpWage()
        {
            int num;
            int EmpRatePerHr = 20, HrPerDay = 8, sallary = 0;
            Random random = new Random();
            num = random.Next(2);
            if (num == 1)
            {
                sallary = EmpRatePerHr * HrPerDay;
                Console.WriteLine("Sallary of employee is "+ sallary);

            }
            else
            {
                Console.WriteLine("Sallary of employee is " + sallary);

            }
        }
    }
}
