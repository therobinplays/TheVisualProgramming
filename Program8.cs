/* ## 8. Leap Year */

using System;

public class Program8

{

    public void Year()

    {
        Console.WriteLine("");
        int num = Convert.ToInt32(Console.ReadLine());


        if (num % 400 == 0)

        {

            Console.WriteLine("The given year is a leap year.");
            
        }

        else

        {

            Console.WriteLine("The given year is not a leap year.");
            
        }
        
    }
    
}