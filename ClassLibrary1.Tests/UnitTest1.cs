namespace ClassLibrary1.Tests;

/// <summary>
/// dessa tester kontrollerar att calculator klassen fungerar.
/// vi testar alla tal och specialfall som division med noll
/// syftet är att säkerställa att alla metoder hanterar båda normala och oväntade värden
/// </summary>

public class UnitTest1
{
    [Fact]
    public void AddTwoNumbers_ReturnSum()
    {
        var calc = new ClassLibrary1.Class1();
        Assert.Equal(5, calc.Add(2, 3));
    }

    [Fact]
    public void AddNegetiveNumber_ReturnSum()
    {
        var calc = new ClassLibrary1.Class1();
        Assert.Equal(-5, calc.Add(-2, -3));
    }

    [Fact]
    public void SubstractTwoNumber_ReturnsDifference()
    {
        var calc = new ClassLibrary1.Class1();
        Assert.Equal(2, calc.Subtract(5, 3));
    }

    [Fact]
    public void SubstractNegetiveNumbers_ReturnSum()
    {
        var clac = new ClassLibrary1.Class1();
        Assert.Equal(1, clac.Subtract(-2, -3));
    }

    [Fact]
    public void MultiplyTwoNumber_RuturnsProduct()
    {
        var calc = new ClassLibrary1.Class1();
        Assert.Equal(15, calc.Multiply(5, 3));
    }
    [Fact]
    public void MultiplyWithNegetiveNumber_ReturnNegetiv()
    {
        var calc = new ClassLibrary1.Class1();
        Assert.Equal(-15, calc.Multiply(-5, 3)); 
    }

    [Fact]
    public void DivideTwoNumbers_ReturnsQuotient()
    {
        var calc = new ClassLibrary1.Class1();
        Assert.Equal(2, calc.Divide(6, 3));
    }

    [Fact]
    public void DivideDecimalNumbers_ReturnResult()
    {
        var calc = new ClassLibrary1.Class1();
        Assert.Equal(2.5, calc.Divide(5, 2));
    }

    [Fact]
    public void DivideByZero_ThrowsException()
    {
        var calc = new ClassLibrary1.Class1();

        /// vi förvänta oss ett dividByZeroException om man försöker dela med 0
        Assert.Throws<DivideByZeroException>(() => calc.Divide(5, 0));
    }
}
