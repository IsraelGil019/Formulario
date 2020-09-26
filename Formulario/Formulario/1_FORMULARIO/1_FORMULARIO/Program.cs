using System;

namespace _1_FORMULARIO
{
    class Program
    {
        static void Main(string[] args)
       
            {
                String Name, Number, Email, Job;
                int Age;

                Console.WriteLine("WELCOME TO BIOMEDIX \n");
                
                Console.WriteLine("What´s your FULL NAME ?");
                Name = Console.ReadLine();

                Console.WriteLine("\n");

                Console.WriteLine("What´s your phone number?");
                Number = Console.ReadLine();

                Console.WriteLine("\n");

                Console.WriteLine("What´s your e-mail address?");
                Email = Console.ReadLine();

                Console.WriteLine("\n");

                Console.WriteLine("What´s your ocupation or job?");
                Job = Console.ReadLine();
                Console.WriteLine("\n");

                Console.WriteLine("How old are you?");
                Age = int.Parse(Console.ReadLine());

                //age=Convert.Toint32(Console.ReadLine();

                Console.WriteLine("Your name is: {0}", Name);
                Console.WriteLine("Your age is: {0}", Age);
                Console.WriteLine("Your Email-address is: {0}", Email);
                Console.WriteLine("Your Job is: {0}", Job);


                if (Age < 18)
                {
                Console.WriteLine("¡¡Your age is NOT ACCEPTED, registering is NOT ABLE FOR U!! ");
                }
                else 
                {
                Console.WriteLine("Registering SUCCESFULLY... ");
                }
            }
        }
    }


   
    