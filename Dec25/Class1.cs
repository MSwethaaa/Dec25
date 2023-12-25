using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec25
{
    public class Class1
    {
        static void Non_GenericClassesFuns()
        {
            Stack s1 = new Stack();      s1.Push(1); s1.Push(2);
            s1.Push(3);                s1.Push(4);
            s1.Pop();// display the value remove by return object type
            object obj = s1.Peek();//return value(object) without remove
            if(obj.Equals(10))// if(obj==10) is wrong
            {
                s1.Pop();
            }
            Queue q1 = new Queue();  q1.Enqueue(1); 
            q1.Enqueue(2);   q1.Dequeue();       q1.Peek();
        }
        static void GenericClassesFuns2()
        {
            Queue<int>q1 = new Queue<int>();
            Stack<int>s1 = new Stack<int>();
        }
        static void Main(string[] args)
        {
            Non_GenericClassesFuns();
            GenericClassesFuns2();
        }
    }
}
