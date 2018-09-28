using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Event
{
    class Anno_Delegate
    {
        delegate void Printer(string s);

        class TestClass
        {
            static void Main()
            {
                
                Printer p = delegate (string j)
                {
                    System.Console.WriteLine(j);
                };

                
                p("The delegate using the anonymous method is called.");

                
                p = DoWork;

               
               
                p("The delegate using the named method is called.");
                Console.ReadLine();
            }

            static void DoWork(string k)
            {
                System.Console.WriteLine(k);
            }
        }

    }
}
