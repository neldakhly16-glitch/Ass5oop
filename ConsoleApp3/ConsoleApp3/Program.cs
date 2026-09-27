// intetfaces:
/*
using System;

public interface IStudent
{
    void PrintInfo();
}
// ( اي كلاس هيستخدم  ال Istudent لازم يكون فيه method  اسمها PrintInfo)
public class Student : IStudent
{
    public string Name;

    public void PrintInfo()
    {
        Console.WriteLine("Student Name: " + Name);
    }
}

class Program
{
    static void Main()
    {
        Student student1 = new Student();

        student1.Name = "Naglaa";

        student1.PrintInfo();
    }
}
*/
// Abstract class & Sealed class:
/*
using System;

public abstract class Person
{
    public string Name;

    public abstract void PrintInfo();

    public void Welcome()
    {
        Console.WriteLine("Welcome");
    }
}

public class Student : Person
{
    public override void PrintInfo()
    {
        Console.WriteLine("Student Name: " + Name);
    }
}

public sealed class University
{
    public string UniversityName;
}

class Program
{
    static void Main()
    {
        Student student1 = new Student();

        student1.Name = "Naglaa";

        student1.Welcome();

        student1.PrintInfo();

        Console.ReadKey(false);
    }
}
*/


// Delegates 
// مجموعة طلاب وهطبع اللي جايبين اعلى من 80
/*

using System;

public class Student
{
    public string Name;
    public int Grade;
}

class Program
{
    //دا هيشاور ع ميثود هتاخد student وهترجع (true / false)
    public delegate bool CheckStudent(Student student);

    public static void PrintStudents(Student[] students, CheckStudent check)
    {
        foreach (Student student in students)
        {
            // هشغل الميثود اللي delegat بيشاور عليها (IsPassed)
            if (check(student))
            {
                Console.WriteLine(student.Name + " Passed");
            }
        }
    }

    public static bool IsPassed(Student student)
    {
        if (student.Grade > 80)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static void Main()
    {
        Student[] students = new Student[3];

        students[0] = new Student() { Name = "Naglaa", Grade = 60 };
        students[1] = new Student() { Name = "Sara", Grade = 90 };
        students[2] = new Student() { Name = "Mariam", Grade = 85 };
        

        // دا (delegates c) بيشاور ع (IsPassed)
        CheckStudent c = new CheckStudent(IsPassed);

        PrintStudents(students, c);

        Console.ReadKey(false);
    }
}
*/
// 35 (Logic error)


// 36 Exception :

using System;
using System.IO;
class Program

{

    static void Main()
    {
        StreamReader streamReader = null;
        try
        {
            streamReader = new StreamReader(@"D:\TEMP\Test2\Welcome.txt");
            Console.WriteLine(streamReader.ReadToEnd());
        }
//  private exception:

        catch (FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine(".... ");
            Console.WriteLine(ex.FileName);
            Console.WriteLine("...... ");
            Console.WriteLine(ex.StackTrace);

        }
// private exception:
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("--------");
            Console.WriteLine(ex.StackTrace);

        }
// public exception:

        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("-");
            Console.WriteLine(ex.StackTrace);
        }
        finally
        {
            if (streamReader != null)
                streamReader.Close();
        }
        Console.WriteLine("New Task");
        Console.ReadKey(true);
    }
}


