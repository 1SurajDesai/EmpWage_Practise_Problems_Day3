using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgram
{
    public class PartTimeEmpWage
    {
        public static void CalEmpWage()
        {
            int IsPartTime = 1, IsFullTime = 2, EmpHr = 0, sallary = 0, EmpRatePerHr = 20;
            Random random =  new Random();
            int EmpCheck = random.Next(3);
            if (EmpCheck == IsPartTime)
            {
                EmpHr = 4;
            }
            else if (EmpCheck == IsFullTime)
            {
                EmpHr = 8;
            }
            else
            {
                EmpHr = 0;
            }
            sallary = EmpHr * EmpRatePerHr;
            Console.WriteLine("Sallary of employee is =" + sallary);
        }
    }
}
