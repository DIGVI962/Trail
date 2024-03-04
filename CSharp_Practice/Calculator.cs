using System.Reflection.Emit;

namespace CSharp_Practice
{
    internal class Calculator
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Welcome to the Calculator!");
            Console.WriteLine("The basic operations allowed are:- \n1 - Addition\n2 - Subtraction\n3 - Multiplication\n4 - Division\n5 - Exit");
            while (true) 
            {
                Console.WriteLine("Please Select the Arithmatic operation to be performed: ");
                int arithmaticOperator = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter the first Operand: ");
                decimal firstOperand = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter the second Operand: ");
                decimal secondOperand = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("The result is: ");
                switch (arithmaticOperator)
                {
                    case 1:
                        Console.WriteLine(firstOperand + secondOperand);
                        break;
                    case 2:
                        Console.WriteLine(firstOperand - secondOperand);
                        break;
                    case 3:
                        Console.WriteLine(firstOperand * secondOperand);
                        break;
                    case 4:
                        Console.WriteLine(firstOperand / secondOperand);
                        break;
                    case 5:
                        goto exit;
                        break;
                    default:
                        Console.WriteLine("Please select a valid choice.");
                        break;
                }

            }
            exit:
            Console.WriteLine("Thank you for using the calculator!");*/

            
            try
            {
                string[] dirs = Directory.GetDirectories(@"c:\", ".*", SearchOption.TopDirectoryOnly);
                Console.WriteLine("The number of directories starting with p is {0}.", dirs.Length);
                foreach (string dir in dirs)
                {
                    Console.WriteLine(dir);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            

        }
    }
}
