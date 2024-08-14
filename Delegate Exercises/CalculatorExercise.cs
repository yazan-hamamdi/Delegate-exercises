using System;
using System.Reflection;
namespace Delegate_Exercises
{
    
    public class CalculatorExercise
    {
        public delegate int Operation(int num1, int num2);

        public int Add (int num1  , int num2) => num1 + num2;
        public int Subtract(int num1, int num2) => num1 - num2;
        public int Multiply(int num1, int num2) => num1 * num2;
        public int Divide(int num1, int num2) => num1 / num2;

        public void Calculator(Operation myOperation, int num1, int num2)
        {
            MethodInfo methodInfo = myOperation.Method;
            string methodName = methodInfo.Name;

            Console.WriteLine($"Calling Method: {methodName}");
            Console.WriteLine($"The Result = {myOperation(num1, num2)}");
        }
    }
}
