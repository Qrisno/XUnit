namespace Calculator.Test.TestDataShare;

public class TestDataSharer
{
    public static IEnumerable<object[]> ValuesForAddMethod 
    {
        get
        {
            yield return [1, 2, 3];
            yield return [-3, 2, -1];
        }
    }
}