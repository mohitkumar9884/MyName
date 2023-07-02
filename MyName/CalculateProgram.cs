using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyName
{
    public class CalculateProgram
    {
        

        //acess modifierreturnType MethodName(parameters)
        public void AdditionOfTwoNumbers()

        {
            Console.WriteLine("Give Two Numbers For Addition");
            Console.WriteLine("Please enter 1st number");
            int firstNumb = Convert.ToInt32(Console.ReadLine());//"10" 10
            Console.WriteLine("Please enter 2nd number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum: " + (firstNumb + secondNumber));
        }
        public void SubtractionOfTwoNumbers()
        {   
            Console.WriteLine("Give Two NUmbers For Subtraction");
            Console.WriteLine("Please enter 1st number");
            int firstNumb = Convert.ToInt32(Console.ReadLine());//"10" 10
            Console.WriteLine("Please enter 2nd number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int result = firstNumb - secondNumber;
            Console.WriteLine("Subtract: " + result);

        }
        public void MultiplicationOfTwoNumbers()
        {
            Console.WriteLine("Give Two Numbers For Multiplication");
            Console.WriteLine("Please enter 1st number");
            int firstNumb = Convert.ToInt32(Console.ReadLine());//"10" 10
            Console.WriteLine("Please enter 2nd number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int result = firstNumb * secondNumber;
            Console.WriteLine("Multiplication: " + result);

        }
            

    }
}
