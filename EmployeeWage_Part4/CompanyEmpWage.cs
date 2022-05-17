using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage_Part4
{
    public class CompanyEmpWage
    {
        public string company;
        public int empRatePerHour;
        public int numOfWorkingDays;
        public int maxHoursPerMonth;
        public int totalEmpWage;
        public CompanyEmpWage(string Company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = Company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;

        }
        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;

        }
        public string toString()
        {
            return "Total Emp Wage for company :" + this.company + " is:" + this.totalEmpWage;
        }

        class Program
        {
            static void Main(String[] args)
            {
                EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
                empWageBuilder.addCompanyEmpWage("DMart", 20, 2, 10);
                empWageBuilder.addCompanyEmpWage("Reliance", 10, 2, 20);
                empWageBuilder.ComputeEmpWage();
            }
        }
        public class EmpWageBuilderArray
        {
            public const int IS_PART_TIME = 1;
            public const int IS_FULL_TIME = 2;

            private int numOfCompany = 0;
            private CompanyEmpWage[] CompanyEmpWageArray;

            public EmpWageBuilderArray()
            {
                this.CompanyEmpWageArray = new CompanyEmpWage[5];
            }
            public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
            {
                CompanyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
                numOfCompany++;
            } 
            public void ComputeEmpWage()
            {
                for (int i = 0; i < numOfCompany; i++)
                {
                    CompanyEmpWageArray[i].setTotalEmpWage(this.ComputeEmpWage(this.CompanyEmpWageArray[i]));
                    Console.WriteLine(this.CompanyEmpWageArray[i].toString());
                }
            }
            private int ComputeEmpWage(CompanyEmpWage CompanyEmpWage) 
            {
                //variables
                int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
                //computation
                while (totalEmpHrs <= CompanyEmpWage.maxHoursPerMonth && totalWorkingDays < CompanyEmpWage.numOfWorkingDays)
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
                return totalEmpHrs * CompanyEmpWage.empRatePerHour; 
            }
        }

    }
}
