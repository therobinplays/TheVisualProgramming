/* ## 2. Even or Odd */

using System;

public class Program2

{

    public void Input()
    
    {

        int num;
        
        Console.WriteLine("Enter a num to check the given number is even or odd.");
        num= Convert.ToInt32(Console.ReadLine());


        if (num % 2 == 0)
        
        {
            Console.WriteLine($"The given number {num} is even.");
        }

        else

        {
            Console.WriteLine($"The given number {num} is odd.");
        }
        
    }
    
}