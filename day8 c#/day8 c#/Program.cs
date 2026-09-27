
/*
namespace day8_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();

            customer.Save();
        }
    }
}

*/


/*
//Indexers:
// عندنا مدرسة فيها مجموعة طلاب لما اكتب الرقم يطلعلي اسم الطالب
using System;
//عشان نقدر نستخدم ال List<student>
using System.Collections.Generic;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class School
{
    // دي معناها انو عندي List
    // اسمها student
    // هتخزن object
    // من نوع student
    private List<Student> students;

    public School()
    {
        students = new List<Student>();

        students.Add(new Student { Id = 1, Name = "Ahmed" });
        students.Add(new Student { Id = 2, Name = "Sara" });
        students.Add(new Student { Id = 3, Name = "Ali" });
    }
    // اهم جزء فال indexer
    // معناها لما حد يستخدم school مع []
    // ويديني رقم ف انا هستخدم الرقم دا عشان ادور ع الطالب
    public string this[int id]
    {
        get
        {
            // foreach عشان نلف ع كل الطلاب اللي في الليست
            foreach (Student student in students)
            {
                if (student.Id == id)
                {
                    return student.Name;
                }
            }

            return "Student not found";
        }
    }
}

class Program
{
    static void Main()
    {
        School school = new School();

        Console.WriteLine(school[1]);
        Console.WriteLine(school[2]);
        Console.WriteLine(school[5]);
    }
}

*/







// Overloading (indexer)
using System;
using System.Collections.Generic;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class School
{
    private List<Student> students = new List<Student>();

    public School()
    {
        students.Add(new Student { Id = 1, Name = "Ahmed" });
        students.Add(new Student { Id = 2, Name = "Sara" });
        students.Add(new Student { Id = 3, Name = "Ali" });
    }

    // Indexer 1 → باستخدام int (id)
    public string this[int id]
    {
        get
        {
            foreach (Student student in students)
            {
                if (student.Id == id)
                    return student.Name;
            }

            return "Student not found";
        }
    }

    // Indexer 2 → باستخدام string (name)
    public string this[string name]
    {
        get
        {
            foreach (Student student in students)
            {
                if (student.Name == name)
                    return student.Id.ToString();
            }

            return "Student not found";
        }
    }
}

class Program
{
    static void Main()
    {
        School school = new School();

        Console.WriteLine(school[2]);

        Console.WriteLine(school["Sara"]);
    }
}





