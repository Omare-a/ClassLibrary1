namespace ClassLibrary1;

public class Class1
{

    public int Add(int a, int b) 
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int  a, int b)
    {
        return a * b;
    }

    public double Divide(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("cannot divide by zero");
        }
        return a / b;
    }


}
