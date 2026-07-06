/* Store the length and breadth of a rectangle and calculate the perimeter. */

using System;

public class Perimeter
{

    public void Value(double l, double b)
    {
        
        double p =2*(l+b);
        Console.WriteLine("The Perimeter of rectangle is " + p);

    }

}