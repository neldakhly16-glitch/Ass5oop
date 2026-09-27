/*using System;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
class program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!"); Console.WriteLine("naglaa");
        // التحويل

        /* int i = 100;
         float f = i;
         Console.WriteLine(i) //or (f)  = 100*/

//float f = 154.55f;
// int i = f;   ,  غلط حاجه كبيرة جوا حاجه صغيره
// int i = (int)f;  الحل
// int i = Convert.ToInt32(f); // هيعدله ويقربله لاقرب رقم صحيح


/* float f = 154765432435678908765.55f;
 int i = Convert.ToInt32(f); //  الرقم كبير اوييييي ف هيتغير خالص


 Console.WriteLine(f);*/


/* float f = 154765432435678908765.55f;
 string str = 100;
 int i = int.Parse(str);
 Console.WriteLine(i); // هيحول ع طووول */



/* float f = 154765432435678908765.55f;
 string str = 100v;
 int result =0;
 bool isTrue =int.TryParse(str, out result);
 int i = result;
 Console.WriteLine(i);*/















/* Console.WriteLine("plz enter your First Name");
 string theName = Console.ReadLine();
 Console.WriteLine("plz enter your Last Name");
 string lastName = Console.ReadLine();



 Console.WriteLine("Welcome Back" +" " theName + " " +lastName);

 Console.WriteLine("Your Account is Active Mr.{0}", theName + " " + lastName); //another way


 string stringVar = "Hello, World!";
 int intVar = 100;
 float floatVar = 10.2f;
 Char CharVar = 'N';
 bool boolVar = false;
*/
/*Console.WriteLine("Max int Value {0}", int.MaxValue);

Console.WriteLine("Min int Value {0}", int.MinValue);

double d = 2147483647;
Console.WriteLine("The double num is{0}", d); */

// Commen Operator in C#
// = , / ,+ , _ , * ,% , == , != , || , && , ? ,> ,<  , >= ,<=


/*string str "Omar";
int x = 100;
bool b = true;
X = 20;
int num1 = 2  ; int num2 = 4;*/



/*int result = num1 + num2;
bool isTrue =(num1 == num2);
Console.WriteLine("res =" + isTrue);*/


/*int result = num1 % num2;
bool isTrue = (num1 == num2);
Console.WriteLine("res =" + isTrue);*/

// int num1 = 2; int num2 = 4; int num3 = 4;


/*int result = num1 % num2;

bool isTrue = (num1 == num2) || (num1 == num3);
Console.WriteLine("res =" + isTrue);*/

/*int result = num1 % num2;
bool isTrue = (num1 == num2) && (num1 == num3);
onsole.WriteLine("res =" + isTrue); */


/* bool isNumber10 = num1 == 10 ? true : false;
 Console.WriteLine("res =" + isNumber10); */

/*bool isNumber10 = num1 > 10 ? true : false;
Console.WriteLine("res =" + isNumber10); */


/*bool isNumber10 = num1 <= 10 ? true : false;
Console.WriteLine("res =" + isNumber10); */



// Null 

/*  string str null; //refrrn  ok


  int? x = null; // لازم علامة استفهام عشان دا فاليو

  bool? isAhmed = null;
  Console.WriteLine("Are you Ahmed : (y , n) ");
  string result = Console.ReadLine();
  isAhmed = result == "y" ? true : false;
  Console.WriteLine("is Ahmed:{0}", is Ahmed);*/

// مثال if ب null ?????????????




//}
//}































// task 1 in full stack corse

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("plz enter yuor Name");
        string theName = Console.ReadLine();
        Console.WriteLine("Welcome Back in programming "+" "+theName);

        Console.WriteLine("plz Choose Operator (+ , - , * , / , %)");

        string op = Console.ReadLine();
        char operation = Convert.ToChar(op);

        Console.WriteLine("Enter First Num");
        string firstNumber = Console.ReadLine();
        int num1 = Convert.ToInt32(firstNumber);

        Console.WriteLine("Enter Last Num");
        string lastNumber = Console.ReadLine();
        int num2 = Convert.ToInt32(lastNumber);

        if (operation == '+')
        {
            Console.WriteLine("Result = " + (num1 + num2));
        }
        else if (operation == '-')
        {
            Console.WriteLine("Result = " + (num1 - num2));
        }
        else if (operation == '*')
        {
            Console.WriteLine("Result = " + (num1 * num2));
        }
        else if (operation == '/')
        {
            Console.WriteLine("Result = " + (num1 / num2));
        }
        else if (operation == '%')
        {
            Console.WriteLine("Result = " + (num1 % num2));
        }
        else
        {
            Console.WriteLine("Invalid Operator");
        }
    }
}

