// See https://aka.ms/new-console-template for more information

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int num1;
        int num2;
        char sign;

        Console.WriteLine("Input the first  number:");
        num1 = Convert.ToInt32(Console.ReadLine());
        sign = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Input the second  number:");
        num2 = Convert.ToInt32(Console.ReadLine());

        if (sign == '+')
            Console.WriteLine (num1 + num2);
       else if (sign == '-' )
            Console.WriteLine(num1 - num2);
        else if (sign == '*')
            Console.WriteLine(num1 * num2);
        else
            Console.WriteLine(num1 / num2);
        


    }
}
