using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Event
{
    class Delegate_ann
    {
        public delegate string GreetingDel(string n);
        //public static string Greeting(string name)
        //{
        //    return "Hello " + name + " Welcome ";
            
        //}
        static void Main(string[] args)
        {

            GreetingDel d = delegate (string n) { return "Hello " + n + " Welcome "; };
            Console.WriteLine(d("ank"));
            Console.ReadLine();
        }

    }
}
