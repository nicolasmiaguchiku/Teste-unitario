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
        // Equal(15, result) primeiro argumento o resultado esperado, segundo argumento o resultado do metodo
        Assert.Equal(15, result);
    }

    [Fact]
    public void TestEhPar()
    {
        //Arrange
        int num = 2;

        //ACT
        bool result = _calc.EhPar(num);

        //Assert
        Assert.True(result);
    }

    // [Theory]
    // [InlineData(2)]
    // [InlineData(4)]
    // [InlineData(6)]
    // [InlineData(8)]
    // [InlineData(10)]
    // public void TestTheoryEhPar(int num)
    // {
    //     //ACT 
    //     bool result = _calc.EhPar(num);

    //     //Assert
    //     Assert.True(result);
    // }


    [Theory]
    [InlineData(new int[] {2,4})]
    [InlineData(new int[] {6,8,10})]
    public void TestArrayEPar(int[] numeros)
    {
        //Act e Assert
        Assert.All(numeros, num => Assert.True(num));
    }
}