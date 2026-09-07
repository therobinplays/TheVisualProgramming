/* Take input from user and display elements */

using System;

public class Array1d

{
    public void Data()

    {

        int [] num = new int [5];
        Console.WriteLine("Enter five numbers");

        for (int i=0; i<5; i++)

        {

            Console.WriteLine("Number " + (i + 1) + ": ");
            num[i]=Convert.ToInt32(Console.ReadLine());
            
        }

        Console.WriteLine("You have entered");

        for (int i=0; i<5; i++)

        {
            Console.WriteLine(num[i]);
        }
        
    }

}