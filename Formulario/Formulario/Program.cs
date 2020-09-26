using System;

namespace Formulario
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            String Name, Number, Email, Job;
            int Age;

            Console.WriteLine("WELCOME TO BIOMEDIX \n");
            Thread.Sleep(TimeSpan.FromSeconds(4));

            Console.WriteLine("What´s your FULL NAME ?");
            Name = Console.ReadLine();
            Console.WriteLine("\n")

            Console.WriteLine("What´s your e-mail address?");
            Email = Console.ReadLine();

            Console.WriteLine("\n");

            Console.WriteLine("How old are you?");
            Age = int.Parse(Console.ReadLine());

            Console.WriteLine("\n")

            

            Console.WriteLine("\n");

            Console.WriteLine("What´s your ocupation or job?");

            Job = Console.ReadLine();
            Console.WriteLine("\n");

            //age=Convert.Toint32(Console.ReadLine();

            Console.WriteLine("Your name is: {0}", Name);
            Console.WriteLine("Your age is: {0}", Age);
            if (Age < 17)
            {
                Console.WriteLine("Your age is not accepted, registering is not able. ")
            }
            else
            {
                Console.WriteLine("Registering SUCCESFULLY... ")
            }
        }
    }
}


