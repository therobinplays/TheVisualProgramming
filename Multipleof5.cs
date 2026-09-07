/* 
**Question 2 — Print a Multiplication Table**
Create a function `MultiplicationTable()` with **no arguments and no return type**.

The function should print the multiplication table of `5` from `1` to `10`.

Expected output:

```text
5 x 1 = 5
5 x 2 = 10
...
5 x 10 = 50
```
*/

using System;

public class Multipleof5
{
    public void Multiple ()

    {

        int num = 5;
        int multiplication;

        for (int i=1; i<=10; i++)
        {

            multiplication= num * i;
            Console.WriteLine(multiplication);

        }
        
    }
}

