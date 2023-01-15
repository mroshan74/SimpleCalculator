using SimpleCalculator.Project;

namespace SimpleCalculator.Test.Unit;

public class CalculatorEngineTest
{
    private readonly CalculatorEngine _calculatorEngine = new CalculatorEngine();
    
    [Fact] 
    public void AddsTwoNumberAndReturnsValidResultForNonSymbolOperation()
    {
        int num1 = 10;
        int num2 = 8;
        double result = _calculatorEngine.Calculate("add", num1, num2);
        Assert.Equal(18, result);
    }
    
    [Fact] 
    public void AddsTwoNumberAndReturnsValidResultForSymbolOperation()
    {
        int num1 = 10;
        int num2 = 8;
        double result = _calculatorEngine.Calculate("+", num1, num2);
        Assert.Equal(18, result);
    }
}