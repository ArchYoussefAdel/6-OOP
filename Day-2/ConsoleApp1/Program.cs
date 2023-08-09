using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum JobTitle
{
    Manager = 1,
    Employee = 2,
    HR = 3
}
enum JobHour
{
    Fulltime = 1,
    Partime = 2
}
class Employee
{
    protected int id;
    protected string name;
    protected int age;

    protected JobTitle title;
    protected JobHour hour;
    public int GetId()
    {
        return id;
    }
    public string GetName()
    {
        return name;
    }
    public int GetAge()
    {
        return age;
    }
    public JobTitle GetJobTitle()
    {
        return title;
    }
    public JobHour GetJobHour()
    {
        return hour;
    }
    public Employee() { }
    public Employee(int i) { id = i; }
    public Employee(int i, string n) { id = i; name = n; }
    public Employee(int i, string n, int a) { id = i; name = n; age = a; }
    public Employee(int i, string n, int a, JobTitle t) { id = i; name = n; age = a; title = t; }
    public Employee(int i, string n, int a, JobTitle t, JobHour h) { id = i; name = n; age = a; title = t; hour = h; }
    public static void Fill(Employee[] EmployeeSheet)
    {
        for (int EmployeeNumber = 0; EmployeeNumber < EmployeeSheet.Length; EmployeeNumber++)
        {

            Console.WriteLine($"Enter the name for employee No.{EmployeeNumber + 1}");
            string name = Console.ReadLine();
            Console.WriteLine($"Enter the id for employee No.{EmployeeNumber + 1}");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter the age for employee No.{EmployeeNumber + 1}");
            int age = int.Parse(Console.ReadLine());


            //Console.Write($"Enter the job title for employee No.{EmployeeNumber + 1} (0 - Manager, 1 - Employee, 2 - HR)");
            //string titleInput = Console.ReadLine();
            //JobTitle title;

            //switch (titleInput)
            //{
            //    case "0":
            //        title = JobTitle.Manager;
            //        break;
            //    case "1":
            //        title = JobTitle.Employee;
            //        break;
            //    case "2":
            //        title = JobTitle.HR;
            //        break;
            //    default:
            //        title = JobTitle.Employee;
            //        break;
            //}

            //Console.Write($"Enter the job hour for employee No.{EmployeeNumber + 1} (0 - Fulltime, 1 - Partime)");
            //string hourInput = Console.ReadLine();
            //JobHour hour;

            //switch (hourInput)
            //{
            //    case "0":
            //        hour = JobHour.Fulltime;
            //        break;
            //    case "1":
            //        hour = JobHour.Partime;
            //        break;
            //    default:
            //        hour = JobHour.Fulltime;
            //        break;
            //}


            Console.WriteLine($"Enter the job title for employee No.{EmployeeNumber + 1} (1 - Manager, 2 - Employee, 3 - HR)");
            int titleIndex = int.Parse(Console.ReadLine());
            JobTitle title = (JobTitle)titleIndex;

            Console.WriteLine($"Enter the job hour for employee No.{EmployeeNumber + 1} (1 - Fulltime, 2 - Partime)");
            int hourIndex = int.Parse(Console.ReadLine());
            JobHour hour = (JobHour)hourIndex;

            ////// EmployeeSheet[EmployeeNumber] = new Employee(id, name, age, title, hour);
            ///
            //Console.WriteLine($"Enter the name for employee No.{EmployeeNumber + 1}");
            //JobTitle title = Console.ReadLine();
            //Console.WriteLine($"Enter the name for employee No.{EmployeeNumber + 1}");
            //JobHour hour = Console.ReadLine();
            Employee NewEmployee = new Employee(id, name, age, title, hour);
            //Employee NewEmployee = new Employee(id, name, age);

            EmployeeSheet[EmployeeNumber] = NewEmployee;
        }
    }
    public void PrintData(Employee[] EmployeeSheet)
    {
        foreach (Employee NewEmployee in EmployeeSheet)
        {
            Console.WriteLine($"Employee ID:   {NewEmployee.GetId()}");
            Console.WriteLine($"Employee Name: {NewEmployee.GetName()}");
            Console.WriteLine($"Employee Age:  {NewEmployee.GetAge()}");
            Console.WriteLine($"Employee Title:{NewEmployee.GetJobTitle()}");
            Console.WriteLine($"Employee Hour: {NewEmployee.GetJobHour()}");
        }
    }
}
class Lap_2_1
{
    public static void Main()
    {
        Console.WriteLine($"Enter the Count of employees ");
        int EmployeeCount = int.Parse(Console.ReadLine());

        Employee[] EmployeeSheet = new Employee[EmployeeCount];

        Employee.Fill(EmployeeSheet);

        Employee e = new Employee();

        e.PrintData(EmployeeSheet);
    }
}
