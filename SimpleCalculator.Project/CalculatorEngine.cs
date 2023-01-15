namespace SimpleCalculator.Project;

public class CalculatorEngine
{
    public double Calculate(string? opr, double firstNum, double secondNum)
    {
        double result;
        switch (opr?.ToLower())
        {
            case "add":
            case "+":
                result = firstNum + secondNum;
                break;
            case "subract":
            case "-":
                result = firstNum - secondNum;
                break;
            case "multiply":
            case "*":
                result = firstNum * secondNum;
                break;
            case "divide":
            case "/":
                result = firstNum / secondNum;
                break;
            default:
                throw new InvalidOperationException("Specified operation not recognized");
        }
        return result;
    }
}