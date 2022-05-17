using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage_Part4
{
    internal class FinalSolution
    {
        public interface IComputeEmpWage
        {
            public void addCompanyEmpWage(string Company, int empRatePerHour, int numOfWorkingDays, int maxHourPerMonth);

            public void ComputeEmpWage();
            public int getTotalWage(string Company);
        }
        public class CompanyEmpWage
        {
            public string Company;
            public int empRatePerHour;
            public int numOfWorkingDays;
            public int maxHoursPerMonth;
            public int totalEmpWage;

            public CompanyEmpWage(string Company, int empRatePerHour, int numOfWorkingDays, int maxHourPerMont)
            {
                this.Company = Company;
                this.empRatePerHour = empRatePerHour;
                this.numOfWorkingDays = numOfWorkingDays;
                this.maxHoursPerMonth = maxHoursPerMonth;
                this.totalEmpWage = 0;
            }
            public void setTotalEmpWage(int totalEmpWage)
            {
                this.totalEmpWage = totalEmpWage;
            }
            public string toString()
            {
                return "Total Emp Wage for Company :" + this.Company + " is: " + this.totalEmpWage;
            }
        }
        public class EmpWageBuilder
        {
            public const int IS_PART_TIME = 1;
            public const int IS_FULL_TIME = 2;

            private LinkedList<CompanyEmpWage> CompanyEmpWageList;
            private Dictionary<string, CompanyEmpWage> CompanyToEmpWageMap;

            public EmpWageBuilder()
            {
                this.CompanyEmpWageList = new LinkedList<CompanyEmpWage>();
                this.CompanyToEmpWageMap = new Dictionary<string, CompanyEmpWage>();
            }
            public void addCopmanyEmpWage(string Company, int empRatePerHour, int numOfWorkingDays, int maxHourPerMonth)
            {
                CompanyEmpWage companyEmpWage = new CompanyEmpWage(Company, empRatePerHour, numOfWorkingDays, maxHourPerMonth);
                this.CompanyEmpWageList.AddLast(companyEmpWage);
                this.CompanyToEmpWageMap.Add(Company, companyEmpWage);

            }
            public void ComputeEmpWage()
            {
                foreach (CompanyEmpWage companyEmpWage in this.CompanyEmpWageList)
                {
                    companyEmpWage.setTotalEmpWage(this.ComputeEmpWage(companyEmpWage));
                    Console.WriteLine(companyEmpWage.toString());
                }
            }
            private int ComputeEmpWage(CompanyEmpWage companyEmpWage);

            
               public int getTotalWage(string Company)
               {

                return this.CompanyToEmpWageMap[Company].totalEmpWage;
               }
            
                

               
        }
        class Program
        {
            static void Main(string[] args)
            {
                EmpWageBuilder empWageBuilder = new EmpWageBuilder();
                empWageBuilder.addCopmanyEmpWage("DMart", 20, 2, 10);
                empWageBuilder.addCopmanyEmpWage("Reliance", 10, 4, 20);
                empWageBuilder.ComputeEmpWage();
                Console.WriteLine("Total Wage for DMart Company: " + empWageBuilder.getTotalWage("DMart"));
            }
        }
    }
}
