using System;
using System.Net.Http.Headers;

namespace EmployeeManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            //EmployeeOperations operations = new EmployeeOperations();
            //List<Employee> list = new List<Employee>();
            //list.Add(new Employee() { Name = "a", City = "a", Address = "a" });
            //list.Add(new Employee() { Name = "b", City = "b", Address = "b" });
            //list.Add(new Employee() { Name = "c", City = "c", Address = "c" });
            //list.Add(new Employee() { Name = "d", City = "d", Address = "d" });
            //list.Add(new Employee() { Name = "e", City = "e", Address = "e" });
            //Operations operations1 = new Operations();
            //operations1.UsingWithoutThread(list);
            //operations1.UsingWithThread(list);

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
            TaskParallelLibrary task = new TaskParallelLibrary();
            task.TaskParallelOperation();
        }
    }
}