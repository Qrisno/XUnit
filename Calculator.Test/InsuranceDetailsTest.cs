using Calculator.Test.Fixtures;

namespace Calculator.Test;


[Collection("Insurance")]
public class InsuranceDetailsTest(InsuranceFixture insuranceFixture): IClassFixture<InsuranceFixture>
{
    private readonly InsuranceFixture _insuranceFixture = insuranceFixture;
    [Fact]
    public void InterestRate_Is10()
    {
        var insurance = _insuranceFixture.Insurance;
        Assert.Equal(10, insurance.InterestRate);
    }
}