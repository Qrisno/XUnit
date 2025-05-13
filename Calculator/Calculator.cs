namespace Calculator;

public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
    
    public decimal Add(decimal a, decimal b)
    {
        return a + b;
    }

    public IEnumerable<int> GetFibonacci(int length)
    {
        int first = 1;
        int second = 1;
        yield return first;
        yield return second;
        for (int i =0; i < length-2;i++)
        {
            var next =  first + second;
            first = second;
            second = next;
            yield return next;
        }
        
    }
    
    public bool IsEven(int number)=> number % 2 == 0;
}