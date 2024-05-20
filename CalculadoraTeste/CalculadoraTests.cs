using Calculadora.Services;

namespace CalculadoraTeste;


public class CalculadoraTests
{
    private CalculadoraImp _calc;

    public CalculadoraTests()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    // Deve somar 5 com 10 e retornar 5
    public void TestSomar()
    {
        //Arrange
        int num1 = 5;
        int num2 = 10;

        //Act
        int result = _calc.Somar(num1, num2);

        //Assert
        // Equal(15, result) primeiro argumento o resultado esperado, segundo argumento o valor de retorno 
        Assert.Equal(15, result);
    }
}