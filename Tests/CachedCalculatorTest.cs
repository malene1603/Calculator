using Calculator;

namespace Tests;

public class CachedCalculatorTest
{
    [Test]
    public void Add()
    {
        // Arrange
        var calc = new CachedCalculator();
        var a = 2;
        var b = 3;

        // Act
        var result = calc.Add(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(5));
    }
    
    public void Subtract()
    {
        // Arrange
        var calc = new CachedCalculator();
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
        var calc = new CachedCalculator();
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
        var calc = new CachedCalculator();
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
        var calc = new CachedCalculator();
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
        var calc = new CachedCalculator();
        var candidate = 7;
    
        // Act
        var result = calc.IsPrime(candidate);
    
        // Assert
        Assert.That(result, Is.True);
    }
    
   
    
    public class TestCalculation : CachedCalculator.Calculation
    {
        public TestCalculation(string operation, int a, int? b = null)
            : base(operation, a, b)
        {
        }
    }
    
    [Test]
    public void Constructor_ShouldAssignValuesCorrectly()
    {
        // Arrange
        string expectedOperation = "Add";
        int expectedA = 10;
        int? expectedB = 20;

        // Act
        var calculation = new TestCalculation(expectedOperation, expectedA, expectedB);

        // Assert
        Assert.That(calculation.GetType().GetProperty("A", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(calculation), Is.EqualTo(expectedA));
        Assert.That(calculation.GetType().GetProperty("B", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(calculation), Is.EqualTo(expectedB));
        Assert.That(calculation.GetType().GetProperty("Operation", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(calculation), Is.EqualTo(expectedOperation));
    }

    [Test]
    public void GetKey_ShouldReturnCorrectKey()
    {
        // Arrange
        string operation = "Add";
        int a = 10;
        int? b = 20;
        var calculation = new TestCalculation(operation, a, b);
        string expectedKey = "10Add20";

        // Act
        var key = calculation.GetKey();

        // Assert
        Assert.That(key, Is.EqualTo(expectedKey));
    }
}