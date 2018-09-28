using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Event
{
    public delegate void addDelegate(int a,int b);
    public delegate  string sayHelloDelegate(string s);
    class Delegate_demo
    {
        public void AddNums(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        public static string SayHello(string name)
        {
            return "Hello " + name;
        }
        static void Main(string[] args)
        {
            Delegate_demo d = new Delegate_demo();
            addDelegate ad = new addDelegate(d.AddNums);
            sayHelloDelegate sd = new sayHelloDelegate(SayHello);
            ad(14,15);
            string s1 = sd("ank");
            Console.WriteLine(s1);
            ad.Invoke(2,3);
            s1 = sd.Invoke("dsdf");
            d.AddNums(100, 50);
            Console.WriteLine(s1);
            Console.WriteLine(SayHello("Ankur"));
            Console.ReadLine();

                
        }
    }
}
