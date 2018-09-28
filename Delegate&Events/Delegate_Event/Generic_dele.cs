using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Event
{
    class Generic_dele
    {
       
        //public static double AddNums1(int x, int y, int z)
        //{
        //    return x + y+z;

        //}
        //public static void AddNums2(int x, int y, int z)
        //{
        //    Console.WriteLine( x + y + z);

        //}
        //public static bool CheckLength(string s)
        //{
        //    if (s.Length > 5)
        //        return true;
        //    return false;
        //}
        static void Main(string[] args)
        {
            Func<int, int, int, double> obj1 = (x, y, z) => x + y + z;
            Action<int, int, int> obj2 = (x, y, z) => { Console.WriteLine(x + y + z); };
            double result = obj1(100, 345, 2344);
            Console.WriteLine(result);
            Console.WriteLine("================");
            Console.WriteLine(obj1(11, 44, 654));

            Console.WriteLine("-------------------------");

            obj2(2321, 4123, 12312);
            Predicate<string> obj3 =s=> 
            {
                if (s.Length > 5)
                    return true;
                return false;
            };
            Console.WriteLine(obj3("Hello ank"));
            
            Console.ReadLine();

             
        }
    }
}
