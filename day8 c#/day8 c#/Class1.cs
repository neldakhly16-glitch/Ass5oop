using System;
using System.Collections.Generic;
using System.Text;

namespace day8_c_
{
    public partial class Customer
    {
        partial void BeforeSave();

        public void Save()
        {
            BeforeSave();

            Console.WriteLine("Customer Saved");
        }
    }
}
