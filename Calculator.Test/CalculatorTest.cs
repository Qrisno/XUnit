namespace Calculator.Test;

public class CalculatorTest
{
    
    //Naming Convention MethodName_Predicate_ExpectedResult
    [Fact]
    public void Add_Given1And2_Returns3()
    {
        //Arrange - Create Instance of the class
        var calculator = new Calculator();
        //Act
        var sum = calculator.Add(1, 2);
        //Assert
        Assert.Equal(3, sum);
    }

    [Fact]
    public void Add_GivenTwoDecimals_ReturnsSumWithTwoPlaces()
    {
        //Arrange
        var calculator = new Calculator();
        
        //Act
        var sum = calculator.Add(1.5m,1.3m);
        
        //Assert
        Assert.Equal(2.8m, sum);
    }

    [Fact]
    public void GetFibonacci_GivenLengthOf3_ReturnsArrayWith3Elements()
    {
        //Arrange
        var calculator = new Calculator();
        //Act
        var fibonacci = calculator.GetFibonacci(3);
        //Assert
        Assert.Equal(new[] {1,1,2}, fibonacci);
    }

    [Fact]
    public void GetFibonacci_NotIncludes0()
    {
        //Arrange
        var calculator = new Calculator();
        //Act
        var fibonacci = calculator.GetFibonacci(3);
        //Assert
        Assert.All(fibonacci, n=>Assert.NotEqual(0,n));
    }
    
    [Fact]
    public void GetFibonacci_NotIncludes4()
    {
        //Arrange
        var calculator = new Calculator();
        //Act
        var fibonacci = calculator.GetFibonacci(3);
        //Assert
        Assert.DoesNotContain(4, fibonacci);
    }
    
    [Fact]
    public void GetFibonacci_FirstFiveMembersAreCorrect()
    {
        //Arrange
        var calculator = new Calculator();
        //Act
        var fibonacci = calculator.GetFibonacci(5);
        var expected = new[] {1,1,2,3,5};
        //Assert
        Assert.Equal(expected, fibonacci);
    }
}