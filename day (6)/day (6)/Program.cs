// Using Enums in c# 

/*

using System;

class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
    public Level Level { get; set; }
}

public enum Level
{
    First,
    Second,
    Third,
    Fourth
}

class Program
{
    static void Main()
    {
        Student[] students = new Student[3];

        students[0] = new Student()
        {
            ID = 1,
            Name = "Nour",
            Level = Level.First
        };

        students[1] = new Student()
        {
            ID = 2,
            Name = "Ahmed",
            Level = Level.Third
        };

        students[2] = new Student()
        {
            ID = 3,
            Name = "Mona",
            Level = Level.Second
        };

        foreach (Student s in students)
        {
            Console.WriteLine(
                "Name: {0}, Level: {1}",
                s.Name,
                getLevel(s.Level)
            );
        }

        Console.ReadKey();
    }

    public static string getLevel(Level level)
    {
        switch (level)
        {
            case Level.First:
                return "First Year";

            case Level.Second:
                return "Second Year";

            case Level.Third:
                return "Third Year";

            case Level.Fourth:
                return "Fourth Year";

            default:
                return "Unknown";
        }
    }
}
*/




//Access Modifiers:

using System;

class Employee
{
    public string Name;

    //emp.Name="Ahmed"
    private int Salary;
//  اقدر اعلمه من خلال الميثود اللي موجوده جوا ال employee
    //public void SetSalary(int salary)
    //{
     //salary = salary;
    //}
    // عملنا بؤايفت سلاري من جوا الكلاس نفسه
    protected string Department;

    public void SetSalary(int salary)
    {
        Salary = salary;
    }

    public void ShowEmployee()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Salary: " + Salary);
        Console.WriteLine("Department: " + Department);
    }
}

class Manager : Employee
{
    public void SetDepartment()
    {
        Department = "IT";
    }

    public void ShowManager()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Department: " + Department);
    }
}

class Program
{
    static void Main()
    {
        Employee emp = new Employee();

        emp.Name = "Ahmed";
        emp.SetSalary(5000);

        Manager manager = new Manager();

        manager.Name = "Omar";
        manager.SetDepartment();

        Console.WriteLine("Employee:");
        emp.ShowEmployee();

        Console.WriteLine();

        Console.WriteLine("Manager:");
        manager.ShowManager();

        Console.ReadKey();
    }
}
