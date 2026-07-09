/* Store the temperature in Celsius and convert it to Fahrenheit. */

using System;

public class Degree

{

    public void Temperature (double celsius)

    {
        
        double fahrenheit = (celsius * 1.8)+32;
        Console.WriteLine("The conversion of celsius "+celsius +" to farhenheit id " +fahrenheit);

    }
    
}