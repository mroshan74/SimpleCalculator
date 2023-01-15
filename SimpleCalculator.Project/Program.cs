namespace SimpleCalculator.Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? confirm = "y";
            while (confirm?.ToLower() == "y")
            {
                try
                {
                    InputConverter inputConverter = new InputConverter();
                    CalculatorEngine calculatorEngine = new CalculatorEngine();

                    Console.WriteLine($"Enter first number:");
                    double firstNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                    Console.WriteLine($"Enter second number:");
                    double secondNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                    Console.WriteLine($"Enter operation type:");
                    string? operation = Console.ReadLine();

                    double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);
                    Console.WriteLine($"Result: {result}");
                }
                catch (Exception ex)
                {
                    //TODO: start logging exceptions 
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine($"Do you want to continue (Y):");
                confirm = Console.ReadLine();
            }
        }
    }
}