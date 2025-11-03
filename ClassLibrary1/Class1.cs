namespace ClassLibrary1;

public class Class1
{

    public int Add(int a, int b) => a + b;

    public int Subtract(int a, int b) => a - b;

    public int Multiply(int  a, int b) => a * b;

    public double Divide(double a, double b)
    {
        if(b == 0) throw new DivideByZeroException("cannot divide by zero");
        return a / b;
        
    }
    public int Square(int a) => a * a;

    public int Power(int @base, int exponent)
    {
        if (exponent < 0) throw new ArgumentOutOfRangeException(nameof(exponent), "Negative exponents not supported.");
        int result = 1;
        for (int i = 0; i < exponent; i++)
            result *= @base;
        return result;
    }
   


}
