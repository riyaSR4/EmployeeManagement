using System;

namespace EmployeeManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeOperations operations = new EmployeeOperations();
            List<Employee> list = new List<Employee>();
            list.Add(new Employee() { Name = "a", City = "a", Address = "a" });
            list.Add(new Employee() { Name = "b", City = "b", Address = "b" });
            list.Add(new Employee() { Name = "c", City = "c", Address = "c" });
            list.Add(new Employee() { Name = "d", City = "d", Address = "d" });
            list.Add(new Employee() { Name = "e", City = "e", Address = "e" });
            DateTime start = DateTime.Now;
            foreach (var data in list)
            {
                operations.AddEmployee(data);
            }
            DateTime end = DateTime.Now;
            Console.WriteLine("Duration without Thread " + (end - start));

            //Employee employee = new Employee()
            //{
            //    Name = "abc",
            //    City = "bcd",
            //    Address = "c",
            //};
            //Employee emp = operations.AddEmployee(employee);
            //Console.WriteLine(emp.EmpId + "---" + emp.Name);
            //operations.AddEmployee(employee);
            //operations.DeleteEmployee(3);
            //operations.GetAllEmployee();
            //Employee employee1 = new Employee()
            //{
            //    EmpId = 1,
            //    Name = "Riya Susan Reji",
            //    City = "Pathanamthitta",
            //    Address = "Annikkanadu",
            //};
            //operations.UpdateEmployee(employee1);
        }
    }
}