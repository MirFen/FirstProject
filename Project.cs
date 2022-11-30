﻿namespace FirstProject
{
    public class Project
    {
        private static void Main(string[] args)
        {
            int i = 0;
            int sum = 0;
            int? max = null;

            System.Console.WriteLine("To exit, type '0'");

            do
            {
                string? value = System.Console.ReadLine();

                if (int.TryParse(value, out i))
                {
                    // System.Console.WriteLine(i);
                    sum += i;
                    max = max > i ? max : i;

                }
                else
                {
                    System.Console.WriteLine("Incorrect value");
                    i = -1;
                }
            } while (i != 0);


            if ( max ==0)
            {
                System.Console.WriteLine("sum of numbers:not exist " + " max value: not exist ");
                System.Console.WriteLine();
                System.Console.WriteLine("Good bye ");
            }
             else if (max !=null) 
            {
                System.Console.WriteLine("Good bye " + "sum of numbers: " + sum + " max value: " + max);
            }
           
        }

    }
}
