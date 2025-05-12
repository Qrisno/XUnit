using System.Runtime.Serialization;

namespace Calculator;

public class Insurance
{
    public int GetDiscountPercentage(int age)
    {
        switch (age)
        {
            case >=65: return 5;
            case >=45: return 10;
            case >=25: return 20;
            case >=18: return 10;
            default: throw new InvalidDataContractException();
        }

      
    }
}


public class Customer(Insurance insurance, int age)
{
    public virtual int Discount =>insurance.GetDiscountPercentage(age);
}

public class LoyalCustomer(Insurance insurance, int age) : Customer(insurance, age)
{
    private Insurance Insurance { get; set; } = insurance;
    public override int Discount => Insurance.GetDiscountPercentage(age) + 10;
}

public static class CustomerFactory
{
    public static Customer CreateCustomer(int yearsWithCompany, int age)
    {
        return yearsWithCompany >= 5 ? new LoyalCustomer(new Insurance(), age) : new Customer(new Insurance(), age);
    }
}