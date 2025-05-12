using System.Runtime.Serialization;

namespace Calculator.Test;

public class InsuranceTest
{
    [Fact]
    public void GetDiscountPercentage_GivenAge65_Returns5()
    {
        var insurance = new Insurance();
        var age = 65;
        var discount = insurance.GetDiscountPercentage(age);
        var expectedDiscount = 5;
        Assert.Equal(expectedDiscount, discount);
    }
    
    [Fact]
    public void GetDiscountPercentage_GivenAge46_Returns10()
    {
        var insurance = new Insurance();
        var age = 46;
        var discount = insurance.GetDiscountPercentage(age);
        var expectedDiscount = 10;
        Assert.Equal(expectedDiscount, discount);
    }
    
    [Fact]
    public void GetDiscountPercentage_GivenAge39_Returns10()
    {
        var insurance = new Insurance();
        var age = 39;
        var discount = insurance.GetDiscountPercentage(age);
        var expectedDiscount = 20;
        Assert.Equal(expectedDiscount, discount);
    }
    
    [Fact]
    public void GetDiscountPercentage_GivenAge26_Returns20()
    {
        var insurance = new Insurance();
        var age = 26;
        var discount = insurance.GetDiscountPercentage(age);
        var expectedDiscount = 20;
        Assert.Equal(expectedDiscount, discount);
    }
    
    [Fact]
    public void GetDiscountPercentage_GivenAge18_Returns5()
    {
        var insurance = new Insurance();
        var age = 18;
        var discount = insurance.GetDiscountPercentage(age);
        var expectedDiscount = 10;
        Assert.Equal(expectedDiscount, discount);
    }
    
    [Fact]
    public void GetDiscountPercentage_GivenAge2_ThrowsException()
    {
        var insurance = new Insurance();
        var age = 2;
        Assert.Throws<InvalidDataContractException>(()=>insurance.GetDiscountPercentage(age));
    }
}