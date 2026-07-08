/* Swap the values of two variables using a third variable. */

using System;

public class Swap

{

    public void Change (int a, int b)

    {

        a = a+b;
        b = a-b;
        a = a-b;

        Console.WriteLine(" Swap of a = " +a + " b ="+b );
        
    }
    
    
}