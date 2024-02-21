using MyCompany.Intranet.Core.Enums;
using MyCompany.Intranet.Core.Services;
using MyCompany.Intranet.Core.Entities;

namespace MyCompany.Intranet.Tests;

public class BmiServiceShould800
{
    [Fact]
    public void Calculator_WhenSueldoLessThan7735()
    {
        //arrange
        var expected = 19.296;
        var person = new Person { sueldo = 1005 };
        var sut = new ISRService();
        
        //act
        ISR result = sut.Calculator(person);
        
        //Assert
        Assert.Equal(expected, Math.Round(result.Impuestos,3));
    }
    
    [Fact]
    public void Calculator_WhenSueldoThan7735AndLessThan65651()
    {
        //arrange
        var expected = 1893.469;
        var person = new Person { sueldo = 35000 };
        var sut = new ISRService();
        
        //act
        var result = sut.Calculator(person);
        
        //Assert
        Assert.Equal(expected, Math.Round(result.Impuestos,3));
    }
    
    [Fact]
    public void Calculator_WhenSueldoThan65651AndLessThan115376()
    {
        //arrange
        var expected = 7592.303;
        var person = new Person { sueldo = 100000 };
        var sut = new ISRService();
        
        //act
        var result = sut.Calculator(person);
        
        //Assert
        Assert.Equal(expected, Math.Round(result.Impuestos,3));
    }
    [Fact]
    public void Calculator_WhenSueldoThan115375AndLessThan134120()
    {
        //arrange
        var expected = 12245.055;
        var person = new Person { sueldo = 134000 };
        var sut = new ISRService();
        
        //act
        var result = sut.Calculator(person);
        
        //Assert
        Assert.Equal(expected, Math.Round(result.Impuestos,3));
    }
    [Fact]
    public void Calculator_WhenSueldoThan134120AndLessThan160577()
    {
        //arrange
        var expected = 16901.959;
        var person = new Person { sueldo = 160000 };
        var sut = new ISRService();
        
        //act
        var result = sut.Calculator(person);
        
        //Assert
        Assert.Equal(expected, Math.Round(result.Impuestos,3));
    }
    [Fact]
    public void Calculator_WhenSueldoThan160577AndLessThan323862()
    {
        //arrange
        var expected = 46786.082;
        var person = new Person { sueldo = 300000 };
        var sut = new ISRService();
        
        //act
        var result = sut.Calculator(person);
        
        //Assert
        Assert.Equal(expected, Math.Round(result.Impuestos,3));
    }
    [Fact]
    public void Calculator_WhenSueldoThan323862AndLessThan510451()
    {
        //arrange
        var expected = 95933.438;
        var person = new Person { sueldo = 511000 };
        var sut = new ISRService();
        
        //act
        var result = sut.Calculator(person);
        
        //Assert
        Assert.Equal(expected, Math.Round(result.Impuestos,3));
    }
    [Fact]
    public void Calculator_WhenSueldoThan510451AndLessThan974535()
    {
        //arrange
        var expected = 212633.438;
        var person = new Person { sueldo = 900000 };
        var sut = new ISRService();
        
        //act
        var result = sut.Calculator(person);
        
        //Assert
        Assert.Equal(expected, Math.Round(result.Impuestos,3));
    }
    [Fact]
    public void Calculator_WhenSueldoThan974535AndLessThan1299380()
    {
        //arrange
        var expected = 281542.75;
        var person = new Person { sueldo = 1120000 };
        var sut = new ISRService();
        
        //act
        var result = sut.Calculator(person);
        
        //Assert
        Assert.Equal(expected, Math.Round(result.Impuestos,3));
    }
    [Fact]
    public void Calculator_WhenSueldoThan1299380AndLessThan3898140()
    {
        //arrange
        var expected = 917155.125;
        var person = new Person { sueldo = 3000000};
        var sut = new ISRService();
        
        //act
        var result = sut.Calculator(person);
        
        //Assert
        Assert.Equal(expected, Math.Round(result.Impuestos,3));
    }
    [Fact]
    public void Calculator_WhenSueldoThan3898148()
    {
        //arrange
        var expected = 1608173.75;
        var person = new Person { sueldo = 5000000 };
        var sut = new ISRService();
        
        //act
        var result = sut.Calculator(person);
        
        //Assert
        Assert.Equal(expected, Math.Round(result.Impuestos,3));
    }
}