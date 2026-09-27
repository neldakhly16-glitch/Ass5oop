// 1- foreach:
/*
using System;

class Program
{
    static void Main()
    {
        string[] students =
        {
            "Naglaa",
            "Rawan",
            "Sara",
            "Mariam"
        };

        foreach (string student in students)
        {
            Console.WriteLine(student);
        }
        Console.WriteLine("====================================================");
        // 2- foreach
        int[] grades =
        {
            90,
            85,
            70,
            95
        };

        foreach (int grade in grades)
        {
            Console.WriteLine(grade);
        }
        Console.WriteLine("====================================================");




    }
}*/





//1-hiding & shadowing:
/*
using System;

public class Student
{
    public string FirstName = "Naglaa" ;
    public string LastName = "Eldakhly";
    public string Department;

    public void PrintStudentInfo()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}

public class RegularStudent : Student
{
    public new void PrintStudentInfo()
    {
        base.PrintStudentInfo();
        Console.WriteLine("hello naglaa");
    }
}

public class OnlineStudent : Student
{
    public new void PrintStudentInfo()
    {
        base.PrintStudentInfo();

        Console.WriteLine("The Student From Online Department");
    }
}

class Program
{
    static void Main()
    {
        OnlineStudent student1 = new OnlineStudent();

        student1.PrintStudentInfo();

        Console.WriteLine("===============================");

        RegularStudent student2 = new RegularStudent();
        

        student2.PrintStudentInfo();

        Console.WriteLine("===============================");

        ((Student)student1).PrintStudentInfo();

        Console.ReadKey(false);
    }
}*/


// 2- polymorphism & overriding:
/*
using System;

public class Student
{
    public string FirstName = "Naglaa";
    public string LastName = "Eldakhly";
    public string Department;

    public virtual void PrintStudentInfo()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}

public class RegularStudent : Student
{
    public override void PrintStudentInfo()
    {
        Console.WriteLine(
            "{0} {1} The Student From Regular Department",
            base.FirstName,
            base.LastName
        );
    }
}

public class OnlineStudent : Student
{
    public override void PrintStudentInfo()
    {
        Console.WriteLine(
            "{0} {1} The Student From Online Department",
            base.FirstName,
            base.LastName
        );
    }
}

public class ScholarshipStudent : Student
{
    public override void PrintStudentInfo()
    {
        Console.WriteLine(
            "{0} {1} The Student Has A Scholarship",
            base.FirstName,
            base.LastName
        );
    }
}

class Program
{
    static void Main()
    {
        Student[] students = new Student[4];

        students[0] = new Student();
        students[1] = new RegularStudent();
        students[2] = new OnlineStudent();
        students[3] = new ScholarshipStudent();

        foreach (Student student in students)
        {
            student.PrintStudentInfo();
        }

        Console.ReadKey(false);
    }
}
*/



// Overloading:
/*
using System;

class Calculator
{
    public int Sum(int num1, int num2)
    {
        return num1 + num2;
    }

    public int Sum(int num1, int num2, int num3)
    {
        return num1 + num2 + num3;
    }
}

class Program
{
    static void Main()
    {
        Calculator cal = new Calculator();

        Console.WriteLine(cal.Sum(5, 10));

        Console.WriteLine(cal.Sum(5, 10, 15));
    }
}
*/

// properties:

/*
using System;

public class Student
{
    private string name;

    public string Name
    {
        get
        {
            return name;
        }

        set
        {
            name = value;
        }
    }
}

class Program
{
    static void Main()
    {
        Student student1 = new Student();

        student1.Name = "Naglaa";

        Console.WriteLine(student1.Name);
    }
}
*/


// struct:
/*

using System;

public struct Student
{
    public string Name;

    public void PrintInfo()
    {
        Console.WriteLine("Name: " + Name);
    }
}

class Program
{
    static void Main()
    {
        Student student1;
        Student student2;


        student1.Name = "Naglaa";
        student2.Name = "Sara";

        student1.PrintInfo();
        student2.PrintInfo();


        Console.ReadKey(false);
    }
}

*/ 



