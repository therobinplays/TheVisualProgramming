/* ## 7. Divisible by 5 and 11 */

using System;
using System.Globalization;

public class Program7

{

    public void Check()

    {
        Console.WriteLine("Enter a number to check its divided by 5 and 11 or not.");
        int num =Convert.ToInt32(Console.ReadLine()) ;

        if (num%5==0 && num%11==0)

        {
            Console.WriteLine("This number is divisible by both 5 and 11.");
        }

        else

        {
            Console.WriteLine("This number is not divisible by both 5 and 11");
        }
        
    }
    
}