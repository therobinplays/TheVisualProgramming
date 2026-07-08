/* Declare variables for principal, rate, and time, then calculate simple interest. */
using System;

public class Simpleintrest
{
    
    public void Amount (int p, int t, int r)

    {
        int si = p*t*r/100;
        Console.WriteLine("The simpleintrest is Rs. : " +si);
        
    }

}