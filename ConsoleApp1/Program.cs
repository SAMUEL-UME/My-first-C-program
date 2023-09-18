using System.Diagnostics.CodeAnalysis;

namespace CalculatorConsole
{
   internal class Program
   {
       static void Main(string[] args)
       {
           Console.WriteLine("======Enter the action to be performed====");
           Console.WriteLine("Press 1 for addition");
           Console.WriteLine("Press 2 for subtraction");
           Console.WriteLine("Press 3 for division");
           Console.WriteLine("Press 4 for multiplication");

           int action = Convert.ToInt32(Console.ReadLine());
           //convett to int = converts to a whole number
           Console.WriteLine("First number");
           int firstInput = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Second number");
           int secondInput = Convert.ToInt32(Console.ReadLine());
           decimal result = 0;
           //switch statement
           //while loop
           switch (action)
           {
               case 1:
                   result = Addition(firstInput, secondInput);
                   break;
               case 2:
                   result = Subtraction(firstInput, secondInput);
                   break;
               case 3:
                   result = Division(firstInput, secondInput);
                   break;
               case 4:
                   result = Multiplication(firstInput, secondInput);
                   break;
               default:
                   Console.WriteLine("I do not understand your request");
                   break;
           }
           Console.WriteLine($"The result is {result}");
       }
       public static int Addition(int firstInput, int secondInput)
       {
           int result = firstInput + secondInput;
           return result;
       }
       public static int Subtraction(int firstInput, int secondInput)
       {
           int result = firstInput - secondInput;
           return result;
       }
       public static int Division(int firstInput, int secondInput)
       {
           int result =    firstInput / secondInput;
           return result;
       }
       public static int Multiplication(int firstInput, int secondInput)
       {
           int result = firstInput * secondInput;
           return result;
       }
   }
} 
