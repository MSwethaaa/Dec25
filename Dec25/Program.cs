using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec25
{
    internal class Program
    {
        static void Fun()
        {//void method means no return keyword never return a value

        }
        public string Display()
        {//but last statement to be return along with some type
            return "hello";
        }
        public Program()//no parameter constructor
        {
        }
        static void Main(string[] args)
        {
            Fun();//static member requires no instance of class
            Program p = new Program();//will call line 18
            string s = p.Display();//non static display() need to instance of class
        }
    }
}
