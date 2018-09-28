using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Event
{
    class Multicast_delegate
    {
        public delegate void Print(int value);

        static void Main(string[] args)
        {
            Print printDel = PrintNumber;
            printDel += PrintHexadecimal;
            printDel += PrintMoney;

            printDel(100000);
            Console.WriteLine("================================");
            printDel -= PrintNumber;
            printDel(330022);
            printDel +=  PrintNumber ;
            printDel += PrintMoney;
            printDel += PrintHexadecimal;
            printDel -= PrintMoney;
            Console.WriteLine("==================================");
            printDel(221);
            Console.ReadLine();

        }
        public static void PrintNumber(int num)
        {
            Console.WriteLine("Number: {0,-12:N0}", num);
        }

        public static void PrintMoney(int money)
        {
            Console.WriteLine("Money: {0:C}", money);
        }

        public static void PrintHexadecimal(int dec)
        {
            Console.WriteLine("Hexadecimal: {0:X}", dec);
        }
    }
}
