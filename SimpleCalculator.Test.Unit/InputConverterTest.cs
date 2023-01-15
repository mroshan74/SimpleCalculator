using SimpleCalculator.Project;
namespace SimpleCalculator.Test.Unit;

public class InputConverterTest
{
    //arrange
    private readonly InputConverter _inputConverter = new InputConverter();
    
    [Fact] 
    public void ConvertsValidStringInputToDouble()
    {
        string inputNum = "5";
        double converted = _inputConverter.ConvertInputToNumeric(inputNum);
        Assert.Equal(5, converted);
    }

    [Fact]
    public void FailsToConvertInvalidStringInputIntoDouble()
    {
        string inputNumber = "afk";
        //act
        Action testCode = () => _inputConverter.ConvertInputToNumeric(inputNumber);
        //assert
        ArgumentException exception = Assert.Throws<ArgumentException>(testCode);
        //The thrown exception can be used for even more detailed assertions.
        Assert.Equal("Expected a numeric value", exception.Message);
    }
}