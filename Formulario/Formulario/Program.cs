﻿using System;

namespace Formulario
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            String Name, Number, Email, Job;
            int Age;
            Console.WriteLine("What´s your name?");
            Name = Console.ReadLine();
            Console.WriteLine("/////////////////////////////////////");
            Console.WriteLine("How old are you?");
            Age = int.Parse(Console.ReadLine());
            Console.WriteLine("/////////////////////////////////////");
            Console.WriteLine("What´s your e-mail address?");
            Email = Console.ReadLine();
            Console.WriteLine("/////////////////////////////////////");
            Console.WriteLine("What´s your ocupation or job?");
            Email = Console.ReadLine();
            Console.WriteLine("/////////////////////////////////////");

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
            //hello 
        }
    }
}
