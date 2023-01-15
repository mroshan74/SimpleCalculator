namespace SimpleCalculator.Project;

public class InputConverter
{
    public double ConvertInputToNumeric(string argTextInput)
    {
        if (!double.TryParse(argTextInput, out var convertedNumber))
        {
            throw new AggregateException("Expected a numeric value");
        }
        return convertedNumber;
    }
}