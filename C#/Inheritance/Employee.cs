using Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Employee : External_candidate
    {
        string Employeecode;

        public override void Accept()
        {
            Console.WriteLine("This is Employee Accept");
            base.Accept(); //4 properties
            Console.WriteLine("Enter Employeecode");
            Employeecode = Console.ReadLine();
        }
        public override void Display()
        {
            Console.WriteLine("This is Employee Display");
            base.Display();
            Console.WriteLine("Employee:- {0}", Employeecode);
        }
    }
}