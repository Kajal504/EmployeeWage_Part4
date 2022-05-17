// See https://aka.ms/new-console-template for more information
using EmployeeWage_Part4;
Console.WriteLine("Hello, World!");

//EmpWage_Builder.EmpWageBuilder();

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
}



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
}