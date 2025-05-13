using System.Runtime.Serialization;
using Calculator.Test.Fixtures;

namespace Calculator.Test;
[Collection("Insurance")]
public class InsuranceTest(InsuranceFixture insuranceFixture): IClassFixture<InsuranceFixture>
{
    private readonly InsuranceFixture _insuranceFixture = insuranceFixture; 
    [Fact]
    public void GetDiscountPercentage_GivenAge65_Returns5()
    {
        var insurance = _insuranceFixture.Insurance;
        var age = 65;
        var discount = insurance.GetDiscountPercentage(age);
        var expectedDiscount = 5;
        Assert.Equal(expectedDiscount, discount);
    }
    
    [Fact]
    public void GetDiscountPercentage_GivenAge46_Returns10()
    {
        var insurance = _insuranceFixture.Insurance;
        var age = 46;
        var discount = insurance.GetDiscountPercentage(age);
        var expectedDiscount = 10;
        Assert.Equal(expectedDiscount, discount);
    }
    
    [Fact]
    public void GetDiscountPercentage_GivenAge39_Returns10()
    {
        var insurance = _insuranceFixture.Insurance;
        var age = 39;
        var discount = insurance.GetDiscountPercentage(age);
        var expectedDiscount = 20;
        Assert.Equal(expectedDiscount, discount);
    }
    
    [Fact]
    public void GetDiscountPercentage_GivenAge26_Returns20()
    {
        var insurance = _insuranceFixture.Insurance;
        var age = 26;
        var discount = insurance.GetDiscountPercentage(age);
        var expectedDiscount = 20;
        Assert.Equal(expectedDiscount, discount);
    }
    
    [Fact]
    public void GetDiscountPercentage_GivenAge18_Returns5()
    {
        var insurance = _insuranceFixture.Insurance;
        var age = 18;
        var discount = insurance.GetDiscountPercentage(age);
        var expectedDiscount = 10;
        Assert.Equal(expectedDiscount, discount);
    }
    
    [Fact]
    public void GetDiscountPercentage_GivenAge2_ThrowsException()
    {
        var insurance = _insuranceFixture.Insurance;
        var age = 2;
        Assert.Throws<InvalidDataContractException>(()=>insurance.GetDiscountPercentage(age));
    }

    [Fact]
    public void CreateCustomer_GivenCompanyYear2_ReturnsNormalCustomer()
    {
        var insurance = _insuranceFixture.Insurance;
        var customer = CustomerFactory.CreateCustomer(2, 65);
        
        Assert.IsType<Customer>(customer);
        Assert.Equal(5, customer.Discount);
    }
    
    [Fact]
    public void CreateCustomer_GivenCompanyYear10_ReturnsLoyalCustomer()
    {
        var insurance = _insuranceFixture.Insurance;
        var customer = CustomerFactory.CreateCustomer(10, 65);
        
        Assert.IsType<LoyalCustomer>(customer);
        Assert.Equal(15, customer.Discount);
    }
}