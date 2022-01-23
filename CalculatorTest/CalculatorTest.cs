using Xunit;

namespace CalculatorTest;

public class CalculatorTest
{
    private static Calculator.Calculator SetupCalculator()
    {
        return new Calculator.Calculator();
    }
    
    [Theory]
    [InlineData(1,2,3)]
    public void Calculator_TestAddMethod(int nbr1, int nbr2, int expected)
    {
        //Arrange
        var calculator = SetupCalculator();
        
        //Act
        var actual = calculator.Add(nbr1, nbr2);

        //Assert
        Assert.Equal(expected, actual);
    }
    
    [Theory]
    [InlineData(3,2,1)]
    public void Calculator_TestSubMethod(int nbr1, int nbr2, int expected)
    {
        //Arrange
        var calculator = SetupCalculator();
        
        //Act
        var actual = calculator.Sub(nbr1, nbr2);

        //Assert
        Assert.Equal(expected, actual);
    }
    
    [Theory]
    [InlineData(10,5,2)]
    public void Calculator_TestDivMethod(int nbr1, int nbr2, int expected)
    {
        //Arrange
        var calculator = SetupCalculator();
        
        //Act
        var actual = calculator.Div(nbr1, nbr2);

        //Assert
        Assert.Equal(expected, actual);
    }
    
    [Theory]
    [InlineData(11,3,33)]
    public void Calculator_TestMulMethod(int nbr1, int nbr2, int expected)
    {
        //Arrange
        var calculator = SetupCalculator();
        
        //Act
        var actual = calculator.Mul(nbr1, nbr2);

        //Assert
        Assert.Equal(expected, actual);
    }
    
    [Theory]
    [InlineData(3,6)]
    public void Calculator_TestFacultyMethod(int nbr1, int expected)
    {
        //Arrange
        var calculator = SetupCalculator();
        
        //Act
        var actual = calculator.Faculty(nbr1);

        //Assert
        Assert.Equal(expected, actual);
    }
    
    // Some test comments
    
}