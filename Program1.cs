/* ## 1. Positive, Negative or Zero */

using System;

public class Program1

{
    public void Input()

    {

        Console.WriteLine("Enter a number to check the given number.");
        int num = Convert.ToInt32(Console.Read());

        if (num<0)

        {
            Console.WriteLine($"The given {num} is negative.");
            
        }

        else if(num>0)

        {
            Console.WriteLine($"The given {num} is positive.");
        }

        else

        {
            Console.WriteLine($"The given {num} is zero.");
        }
        
    }
    
}