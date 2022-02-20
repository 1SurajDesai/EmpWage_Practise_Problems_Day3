using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgram
{
    public class WageUsingSwitchCase
    {
        const int IsPartTime = 1;
        const int IsFullTime = 2;
        public static void CalWageSwitchCase()
        {
            
            int EmpHr = 0, sallary = 0, EmpRatePerHr = 20;
            Random random = new Random();
            int EmpCheck = random.Next(3);
            switch (EmpCheck)
            {
                case IsFullTime:
                    EmpHr = 8;
                    break;
                case IsPartTime:
                    EmpHr = 4;
                    break;
                default:
                    EmpHr = 0;
                    break;


            }
            sallary = EmpRatePerHr * EmpHr;
            Console.WriteLine("Sallary of employee is" + " " + sallary);        }
    }
}
