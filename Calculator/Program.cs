namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double inputNumber1 = 0;
                double result = 0;
                Console.WriteLine("Calculator");
                Console.WriteLine("Enter Number 1");
                inputNumber1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter Number 2");
                double inputNumber2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter option to be executed");
                Console.WriteLine("ADD: \t+");
                Console.WriteLine("SUBTRACT: \t-");
                Console.WriteLine("MULTIPLY : \t*");
                Console.WriteLine("DEVIDE: \t/");

                switch (Console.ReadLine())
                {
                    case "+":
                        result = inputNumber1 + inputNumber2;
                        Console.WriteLine($"Your Result: {result}");
                        break;
                    case "-":
                        result = inputNumber1 - inputNumber2;
                        Console.WriteLine($"Your Result: {result}");
                        break;
                    case "*":
                        result = inputNumber1 * inputNumber2;
                        Console.WriteLine($"Your Result: {result}");
                        break;
                    case "/":
                        if (inputNumber2 == 0)
                        {
                            Console.WriteLine("Cannot divide by zero!");
                        }
                        else
                        {
                            result = inputNumber1 / inputNumber2;
                            Console.WriteLine($"Your Result: {result}");
                        }
                        break;
                    default:
                        Console.WriteLine("Wrong Input!");
                        break;
                }
                Console.WriteLine("Would you like to continue? (Y = yes, N = No): ");

            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Bye!");
            Environment.Exit(0);
        }
    }
}
