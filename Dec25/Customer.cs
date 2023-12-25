using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec25
{
    internal class Customer
    {//intstance
        int cId;
        string cName;
        public Customer() { Console.WriteLine("current C is called before line 14"); }
        public Customer(int id): this()   {this.cId = id;  }
        static Customer() { Console.WriteLine("always before Main()");
        Console.WriteLine("we once in life time values in SC ");
    }
        public void Display() { this.cId = 10;
        this.cName = "harry"; Console.WriteLine("customer Display()");
    }
    static void Main(string[] args)//line 15
    {//only line 15
        // Customer c = new Customer();  //line 13
        Customer cc = new Customer(10);  //line 13,14
        cc.Display();//explicit

    }
   }
}
