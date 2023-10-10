using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class Operations
    {
        EmployeeOperations operations = new EmployeeOperations();
        public void UsingWithoutThread(List<Employee> list)
        {
            DateTime start = DateTime.Now;
            foreach (var data in list)
            {
                operations.AddEmployee(data);
            }
            DateTime end = DateTime.Now;
            Console.WriteLine("Duration Without Thread:" + (end - start));
        }
        public void UsingWithThread(List<Employee> list)
        {
            DateTime start = DateTime.Now;
            foreach (var data in list)
            {
                Task threads = new Task(() =>
                {
                    Console.WriteLine("Being Added:" + data.Name);
                    operations.AddEmployee(data);
                    Console.WriteLine("Added:" + data.Name);
                });
            }
            DateTime end = DateTime.Now;
            Console.WriteLine("Duration With Thread:" + (end - start));
        }
    }
}
