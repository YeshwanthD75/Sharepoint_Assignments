using Inheritance;
using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Example of using Autoproperties
            ////ContractRecruiter obj = new ContractRecruiter();
            ////obj.CName = "Test";
            ////obj.vAdress = "Newtown";
            ////Console.WriteLine(obj.CName);
            ////Console.WriteLine(obj.vAdress);

            ////Inheritance of Employee from Externalcandidate
            ////Employee eobj = new Employee();
            ////eobj.Accept();
            ////eobj.Display();

            //// External_candidate extobj = new External_candidate();
            ////extobj.Accept();
            ////extobj.Display();

            ////Inheritance of Employee from Externalcandidate
            //Console.WriteLine("Please select which object you want to create Employee 2 and ExternalCandidate 1");
            //int ans = int.Parse(Console.ReadLine());
            //External_candidate obj;
            //if (ans == 1)
            //{
            //    obj = new External_candidate();
            //}
            //else
            //{
            //    obj = new Employee();
            //}
            //obj.Accept();
            //obj.Display();

            MyClass obj = new MyClass();
            obj.Accept();
            obj.Display();
            obj.IamnotAbstract();

        }
    }
}