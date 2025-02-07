using Calculator;

namespace Tests;

public class SimpleCalculatorTest
{
    [Test]
    public void Add()
    {
        // Arrange
        var calc = new SimpleCalculator();
        var a = 2;
        var b = 3;
        
        // Act
        var result = calc.Add(a, b);
        
        // Assert
        Assert.That(result, Is.EqualTo(5));
    }
    
    [Test]
    public void Subtract()
    {
        // Arrange
        var calc = new SimpleCalculator();
        var a = 5;
        var b = 3;
    
        // Act
        var result = calc.Subtract(a, b);
    
        // Assert
        Assert.That(result, Is.EqualTo(2));
    }

    [Test]
    public void Multiply()
    {
        // Arrange
        var calc = new SimpleCalculator();
        var a = 5;
        var b = 3;
    
        // Act
        var result = calc.Multiply(a, b);
    
        // Assert
        Assert.That(result, Is.EqualTo(15));
    }

    [Test]
    public void Divide()
    {
        // Arrange
        var calc = new SimpleCalculator();
        var a = 15;
        var b = 3;
    
        // Act
        var result = calc.Divide(a, b);
    
        // Assert
        Assert.That(result, Is.EqualTo(5));
    }

    [Test]
    public void Factorial()
    {
        // Arrange
        var calc = new SimpleCalculator();
        var n = 5;
    
        // Act
        var result = calc.Factorial(n);
    
        // Assert
        Assert.That(result, Is.EqualTo(120));
    }

    [Test]
    public void IsPrime()
    {
        // Arrange
        var calc = new SimpleCalculator();
        var candidate = 7;
    
        // Act
        var result = calc.IsPrime(candidate);
    
        // Assert
        Assert.That(result, Is.True);
    }

    [Test]
    public void IsPrime_False()
    {
        // Arrange
        var calc = new SimpleCalculator();
        var candidate = 9;
    
        // Act
        var result = calc.IsPrime(candidate);
    
        // Assert
        Assert.That(result, Is.False);
    }

    [Test]
    public void IsPrime_Invalid()
    {
        // Arrange
        var calc = new SimpleCalculator();
        var candidate = 1;
    
        // Act
        var result = calc.IsPrime(candidate);
    
        // Assert
        Assert.That(result, Is.False);
    }
}