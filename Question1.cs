/* 
Write a C# program to input the salary of 8 employees. 
         Calculate the bonus according to the following rules: 
Salary   Bonus 
Less than Rs. 20,000  20% 
Rs. 20,000–39,999  15% 
Rs. 40,000–59,999  10% 
Rs. 60,000 and above 5% 

 Display the salary, bonus amount, and total salary after adding the bonus. 
 */

 using System;

 public class Question1

{

    public void Payment ()

    {


        double salary;
        double bonus;
        double totalSalary;

        for (int employeeNo=1; employeeNo<=8; employeeNo++)

        {
            Console.WriteLine("Employee " + employeeNo);

            Console.WriteLine("Enter your Salary amount");
            salary=Convert.ToDouble(Console.ReadLine());

            if (salary<20000)

            {
                bonus = salary*20/100;
            }

            else if (salary<40000 && salary>=20000)

            {
                bonus = salary*15/100;
            }

            else if (salary<60000 && salary>=4000 )

            {
                bonus= salary*10/100;
            }

            else
            
            {
                bonus=salary*5/100;
            }

            totalSalary = salary + bonus;

            Console.WriteLine("Salary : Rs " + salary);
            Console.WriteLine("Bonus : Rs " + bonus);
            Console.WriteLine("TotalSalary : Rs " + totalSalary);

        }
        
    }
    
}