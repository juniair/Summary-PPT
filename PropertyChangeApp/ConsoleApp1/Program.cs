using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static string _name;
        public static string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
                TraceMessage(_name);
            }
        }

        static void Main(string[] args)
        {
            DoProcessing();
            Name = "Something Message";
        }

        public static void DoProcessing()
        {
            TraceMessage("Something happened.");
        }

        public static void TraceMessage(string message, 
            [CallerMemberName] string methodName = null)
        {
            Console.WriteLine("Message : " + message);
            Console.WriteLine("Invoked Method : " + methodName);
        }
       
    }


}
