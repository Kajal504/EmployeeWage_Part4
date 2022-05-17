using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage_Part4
{
    internal class EmpWage_Builder
    {
        public static void EmpWageBuilder()
        {
            EmpWageBuilderObject dMart = new EmpWageBuilderObject("DMart", 20, 2, 10);
            EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance", 10, 4, 20);
            dMart.ComputeEmpWage();
            Console.WriteLine(dMart.toString());
            reliance.ComputeEmpWage();
            Console.WriteLine(reliance.toString());
        }
        public class EmpWageBuilderObject
        {
            public const int IS_PART_TIME = 1;
            public const int IS_FULL_TIME = 2;

            private string Company;
            private int empRatePerHour;
            private int numOfWorkingDays;
            private int maxHoursPerMonth;
            private int totalEmpWage;

            public EmpWageBuilderObject(string Company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
            {
                this.Company = Company;
                this.empRatePerHour = empRatePerHour;
                this.numOfWorkingDays = numOfWorkingDays;
                this.maxHoursPerMonth = maxHoursPerMonth;
            }
            public void ComputeEmpWage()
            {
                int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
                while (totalEmpHrs <= this.maxHoursPerMonth && totalWorkingDays < this.numOfWorkingDays)
                {
                    totalWorkingDays++;
                    Random random = new Random();
                    int empCheck = random.Next(0, 3);
                    switch (empCheck)
                    {
                        case IS_PART_TIME:
                            empHrs = 4;
                            break;
                        case IS_FULL_TIME:
                            empHrs = 8;
                            break;
                        default:
                            empHrs = 0;
                            break;
                    }
                    totalEmpHrs += empHrs;
                    Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hrs :" + empHrs);

                }
                totalEmpWage = totalEmpHrs * this.empRatePerHour;
                Console.WriteLine("Total Emp Wage for Compnay :" + Company + " is: " + totalEmpWage);
            }
            public string toString()
            {
                return "Total Emp Wage for Company:" + " is:" + this.totalEmpWage;
            }
        }

    }
    
}
