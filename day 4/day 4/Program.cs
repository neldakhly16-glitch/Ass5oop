// 21   (Inheritanse)
/*
using System;



public class Employee

{

    public string FirstName;

    public string LastName;

    public string Address;

    public void PrintEmpInfo()

    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}
    public class FullTimeEmployee : Employee
    {
      public float theSalary;
    }

    public class PartTimeEmployee : Employee
    {
        float thePartSalary;
    }



    class Program
    {
        static void Main()
        {
            FullTimeEmployee emp1 = new FullTimeEmployee();
            emp1.FirstName = "ahmed";
            emp1.LastName = "mohamady";
            emp1.Address = "asdasdasda";
            emp1.theSalary = 100.0F;
            emp1.PrintEmpInfo();
            Console.ReadKey(false);
        }
    }
*/



// تطبيق ع (inhetitance)


/*using System;


public class Person
{
    public string Name;
    public int Age;

    public void PrintInfo()
    {
        Console.WriteLine(Name + " " + Age);
    }
}

public class Student : Person
{
    public int Level;
}

public class Teacher : Person
{
    public string Subject;
}

class Program
{
    static void Main()
    {
        Student student1 = new Student();

        student1.Name = "Naglaa";
        student1.Age = 22;
        student1.Level = 4;

        student1.PrintInfo();

        Console.ReadKey(false);
    }
}


*/






// vedio 22 (hiding & shadwing)
/*

using System;

public class Employee

{
    public string FirstName;

    public string LastName;

    public string Address;

    public void PrintEmpInfo()

    {

        Console.WriteLine(FirstName + " " + LastName);
    }
}

public class FullTimeEmployee : Employee
{

}

public class PartTimeEmployee : Employee
{
    public new void PrintEmpInfo()
    {
        base.PrintEmpInfo();
        Console.WriteLine("The Emp From Part Time");
    }
}
class Program
{
    static void Main()
    {
        PartTimeEmployee PREP = new PartTimeEmployee();
        PREP.FirstName = "Ahmed";
        PREP.LastName = "Mohamady";
        PREP.PrintEmpInfo();
        Console.WriteLine("===============================");
        ((Employee)PREP).PrintEmpInfo();

        Console.ReadKey(false);
    }
}
*/





//vedio 23 (polymorphism)

/*
using System;

public class Employee
{
    public string FirstName  = "naglaa";
    public string LastName =  "fathi";
    public string Address;
    public virtual void PrintEmpInfo()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}
public class FulltimeEmployee : Employee
{
    public override void PrintEmpInfo()
    {
        Console.WriteLine(" (0) (1) The Emp From Full Time", base.FirstName, base.LastName);
    }
}

public class PartTimeEmployee : Employee
{
    public override void PrintEmpInfo()
    {
        Console.WriteLine(" (0) (1) The Emp From Part Time", base.FirstName, base.LastName);
    }
}

public class TempEmployee : Employee
{
    public override void PrintEmpInfo()
    {
        Console.WriteLine(" (0) (1) The Emp From Temp", base.FirstName, base.LastName);
    }
}

class Program
{
    static void Main()
    {
        Employee[] employees = new Employee[4];
        employees[0] = new Employee();
        employees[1] = new FulltimeEmployee();
        employees[2] = new PartTimeEmployee();
        employees[3] = new TempEmployee();
            foreach (Employee e in employees)
            {
              e.PrintEmpInfo();
            
            }

    }
}
*/

