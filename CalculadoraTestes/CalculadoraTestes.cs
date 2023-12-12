using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTestes
{
    private CalculadoraImp _calc;

    public CalculadoraTestes()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void SomarNUmTest() // deve somar 10 com 5 e retornar 15
    {
        // Arrange
        int num1 = 10;
        int num2 = 5;
        
        // Act
        int resultado = _calc.Somar(num1, num2);

        // Assert
        Assert.Equal(15, resultado);

    }

    [Fact]
    public void SomarNUmTest2() // deve somar 10 com 10 e retornar 20
    {
        // Arrange
        int num1 = 10;
        int num2 = 10;
        
        // Act
        int resultado = _calc.Somar(num1, num2);

        // Assert
        Assert.Equal(20, resultado);
    }


    // [Theory] // testando varios numeros no mesmo metodo
    // [InlineData(2)]
    // [InlineData(4)]
    // [InlineData(6)]
    // [InlineData(8)]
    // [InlineData(10)]
    // public void SomarNUmTest3( int numero) // deve verificar se é PAR, deve setar (int numero)
    // {
    //     // Act
    //     bool resultado = _calc.EhPar(numero);
    //     // Assert
    //     Assert.True(resultado);
    // }


    [Theory] // testando varios numeros no mesmo metodo
    [InlineData(new int[] { 2, 4})]
    [InlineData(new int[] { 6, 8, 10})]
    public void SomarNUmTest3( int[] numeros) // deve verificar se é PAR, deve setar (int numero)
    {
        // Act / Assert

        Assert.All(numeros, num => Assert.True(_calc.EhPar(num)));
        
        // foreach (var item in numeros)
        // {
        //     Assert.True(_calc.EhPar(item));      //*Pode ser feito dessa maneira também
        // }
    }
}