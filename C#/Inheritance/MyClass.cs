using System;

namespace Inheritance
{
    internal class MyClass : External_candidate, ISuper
    {
        public void Accept()
        {
            Console.WriteLine("I am accept of myclass");
        }

        public void Display()
        {
            Console.WriteLine("I am Display of myclass");
        }

        public void IamnotAbstract()
        {
            Console.WriteLine("Implemented from interface ISuper");
        }
    }
}
