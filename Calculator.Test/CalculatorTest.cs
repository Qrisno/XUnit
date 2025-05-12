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
}