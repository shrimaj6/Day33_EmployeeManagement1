using System;

namespace EmployeeManagement1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to EmployeePayRoll");
            EmployeeRepo repo = new EmployeeRepo();
            EmployeeModel employee = new EmployeeModel();

            employee.EmployeeName = "bill gates";
            employee.PhoneNumber = "8558562588";
            employee.Address = "Pune";
            employee.Department = "Tech";
            employee.Gender = 'M';
            employee.BasicPay = 222000;
            employee.Deductions = 212;
            employee.TaxablePay = 454;
            employee.Tax = 465;
            employee.NetPay = 25898;
            employee.City = "Pune";
            employee.Country = "India";
            employee.StartDate = DateTime.Now;

            repo.AddEmployee(employee);
            repo.GetAllEmployee();


        }
    }
}
