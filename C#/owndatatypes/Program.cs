using System.ComponentModel.DataAnnotations;
using System.Data;

class Externalcandidate
{   //default access specifier for class is private
    public string vfirstname;
    string vlastname;
    string ccandidatecode;
    //byte sitestscore;

    public Externalcandidate()
    {
        Console.WriteLine("default constructor called");
        vfirstname = "NotGiven";
        vlastname = "NotGiven";
        ccandidatecode = "NotGiven";
    }

    //overloading constructor

    public Externalcandidate(string fn, string ln, string code)
    {
        Console.WriteLine("Param constructor called");
        this.vfirstname = fn;
        this.vlastname = ln;
        this.ccandidatecode = code;
    }

    ~Externalcandidate()
    {
        //Console.WriteLine("Destructor Called called");
    }

    //Function Overload
    public void Accept()
    {
        Console.WriteLine("[Accept called]*");
        Console.WriteLine("Please Enter the Firstname");
        vfirstname = Console.ReadLine();
        Console.WriteLine("Please Enter the Lastname");
        vlastname = Console.ReadLine();
        Console.WriteLine("Please Enter the Candidatecode");
        ccandidatecode = Console.ReadLine();
        //sitestscore = Console.ReadLine();

    }

    public void Accept(string fn, string ln, string code)
    {
        Console.WriteLine("Accept with params called");
        vfirstname = fn;
        vlastname = ln;
        ccandidatecode = code;
    }

    public void Accept(string xy, string ab)
    {
        Console.WriteLine("Accept with params called");
        //vfirstname = xy;
        //vlastname = ab;
        //ccandidatecode = code;
    }

    public void Display()
    {
        Console.WriteLine("[Display called]");
        Console.WriteLine("Candidatecode : {0} Firstname : {1} Lastname : {2}", ccandidatecode, vfirstname, vlastname);
    }
}
internal class Program
{
    private static void Main(string[] args)
    {

        //Externalcandidate excan;
        //Console.WriteLine("In Main before new externalcandidate");
        //excan = new Externalcandidate(); //default constructor without parameter called
        ////excan.Accept();//call to accept function
        //excan.Display();//call to display function

        //Externalcandidate obj2 = new Externalcandidate("Seema", "Raj", "0002");
        //obj2.Display();

        Console.WriteLine("Main just started");
        {
            Console.WriteLine("InSubblock");
            Externalcandidate obj3 = new Externalcandidate();
            obj3.vfirstname = "hello"; //It is made public
            //obj3.vlastname = "world";  //It is private
            obj3.Display();
            obj3.Accept("Vindo", "Kumar", "0002");
            obj3.Display();
        }
        Console.WriteLine("Main is about to End");
    }
}