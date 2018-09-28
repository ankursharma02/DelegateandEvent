using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Event
{
    class Delegate_para
    {
        public delegate void Print(int value,int n);


        static void Main(string[] args)
        {
            PrintHelper(PrintNumber, 10000,22);
            PrintHelper(PrintMoney, 20000,33);
            Console.ReadLine();
        }

        public static void PrintHelper(Print delegateFunc, int numToPrint,int n)
        {
            delegateFunc(numToPrint,n);
        }

        public static void PrintNumber(int num,int n)
        {
            Console.WriteLine("Number: {0,-12:N0}", num+"  n= "+n);
        }

        public static void PrintMoney(int money,int n)
        {
            Console.WriteLine("Money: {0:C}", money+" n= "+n);
        }
    }
}
