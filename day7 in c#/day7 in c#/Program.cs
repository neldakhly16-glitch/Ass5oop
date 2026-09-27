//Atteibute:
// برنامج بيحسب السعر قبل الخصم 
/*
using System;

class PriceCalculator
{
    [Obsolete]
    public double CalculatePrice(double price)
    {
        return price;
    }

    public double CalculatePriceWithDiscount(double price, double discount)
    {
        return price - (price * discount / 100);
    }
}

class Program
{
    static void Main()
    {
        PriceCalculator calculator = new PriceCalculator();

        double oldPrice = calculator.CalculatePrice(100);

        double newPrice = calculator.CalculatePriceWithDiscount(100, 20);

        Console.WriteLine("Old Price: " + oldPrice);
        Console.WriteLine("New Price: " + newPrice);
    }
}

*/

//using objects in c#
// لما نطبع ال product هيظهر اسمه وسعره 
// نقدر نعرف هل المنتجين يعتبروا نفس المنتج ولا لا

/*
using System;

class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }

    // ToString()
    public override string ToString()
    {
// $ (strig Interpolation)   / بتخلينا نحط ال variables  جوا string كدا

        return $"{Id} - {Name} - {Price} EGP";
    }

    // Equals()
    public override bool Equals(object obj)
    {
        if (obj == null)
            return false;

        if (!(obj is Product))
            return false;
// casting:
        Product p = (Product)obj;

        return this.Id == p.Id;
    }
}

class Program
{
    static void Main()
    {
        Product p1 = new Product();

        p1.Id = 101;
        p1.Name = "Laptop";
        p1.Price = 30000;

        Product p2 = new Product();

        p2.Id = 101;
        p2.Name = "Laptop";
        p2.Price = 32000;

        // ToString
        Console.WriteLine(p1.ToString());

        Console.WriteLine("----------------");

        // Equals
        Console.WriteLine(p1.Equals(p2));

        Console.ReadKey();
    }
}



*/
//string builder:
/*

using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder report = new StringBuilder();

        report.Append("Student Report\n");
        report.Append("----------------\n");

        report.Append("Name: ");
        report.Append("Ahmed\n");

        report.Append("Age: ");
        report.Append(20);
        report.Append("\n");

        report.Append("Grade: ");
        report.Append(90);
        report.Append("\n");

        report.Append("Status: Passed");

        Console.WriteLine(report);

        Console.ReadKey();
    }
}*/

// Generics 
// بدل م نعمل (Intprinter/ Stringprinter / Studentprinter)
//عملنا كلاس واحد (printer T)



using System;

class Printer<T>
{
    public T Value { get; set; }

    public void Print()
    {
        Console.WriteLine(Value);
    }
}

class Student
{
    public string Name { get; set; }
}

class Program
{
    static void Main()
    {
        // مع int
        Printer<int> numberPrinter = new Printer<int>();

        numberPrinter.Value = 100;

        numberPrinter.Print();


        // مع string
        Printer<string> textPrinter = new Printer<string>();

        textPrinter.Value = "Hello C#";

        textPrinter.Print();


        // مع Student
        Printer<Student> studentPrinter = new Printer<Student>();

        studentPrinter.Value = new Student();

        studentPrinter.Value.Name = "Ahmed";

        Console.WriteLine(studentPrinter.Value.Name);

        Console.ReadKey();
    }
}



