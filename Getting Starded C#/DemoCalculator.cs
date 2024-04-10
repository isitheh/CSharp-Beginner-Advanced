using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getting_Starded_C_
{
    public class DemoCalculator
    {
        private string _greeting;

        public DemoCalculator(string greeting)
        {
            _greeting = greeting;
        }

        public void Start()
        {
            Console.WriteLine(_greeting);

            Dictionary<string, string> supportedOperands = new Dictionary<string, string>
            {
                { "+", "Addition" },
                { "-", "Subtraction" },
                { "*", "Multiplication" },
                { "/", "Division" }
            };

            while(true) 
            {                 
                Console.WriteLine("Enter the first number: ");
                double firstNumber = Convert.ToDouble(Console.ReadLine());
            
                Console.WriteLine("Enter the second number: ");
                double secondNumber = Convert.ToDouble(Console.ReadLine());
            
                Console.WriteLine("Enter the operand: ");
                string operand = Console.ReadLine();
            
                if (supportedOperands.ContainsKey(operand))
                {
                    double result = 0;
                    switch (operand)
                    {
                        case "+":
                            result = firstNumber + secondNumber;
                            break;
                        case "-":
                            result = firstNumber - secondNumber;
                            break;
                        case "*":
                            result = firstNumber * secondNumber;
                            break;
                        case "/":
                            if (secondNumber == 0)
                            {
                                Console.WriteLine("Division by zero is not allowed");
                                continue;
                            }
                            result = firstNumber / secondNumber;
                            break;
                    }
                    Console.WriteLine($"The result of {supportedOperands[operand]} is {result}");
                }
                else
                {
                    Console.WriteLine("Invalid operand");
                }
                Console.WriteLine("Do you want to continue? (Y/N)");
                string response = Console.ReadLine();
                if (response.ToUpper() != "Y")
                {
                    break;
                }
            }   
        }
    }
}
