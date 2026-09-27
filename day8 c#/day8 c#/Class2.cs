using System;
using System.Collections.Generic;
using System.Text;

namespace day8_c_
{
    public partial class Customer
    {
        partial void BeforeSave()
        {
            Console.WriteLine("Checking Customer...");
        }
    }
}
