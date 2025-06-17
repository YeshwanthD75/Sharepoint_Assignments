using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class External_candidate
    {
        // By default access specifier for this is private, Hence can accessed only in class
        private string vFirstname;//It is made public to access any where in the code
        private string vLastname;
        private string cCandidatecode;
        private int sitestscore;
        //Constructor , default constructor
        public External_candidate()
        {
            Console.WriteLine("Default constructor called");
            vFirstname = "Not Given";
            vLastname = "NOT given";
            cCandidatecode = "000000";
            sitestscore = 00000;
        }

        //constructor overloading, parameterized constructor
        public External_candidate(string fn, string ln, string cc, int st)
        {
            Console.WriteLine("Parameterized constructor");
            vFirstname = fn;
            vLastname = ln;
            cCandidatecode = cc;
            sitestscore = st;
        }
        //Distructor
        ~External_candidate()
        {
            Console.WriteLine("Distructor is called");
        }

        //Method
        public virtual void Accept()
        {
            Console.WriteLine("Accept called");

            Console.WriteLine("Please Enter Firstname");
            vFirstname = Console.ReadLine();

            Console.WriteLine("Please Enter Lastname");
            vLastname = Console.ReadLine();

            Console.WriteLine("Please Enter Candidatecode");
            cCandidatecode = Console.ReadLine();

            Console.WriteLine("Please Enter siTestscore");
            sitestscore = int.Parse(Console.ReadLine());
        }

        //Method overloading
        public void Accept(string fn, string ln, string cc, int st)
        {
            vFirstname = fn;
            vLastname = ln;
            cCandidatecode = cc;
            sitestscore = st;
        }
        public virtual void Display()
        {
            Console.WriteLine("Display called");

            Console.WriteLine("Candidatecode: {0} " + "Firstname: {1} Lastname: {2}" + "Testscore: {3}", cCandidatecode, vFirstname, vLastname, sitestscore);
        }
    }
}
