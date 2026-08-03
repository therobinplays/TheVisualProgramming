/* ## 5. Voting Eligibility */

using System;

public class Program5 
{

    public void Eligibility ()

    {

        Console.WriteLine("Enter your age for the Voting Eligibility.");
        int age = Convert.ToInt32(Console.ReadLine());

        if ( age >= 18)

        {

            Console.WriteLine(" You are eligible for Voting.");

        }

        else
        {

            Console.WriteLine(" You are under age so, you are not eligible for Voting.");

        }

    }

}