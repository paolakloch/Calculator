using System;
using System.Security.Cryptography.X509Certificates;

class Program
{ 
    static void Main()
    {
        double result = 0;
        try
        {
            Console.WriteLine("Type the first number:");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Type the desired opperator: (+,-,*,/)");
            string operation = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Type the second number:");
            double n2 = Convert.ToDouble(Console.ReadLine());
                       
            switch (operation)
            {
                case "+":
                    result = Sum(n1, n2);
                    break;
                case "-":
                    result = Subtraction(n1, n2);
                    break;

                case "*":
                    result = Multiplication(n1, n2);
                    break;

                case "/":
                    result = Division(n1, n2);
                    break;
                default:
                    Console.WriteLine("Error: Insert a valid operator");
                    break;
            }

            }   
            
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Division by Zero.");
        }
       
        catch (FormatException ex)
        {
            Console.WriteLine("Error: Please type a number.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error");
        }

        catch (Exception ex)
        {
            Console.WriteLine("Error: Try again");
  
        }
       
        Console.WriteLine($"Result = {result}");
    }

    private static double Division(double n1, double n2)
    {
        return n1 / n2;
    }

    private static double Multiplication(double n1, double n2)
    {
        return (n1 * n2);
    }

    private static double Subtraction(double n1, double n2)
    {
        return (n1 - n2);
    }

    private static double Sum(double n1, double n2)
    {
        return (n1 + n2);
    }
}
