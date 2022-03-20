using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayRoll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeOperation operation = new EmployeeOperation();
            List<Employee> EmpList = new List<Employee>()

            //operation.GetAllEmployees();

            //bool res = operation.DeleteEmployee("Harshal");
            //Console.WriteLine(res);

            //bool result = operation.ShowEmployeeName("Santosh");
            //Console.WriteLine(result);

            {
                new Employee()
                {


                Name = "Arjun",
                StartDate = DateTime.Now,
                gender = "Male",
                phonenumber = "9655454878",
                address = "Dhule",
                department = "Quality Department",
                BasicPay = 39000,
                Deduction = 2000,
                TaxablePay = 4000,
                Tax = 620,
                NetPay = 37000
                },

                new Employee()
                {


                Name = "Shivdas",
                StartDate = DateTime.Now,
                gender = "Male",
                phonenumber = "9566454878",
                address = "Nandurbar",
                department = "Finance Department",
                BasicPay = 40000,
                Deduction = 2000,
                TaxablePay = 4000,
                Tax = 620,
                NetPay = 38000
                },
                  new Employee()
                {


                Name = "Teja",
                StartDate = DateTime.Now,
                gender = "Male",
                phonenumber = "9656464694",
                address = "Dhule",
                department = "Purchase Department",
                BasicPay = 45000,
                Deduction = 2000,
                TaxablePay = 5000,
                Tax = 620,
                NetPay = 39000
                },
                    new Employee()
                {


                Name = "Ashwini",
                StartDate = DateTime.Now,
                gender = "Female",
                phonenumber = "9623454878",
                address = "Jalgaon",
                department = "Quality Department",
                BasicPay = 35000,
                Deduction = 500,
                TaxablePay = 2000,
                Tax = 620,
                NetPay = 32000
                },
                      new Employee()
                {


                Name = "Akshay",
                StartDate = DateTime.Now,
                gender = "Male",
                phonenumber = "7566552724",
                address = "Badwani",
                department = " Store Department",
                BasicPay = 24000,
                Deduction = 400,
                TaxablePay = 2500,
                Tax = 620,
                NetPay = 21000
                }
          };
            DateTime startDate = DateTime.Now;
            operation.AddEmployeePayrollwithoutThread(EmpList);
            DateTime stopDate = DateTime.Now;
            Console.WriteLine("Time Duration Without Tread" +( stopDate - startDate));

             startDate = DateTime.Now;
            operation.AddEmployeePayrollWithThread(EmpList);
              stopDate = DateTime.Now;
            Console.WriteLine("Time Duration With Tread" +( stopDate - startDate));
            Console.ReadLine();
        }
    }
}
