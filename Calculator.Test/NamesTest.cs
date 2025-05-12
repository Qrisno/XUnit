namespace Calculator.Test;

public class NamesTest
{
    [Fact]
    public void GenerateFullName_GivenTwoStrings_ReturnsFullName()
    {
        //Arrange
        var names = new Names();
        string fullNameMock = "John Doe";
        //Act
        var fullName = names.GenerateFullName("John", "Doe");
        //Assert
        Assert.Equal(fullName, fullNameMock);
    }

    [Fact]
    public void GenerateFullName_GivenTwoValues_MatchesRegex()
    {
        //Arrange
        var names = new Names();
        var nameRegex = @"^[A-Z][a-z]+(?:[-']?[A-Z][a-z]+)*\s+(?:[A-Z][a-z]+\s+)*[A-Z][a-z]+(?:[-']?[A-Z][a-z]+)*$";
        
        
        //Act
        var fullName = names.GenerateFullName("John", "Doe");
        //Assert
        Assert.Matches(nameRegex, fullName);
    }

    [Fact]
    public void GenerateFullName_GivenMethodNotCalled_NicknameShouldBeNull()
    {
        var names = new Names();
        Assert.Null(names.NickName);
    }
}