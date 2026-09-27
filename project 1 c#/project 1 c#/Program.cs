//Student Management system
//فكرة المشروع
//برنامج يساعد الجامعة في إدارة بيانات الطلاب،    


using System;
using System.Collections.Generic;

namespace StudentManagement
{ 
    enum Department
    {
        ComputerScience,
        InformationTechnology,
        InformationSystems
    }
    interface IStudent
    {
        void DisplayInfo();
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("This is a person.");
        }
    }
    class Student : Person, IStudent
    {
        public int ID { get; set; }
        public Department Department { get; set; }

        private double gpa;
        public double GPA  // encapsulation
        {
            get
            {
                return gpa;
            }

            set
            {
                if (value >= 0 && value <= 4)
                {
                    gpa = value;
                }
                else
                {
                    Console.WriteLine("GPA must be between 0 and 4.");
                }
            }
        }
        // كل طالب عنده اكتر من كورس ف طبيعي استخد ال ليست
        public List<string> Courses { get; set; }

        // Constructor
        public Student(
            int id,
            string name,
            int age,
            Department department,
            double gpa)
            : base(name, age)
        {
            ID = id;
            Department = department;
            GPA = gpa;
            // ليست جديده وفاضيه
            Courses = new List<string>();
        }
        // عملت ميثود عشان اضيف اي كورس 
        // student1.Addcourse (" name course")
        public void AddCourse(string course)
        {
            Courses.Add(course);
            Console.WriteLine("Course added success.");
        }

        // هنا عملت ميثود بنفس الاسم لكن عدد البراميترز مختلفه ودا 
        // method overloading
        public void AddCourse(string course1, string course2)
        {
            Courses.Add(course1);
            Courses.Add(course2);

            Console.WriteLine("Two courses added success.");
        }

        // غيرت طريقة تنقيذ الميثود الموروثه عشان ال كلاس بتاع (student)
        // كحتاج يعرض id,name,age,gpa,....
        public override void DisplayInfo()
        {
            Console.WriteLine("\n===== Student Information =====");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Department: {Department}");
            Console.WriteLine($"GPA: {GPA}");

            Console.WriteLine("Courses:");
            // عشان تلف ع كل اللي موجود جوا الكورس
            foreach (string course in Courses)
            {
                Console.WriteLine($"- {course}");
            }
        }
        // دي بقا ميثود هترجع (string )
        // excellent.good.fail,....

        public string GetGrade()
        {
            if (GPA >= 3.5)
                return "Excellent";

            else if (GPA >= 3)
                return "Very Good";

            else if (GPA >= 2.5)
                return "Good";

            else if (GPA >= 2)
                return "Pass";

            else
                return "Fail";
        }
    }

    class Program
    {
        // 
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            // Create Students
            Student student1 = new Student(
                1,
                "Naglaa",
                21,
                Department.ComputerScience,
                3.5
            );

            Student student2 = new Student(
                2,
                "Rawan",
                21,
                Department.InformationTechnology,
                3.2
            );
            student1.AddCourse("C#");
            student1.AddCourse("Database", "Software Engineering");

            student2.AddCourse("C++");
            student2.AddCourse("Database");

  
            students.Add(student1);
            students.Add(student2);

           
            Console.WriteLine("===== ALL STUDENTS =====");

            foreach (Student student in students)
            {
                student.DisplayInfo();

                Console.WriteLine($"Grade: {student.GetGrade()}");
                Console.WriteLine();
            }

            // Search
            Console.WriteLine("===== SEARCH =====");

            Console.Write("Enter Student ID: ");
            int searchID = Convert.ToInt32(Console.ReadLine());

            bool found = false;

            foreach (Student student in students)
            {
                if (student.ID == searchID)
                {
                    Console.WriteLine("\nStudent Found!");

                    student.DisplayInfo();

                    Console.WriteLine(
                        $"Grade: {student.GetGrade()}"
                    );

                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Student not found.");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}



