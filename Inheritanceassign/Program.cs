using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentInheritance
{
    public class Members
    {
        public string name, address, phonenum;
        public int age;
        public double salary;

        
        public void printSalary()
        {
            Console.WriteLine("Salary of member is " + salary);
        }
    }
    public class Employee : Members
    {
        public string specialization;
        public string department;
        public Employee (string specialization, string department)
        {
            this.specialization = specialization;
            this.department = department;
        }
    }
    public class Manager : Members
    {
        public string specialization;
        public string department;
        public Manager(string specialization, string department)
        {
            this.specialization = specialization;
            this.department = department;
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            string a, b, c, d;

            Members m = new Members();
            
            m.name = "Saksham";
            m.age = 21;
            m.address = "bangalore";
            m.phonenum = "9589026052";
            m.salary = 20500;
            m.printSalary();
            Console.WriteLine("The name : {0} \n age : {1} \n address : {2}\n phonenum : {3}\n", m.name, m.age, m.address, m.phonenum);

            Console.WriteLine("Enter specialization for employee");
            a = Console.ReadLine();
            Console.WriteLine("Enter department for employee");
            b = Console.ReadLine();
            Employee e = new Employee(a,b);
            e.name = "Swati";
            e.age = 22;
            e.address = "bangalore";
            e.phonenum = "7778778787";
            e.salary = 25500;
            e.printSalary();
            Console.WriteLine("The name : {0} \n age : {1} \n address : {2}\n phonenum : {3}\n Specialization : {4}\n department: {5}\n", e.name, e.age, e.address, e.phonenum, e.specialization, e.department);

            Console.WriteLine("Enter specialization for manager");
            c = Console.ReadLine();
            Console.WriteLine("Enter department for manager");
            d = Console.ReadLine();
            Manager mn  = new Manager(c, d);
            e.name = "Arun";
            e.age = 22;
            e.address = "bangalore";
            e.phonenum = "9589050000";
            e.salary = 25500;
            e.printSalary();
            Console.WriteLine("The name : {0} \n age : {1} \n address : {2}\n phonenum : {3}\n Specialization : {4}\n department: {5}\n", e.name, e.age, e.address, e.phonenum, mn.specialization, mn.department);

        }
    }
}
