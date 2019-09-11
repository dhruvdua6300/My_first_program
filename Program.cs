using System;

namespace My_first_program
{
    class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many years experience do you have in professional programming?");
        int years = int.Parse(Console.ReadLine());

        {
            if (years == 0)

                Console.WriteLine("Need lots of practice");

            if (years == 1)

                Console.WriteLine("Looks like you have a little experience");

            if (years == 2)

                Console.WriteLine("Wow! You've been doing this for a little while");

            if (years > 2)

                Console.WriteLine("You are an expert!");


        }




    }
}
}

