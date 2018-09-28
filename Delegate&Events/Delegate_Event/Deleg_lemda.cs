using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Event
{
    public delegate string delegateMsg(string s);   
    class Deleg_lemda
    {   
        static void Main(string[] args)
        {
            delegateMsg msg= (s)=>"Hello " + s + " welcome";
            Console.WriteLine(msg("an"));
            Console.ReadLine();
        }
    }
}
