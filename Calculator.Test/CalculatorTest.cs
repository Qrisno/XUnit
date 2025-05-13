namespace Calculator.Test;

public class CalculatorFixture
{
    public Calculator Calc => new Calculator();
}
public class CalculatorTest(ITestOutputHelper outputHelper, CalculatorFixture calculatorFixture): IClassFixture<CalculatorFixture>
{
    private readonly ITestOutputHelper _outputHelper = outputHelper;
    private readonly CalculatorFixture _calculatorFixture = calculatorFixture;
    //Naming Convention MethodName_Predicate_ExpectedResult
    [Fact]
    [Trait("Calculator", "Ops")]
    public void Add_Given1And2_Returns3()
    {
        _outputHelper.WriteLine("Executed");
        //Act
        var sum = _calculatorFixture.Calc.Add(1, 2);
        //Assert
        Assert.Equal(3, sum);
    }

    [Fact]
    [Trait("Calculator", "Ops")]
    public void Add_GivenTwoDecimals_ReturnsSumWithTwoPlaces()
    {
        
        //Act
        var sum =  _calculatorFixture.Calc.Add(1.5m,1.3m);
        
        //Assert
        Assert.Equal(2.8m, sum);
    }

    [Fact]
    [Trait("Calculator", "Fibo")]
    public void GetFibonacci_GivenLengthOf3_ReturnsArrayWith3Elements()
    {
        //Act
        var fibonacci =  _calculatorFixture.Calc.GetFibonacci(3);
        //Assert
        Assert.Equal(new[] {1,1,2}, fibonacci);
    }

    [Fact]
    [Trait("Calculator", "Fibo")]
    public void GetFibonacci_NotIncludes0()
    {
        //Act
        var fibonacci =  _calculatorFixture.Calc.GetFibonacci(3);
        //Assert
        Assert.All(fibonacci, n=>Assert.NotEqual(0,n));
    }
    
    [Fact]
    [Trait("Calculator", "Fibo")]
    public void GetFibonacci_NotIncludes4()
    {
        //Act
        var fibonacci =  _calculatorFixture.Calc.GetFibonacci(3);
        //Assert
        Assert.DoesNotContain(4, fibonacci);
    }
    
    [Fact]
    [Trait("Calculator", "Fibo")]
    public void GetFibonacci_FirstFiveMembersAreCorrect()
    {
        //Act
        var fibonacci =  _calculatorFixture.Calc.GetFibonacci(5);
        var expected = new[] {1,1,2,3,5};
        //Assert
        Assert.Equal(expected, fibonacci);
    }
}