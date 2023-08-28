using System;

namespace EmployeeManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee()
            //{
            //    Name = "Riya",
            //    City = "Pathanamthitta",
            //    Address = "Annikkanadu",
            //};
            EmployeeOperations operations = new EmployeeOperations();
            //operations.AddEmployee(employee);
            //operations.DeleteEmployee(3);
            //operations.GetAllEmployee();
            Employee employee1 = new Employee()
            {
                EmpId = 1,
                Name = "Riya Susan Reji",
                City = "Pathanamthitta",
                Address = "Annikkanadu",
            };
            operations.UpdateEmployee(employee1);
        }
    }
}