using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgram
{
    public class WageForMonth
    {
        const int IsPartTime = 1;
        const int IsFullTime = 2;
        public static void CalWageOfMonth()
        {
            int EmpHr = 0, sallary = 0, EmpRatePerHr = 20, WorkingDaysPerMonth = 20, TotalHr = 0;
            Random random = new Random();
            

            for (int day = 1; day <= WorkingDaysPerMonth; day++)
            {
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
                TotalHr += EmpHr;
            }
            sallary = TotalHr * EmpRatePerHr;
            Console.WriteLine(" sallary of employee for a month is " + " " + sallary);

        }
    }
}
