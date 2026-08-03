/* ## 6. Divisible by 5 */

using System;

public class Program6

{

    public void Check()
    {
        Console.WriteLine("Enter a number to check its divided by 5 or not.");
        int num = Convert.ToInt32(Console.ReadLine());
        
        if (num%5==0)

        {

            Console.WriteLine("This number is divisable by 5.");

        }

        else

        {

            Console.WriteLine("This number is not divisable by 5.");
            
        }

    }
    
}