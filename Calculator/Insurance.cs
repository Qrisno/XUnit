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