using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public abstract class Super
    {
        public abstract void Accept();
        public abstract void Display();

        public void IamnotAbstract()
        {
            Console.WriteLine("HI I have defination ");
        }

    }

    public interface ISuper
    {
        void Accept(); //declaration
        void Display(); //declaration

        void IamnotAbstract(); //declaration
    }
    
}
