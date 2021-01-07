using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConcepts.com._02basicconcepts
{
    class Employee
    {
       private int empId;
       private string empName;
       public double salary { get; set; }
       public int grade { get; set; }

       private string company="IBM";

        IEmail email;

        public Employee(int empId, String empName,IEmail email)
        {
            this.empId = empId;
            this.empName = empName;
            this.email = email;
        
        }

        public void NotifyEmployee()
        {
            email.SendEmail();
        }
    }

    class TestEmployee
    {
        static void Main()
        {

            IEmail email = new OutlookEmail();
            Employee obj = new Employee(100,"Alex",email);
            obj.salary = 100000;
            obj.NotifyEmployee();

            email = new WebserviceEmail();
            Employee obj3 = new Employee(200, "Lynda",email);
            obj3.NotifyEmployee();



        }
    }
}
