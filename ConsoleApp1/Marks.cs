// Declare three variables for Physics, Chemistry, and Mathematics marks, then calculate the total.

using System;

public class Marks

{
    public void Points(int p, int c, int m)
    {
        
        int total = p + c + m;
        Console.WriteLine($"The total marks after adding {p} and {c} and {m} is  {total}");

    }
    
}