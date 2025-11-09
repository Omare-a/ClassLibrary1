using System;
using Xunit;

namespace ClassLibrary1.Tests;
/// Tester för Class1 (Calculator): vi täcker +, -, *, / inkl. negativa tal,
/// double-division med precision, felhantering vid division med noll,
/// EXTRA: Square och Power.


public class UnitTest2
{
    private readonly ClassLibrary1.Class1 _calc;

    public UnitTest2() => _calc = new ClassLibrary1.Class1();

    // [Theory] en testmetod som kan köras flera gånger med olika indata.
    //[InlineData(...)] = anger en konkret uppsättning argument som skickas till testmetoden för ett körningsfall.
    [Theory]
    [InlineData(2, 3, 5)]
    [InlineData(-2, -3, -5)]
    [InlineData(-2, 3, 1)]
    [InlineData(0, 0, 0)]
    public void Add_ShouldReturnExpectedSum(int a, int b, int expected)
    {
        var result = _calc.Add(a, b);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(5, 3, 2)]
    [InlineData(-2, -3, 1)]
    [InlineData(3, 5, -2)]
    public void Subtract_ShouldReturnExpectedDifference(int a, int b, int expected)
    {
        var result = _calc.Subtract(a, b);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(5, 3, 15)]
    [InlineData(-5, 3, -15)]
    [InlineData(-5, -3, 15)]
    [InlineData(5, 0, 0)]
    public void Multiply_ShouldReturnExpectedProduct(int a, int b, int expected)
    {
        var res = _calc.Multiply(a, b);
        Assert.Equal(expected, res);
    }

    // --- Divide (double) ---
    [Theory]
    [InlineData(6, 3, 2.0)]
    [InlineData(5, 2, 2.5)]
    [InlineData(-9, 4, -2.25)]
    public void Divide_WithValidDivisor_ShouldReturnExpectedQuotient(double a, double b, double expected)
    {
        var res = _calc.Divide(a, b);
        Assert.Equal(expected, res, precision: 5);
    }

    [Fact]
    public void Divide_ByZero_ShouldThrow()
    {
        Assert.Throws<DivideByZeroException>(() => _calc.Divide(5, 0));
    }

    // --- EXTRA: Square ---
    [Theory]
    [InlineData(0, 0)]
    [InlineData(2, 4)]
    [InlineData(-3, 9)]
    public void Square_ShouldReturnExpectedValue(int n, int expected)
    {
        var res = _calc.Square(n);
        Assert.Equal(expected, res);
    }

    // --- EXTRA: Power ---
    [Theory]
    [InlineData(2, 0, 1)]
    [InlineData(2, 3, 8)]
    [InlineData(-2, 3, -8)]
    [InlineData(-2, 2, 4)]
    public void Power_WithNonNegativeExponent_ShouldReturnExpected(int @base, int exponent, int expected)
    {
        var res = _calc.Power(@base, exponent);
        Assert.Equal(expected, res);
    }

    [Fact]
    public void Power_WithNegativeExponent_ShouldThrow()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => _calc.Power(2, -1));
    }

}


