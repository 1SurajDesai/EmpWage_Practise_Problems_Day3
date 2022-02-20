using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgram
{
    public class CalWageTillCondMeet
    {
        const int IsPartTime = 1;
        const int IsFullTime = 2;
        public static void CalWage()
        {

            int EmpHr = 0, sallary = 0, EmpRatePerHr = 20, WorkingDaysPerMonth = 20, TotalHr = 0, maxRateInMonth = 100;
            int WorkingDays = 1;
            Random random = new Random();

            while (TotalHr <= maxRateInMonth && WorkingDays <= WorkingDaysPerMonth)
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
                WorkingDays++;

            }
            sallary = TotalHr * EmpRatePerHr;
            Console.WriteLine(" sallary of employee for a month is " + " " + sallary);

        }

    }
}

