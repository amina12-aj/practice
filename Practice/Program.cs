

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int num1;
        int num2;
        string sign;

        Console.WriteLine("Input the first  number:");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input the operator:");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
        sign = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Input the second  number:");
        num2 = Convert.ToInt32(Console.ReadLine());

        if (sign == "+")
            Console.WriteLine ("Your answer is " + "" + num1 + num2);
       else if (sign == "-" )
            Console.WriteLine("Your answer is " + "" + "" + (num1 - num2));
        else if (sign == "*")
            Console.WriteLine("Your answer is " +"" + num1 * num2);
        else
            Console.WriteLine("Your answer is " + "" + "" + num1 / num2);
        
        Thread.Sleep(2000);

        Console.Clear();

    }
}
