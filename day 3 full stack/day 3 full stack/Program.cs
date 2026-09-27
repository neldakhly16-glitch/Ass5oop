// انواع ال prsmeters in c#
// vedio 17 
// value

/*using System;

class Program

{

    static void Main()

    {

        int i = 0;

        method(i);

        Console.WriteLine(i);

        Console.ReadKey(true);

    }

    public static void method(int j)

    {

        j = 200;

    }
}    // run = 0 */


// ref
//




/*using System;

class Program

{

    static void Main()

    {

        int i = 0;

        method(ref i);

        Console.WriteLine(i);

        Console.ReadKey(true);

    }
public static void method(ref int j)

    {
        j = 200;
    }
} //run = 200 */


// out 




/*using System;

class Program
{
    static void Main()
    {

        int i = 0;


        int div = 0;

        int mult = 0;

        calculate(20, 10, out div, out mult);

        Console.WriteLine(div);

        Console.WriteLine(mult);


        Console.ReadKey(true);
    }
    public static int calculate(int num1, int num2, out int div, out int mult)
    {

        div = num1 / num2;

        mult = num1 * num2;

        return num1 + num2;

    }
}   // Run = 2  div, 200 mult */















// vedio 18
// namespaces
//using System;
//using PATA = ProjectA.TeamA;
//using PATB = ProjectA.TeamB;



//class Program

//{

//    static void Main()

//    {

//        ProjectA.TeamA.ClassA.Print();
//        ProjectA.TeamB.ClassA.Print();


//        Console.ReadKey(true);

//    }
//}

//namespace ProjectA

//{

//    namespace TeamA

//    {

//        class ClassA

//        {

//            public static void Print()

//            {

//                Console.WriteLine("Hello Class A");

//            }
//        }
//    }
//}

//namespace ProjectA

//{

//    namespace TeamB

//    {

//        class ClassA

//        {

//            public static void Print()

//            {

//                Console.WriteLine("Hello Class B");

//            }
//        }
//    }
//}


// vedio 19 
// classes
/*
using System;

class Program
{
    static void Main()

    {

        Animal dog = new Animal("black", 1, "german");

        dog.PrintFullInfo();

        dog.Run();

        Console.ReadKey(true);
    }
}
    class Animal
    {
        string _color;
        int _length;
        string _name;

        public Animal(string color, int len , string name)
        {
            _color = color;
            _length = len;
            _name = name;
        }

        public void PrintFullInfo()
        {
            Console.WriteLine(" color {0}, len {1}, name {2}", _color, _length, _name);
        }

        public void Run()
        {
          Console.WriteLine(" the {0} is running", _name);
        }
        ~Animal()
        {
            //Clean The Code
            _color = null;
            _name = null;
        }
    }


*/




































































//  1-Student Grade System
/*
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your grade: ");
        int grade = Convert.ToInt32(Console.ReadLine());

        if (grade >= 90)
        {
            Console.WriteLine(name + " Grade : A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine(name + " Grade : B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine(name + " Grade : C");
        }
        else if (grade >= 60)
        {
            Console.WriteLine(name + " Grade : D");
        }
        else
        {
            Console.WriteLine(name + " Grade : F");
        }
    }
}  

*/




//2- Simple Menu Program
/*
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("1. Pizza");
        Console.WriteLine("2. Burger");
        Console.WriteLine("3. Pasta");
        Console.WriteLine("4. Juice");

        Console.Write("Choose your order: ");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("You ordered Pizza.");
                break;

            case 2:
                Console.WriteLine("You ordered Burger.");
                break;

            case 3:
                Console.WriteLine("You ordered Pasta.");
                break;

            case 4:
                Console.WriteLine("You ordered Juice.");
                break;

            default:
                Console.WriteLine("Invalid Choice.");
                break;
        }
    } 
    
}

*/

// Array Manager
/*
using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[5];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Enter Number : ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Numbers:");

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}
*/




// ex: void هنا مش بيرجع قيمه ف هنا ال
// Method مش هترجع قيمه هتنفذ اوامر بس زي الطباعه 
/*using System;

class Program
{
    static void Main()
    {
        Program.printMessage();

        Console.ReadKey(true);
    }

    public static void printMessage()
    {
        Console.WriteLine("Welcome To C#");
    }
}


*/










// لو عايزة ارجع قيمه هستخدم int 

/*
 using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(Program.maxNumber(20,25));

        Console.ReadKey(true);
    }

    public static int maxNumber(int num1, int num2)
    {
        if (num1 > num2)
        {
            return num1;
        }
        else
        {
            return num2;
        }
    }
}*/






/*
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(Program.multiplyNumbers(5, 4));

        Console.ReadKey(true);
    }

    public static int multiplyNumbers(int num1, int num2)
    {
        int result = num1 * num2;

        return result;
    }
}

*/











/*
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter First Number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Second Number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(Program.divideNumbers(num1, num2));

        Console.ReadKey(true);
    }

    public static int divideNumbers(int num1, int num2)
    {
        int result = num1 / num2;

        return result;
    }
}
*/




// تطبيث ع namespaces
/*
using System;

class Program
{
    static void Main()
    {
        School.ClassOne.Student.Print();
        School.ClassTwo.Student.Print();

        Console.ReadKey(true);
    }
}

namespace School
{
    namespace ClassOne
    {
        class Student
        {
            public static void Print()
            {
                Console.WriteLine("Welcome To Class One");
            }
        }
    }
}

namespace School
{
    namespace ClassTwo
    {
        class Student
        {
            public static void Print()
            {
                Console.WriteLine("Welcome To Class Two");
            }
        }
    }
}
*/

// تطبيق ع classes

using System;

class Program
{
    static void Main()
    {
        Car myCar = new Car("BMW", "Blue", 2024);

        myCar.PrintInfo();

        myCar.Drive();

        Console.ReadKey(true);
    }
}

class Car
{
    string _brand;
    string _color;
    int _year;

    public Car(string brand, string color, int year)
    {
        _brand = brand;
        _color = color;
        _year = year;
    }

    public void PrintInfo()
    {
        Console.WriteLine("Brand : {0}, Color : {1}, Year : {2}", _brand, _color, _year);
    }

    public void Drive()
    {
        Console.WriteLine("{0} is driving.", _brand);
    }

    ~Car()
    {
        _brand = null;
        _color = null;
    }
}
