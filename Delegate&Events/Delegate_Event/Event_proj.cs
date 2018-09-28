using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Event
{
    public delegate void LinkToEventHandler1(int i);

    class MaleStudent
    {
        string name;
        int Marks;

        public MaleStudent(string nameArg, int marks)
        {
            name = nameArg;
            Marks = marks;
        }
        public void MyActionItem(int i)
        {
            if (i == 1)
               Console.WriteLine("{0} Got Admission. He must pay fees", name);
            else
                Console.WriteLine(
                  "{0} did not Get Admission. He must lookout for other college", name);
        }
        public int GetMarks()
        {
            return Marks;
        }
    }

    
    class Event_proj
    {
        public static event LinkToEventHandler1 AdmissionDeniedEvt;
        public static event LinkToEventHandler1 AdmissionGrantedEvt;

        public static void Main()
        {
            Console.WriteLine("Enter how many student details u want to enter ");
            int no = Convert.ToInt32(Console.ReadLine());
            MaleStudent[] obj = new MaleStudent[no];
            for (int i = 0; i < obj.Length; i++)
            {
         
                
                    Console.WriteLine("Enter name ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter marks ");
                    int m = Convert.ToInt32(Console.ReadLine());
                    obj[i] = new MaleStudent(name, m);

               

            }
            foreach (MaleStudent m in obj)
            {

                
                if (m.GetMarks() >= 90)
                    AdmissionGrantedEvt += new LinkToEventHandler1(m.MyActionItem);
                else
                    AdmissionDeniedEvt += new LinkToEventHandler1(m.MyActionItem);
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
