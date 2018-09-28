using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Event
{
    public delegate void LinkToEventHandler3(int i);

    interface Student_details
    {
        void Read();
        int GetMarks();
        void MyActionItem(int i);
    }
    public class MaleStudent1 : Student_details
    {
        string name;
        int marks;
        void Student_details.Read()
        {
            Console.WriteLine("Enter student name ");
            name = Console.ReadLine();
            Console.WriteLine("Enter marks ");
            marks = Convert.ToInt32(Console.ReadLine());
        }
        int Student_details.GetMarks()
        {
            return marks;
        }
        void Student_details.MyActionItem(int i) 
        {
            if (i == 1)
                System.Console.WriteLine("{0} Got Admission. He must pay fees", name);
            else
                System.Console.WriteLine(
                  "{0} did not Get Admission. He must lookout for other college", name);
        }


        public class FeMaleStudent1 : Student_details
        {
            string name;
            int marks;
            void Student_details.Read()
            {
                Console.WriteLine("Enter student name ");
                name = Console.ReadLine();
                Console.WriteLine("Enter marks ");
                marks = Convert.ToInt32(Console.ReadLine());

            }
            int Student_details.GetMarks()
            {
                return marks;
            }
            void Student_details.MyActionItem(int i)
            {
                if (i == 1)
                    System.Console.WriteLine("{0} Got Admission. He must pay fees", name);
                else
                    System.Console.WriteLine(
                      "{0} did not Get Admission. He must lookout for other college", name);
            }




        }
        class Student_manage
        {
            public static event LinkToEventHandler3 AdmissionDeniedEvt;
            public static event LinkToEventHandler3 AdmissionGrantedEvt;

            public static void Main(string[] args)
            {
                int n;
                Console.WriteLine("Enter  student number ");
                n = Convert.ToInt32(Console.ReadLine());
                Student_details[] sd = new Student_details[n];
                for (int i = 0; i < sd.Length; i++)
                {
                    lable1:
                    Console.WriteLine("Enter male or female m/f");
                    char ch = Convert.ToChar(Console.ReadLine());
                    if (ch.Equals('m') || ch.Equals('M'))
                    {
                        sd[i] = new MaleStudent1();
                        sd[i].Read();
                    }
                    else if (ch.Equals('f') || ch.Equals('F'))
                    {
                        sd[i] = new FeMaleStudent1();
                        sd[i].Read();
                    }
                    else
                    {
                        Console.WriteLine("Wrong input enter m of f");
                        goto lable1;
                    }
                }

                foreach (Student_details s in sd)
                {
                  if(s.GetMarks() >= 90)
                  AdmissionGrantedEvt += new LinkToEventHandler3(s.MyActionItem);
                    else
                  AdmissionDeniedEvt += new LinkToEventHandler3(s.MyActionItem);
                }
                    SendEvent();
                Console.ReadLine();

            }
            public static void SendEvent()
            {
                if (AdmissionGrantedEvt != null)
                {
                    AdmissionGrantedEvt(1);
                }

                if (AdmissionDeniedEvt != null)
                {
                    AdmissionDeniedEvt(0);
                }
            }
        }
    }
}
