using System;
using Xunit;
namespace ClassLibrary1.Tests;

/// <summary>
/// dessa tester kontrollerar att calculator klassen fungerar.
/// vi testar alla tal och specialfall som division med noll
/// syftet är att säkerställa att alla metoder hanterar båda normala och oväntade värden
/// </summary>

public class UnitTest1
{
    private readonly ClassLibrary1.Class1 _calc;
    //kör konstruktorn innan varje test
    public UnitTest1() => _calc = new ClassLibrary1.Class1();

    [Fact]
    public void AddTwoNumbers_ReturnSum()
    {
        //så kan man också göra = var calc = new ClassLibrary1.Class1();
        Assert.Equal(5, _calc.Add(2, 3));
    }

    [Fact]
    public void AddNegetiveNumber_ReturnSum()
    {
        Assert.Equal(-5, _calc.Add(-2, -3));
    }

    [Fact]
    public void SubstractTwoNumber_ReturnsDifference()
    {
        Assert.Equal(2, _calc.Subtract(5, 3));
    }

    [Fact]
    public void SubstractNegetiveNumbers_ReturnSum()
    {
        Assert.Equal(1, _calc.Subtract(-2, -3));
    }

    [Fact]
    public void MultiplyTwoNumber_RuturnsProduct()
    {
        Assert.Equal(15, _calc.Multiply(5, 3));
    }
    [Fact]
    public void MultiplyWithNegetiveNumber_ReturnNegetiv()
    {
        Assert.Equal(-15, _calc.Multiply(-5, 3)); 
    }

    [Fact]
    public void DivideTwoNumbers_ReturnsQuotient()
    {
        Assert.Equal(2, _calc.Divide(6, 3));
    }

    [Fact]
    public void DivideDecimalNumbers_ReturnResult()
    {
        Assert.Equal(2.5, _calc.Divide(5, 2));
    }

    [Fact]
    public void DivideByZero_ThrowsException()
    {

        /// vi förvänta oss ett dividByZeroException om man försöker dela med 0
        Assert.Throws<DivideByZeroException>(() => _calc.Divide(5, 0));
    }
}
