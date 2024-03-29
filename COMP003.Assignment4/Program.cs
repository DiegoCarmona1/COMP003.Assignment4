﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author:  Diego Carmona
 * Course: COMP003A
 * Purpose: To develop and improve capability in using C# in respect to utilizing loops.
 */

namespace COMP003.Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // For loop section (Right triangle)
            Console.WriteLine("*********************************");
            Console.WriteLine("For Loop Section");
            Console.WriteLine("Output a right triangle based on user input");
            Console.WriteLine("*********************************");
            Console.WriteLine("Enter a positive whole number: ");
            string input = Console.ReadLine();
            int limit = Convert.ToInt32(input);
            string output = "#";
            for (int i = 0; i < limit; i++)
            {
                Console.WriteLine(output);
                output += "#";
            }

            // For Each Section
            Console.WriteLine("*********************************");
            Console.WriteLine("foreach Section");
            Console.WriteLine("Output a;; of the friends in an array");
            Console.WriteLine("*********************************");

            string[] friends = new string[] { "Rachel", "Joey", "Chandler", "Ross", "Monica", "Phoebe" };
            foreach (string friend in friends)
            {
                Console.WriteLine($"\t{friend} is my friend");
            }

            //do-while section
            Console.WriteLine("*********************************");
            Console.WriteLine("do-while Section");
            Console.WriteLine("Output 0-50 by 5s");
            Console.WriteLine("*********************************");

            int counter = 0;

            do
            {
                Console.WriteLine($"{counter}");
                counter += 5;
            } while (counter <= 50);

            //While Section
            Console.WriteLine("*********************************");
            Console.WriteLine("while Section");
            Console.WriteLine("Output 1-20");
            Console.WriteLine("If the number is divisible by 2, output Foo");
            Console.WriteLine("If the number is divisible by 5, output Bar");
            Console.WriteLine("If the number is divisible by 2 & 5, output FooBar");
            Console.WriteLine("*********************************");
            int counter2 = 1;

            while (counter2 <= 20)
            {
                if (counter2 % 2 == 0 && counter2 % 5 == 0)
                {
                    Console.WriteLine("FooBar");
                }
                else if (counter2 % 5 == 0) 
                {
                    Console.WriteLine("Bar");
                }
                else if (counter2 % 2 == 0)
                {
                    Console.WriteLine("Foo");
                }
                else
                {
                    Console.WriteLine(counter2);
                }
                counter2++;
            }


        }
    }
}
