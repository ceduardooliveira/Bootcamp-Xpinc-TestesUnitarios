using Calculadora.Services;

namespace CalculadoraTestes;
public class CalculadoraTests
{
    private CalculadoraImp _calc;

    public CalculadoraTests()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5Com10ERetonar15()
    {
        //Arrange - Montar cenário.
        int num1 = 5;
        int num2 = 10;

        //Act - Chamar o cenário e executar a ação.
        int resultado = _calc.somar(num1, num2);

        //Assert - Validar se tudo isso tem o resultado esperado.
        Assert.Equal(15, resultado);
    }

    [Fact]
    public void DeveSomar10Com10ERetonar20()
    {
        //Arrange - Montar cenário.
        int num1 = 10;
        int num2 = 10;

        //Act - Chamar o cenário e executar a ação.
        int resultado = _calc.somar(num1, num2);

        //Assert - Validar se tudo isso tem o resultado esperado.
        Assert.Equal(20, resultado);
    }

    [Fact]
    public void DeveVerificarSe4EhParERetornarVerdadeiro()
    {
        // Arrange
        int numero = 4;

        // Act
        bool resultado = _calc.EhPar(numero);

        // Assert
        Assert.True(resultado);
    }

    [Theory]
    [InlineData(new int[] { 2, 4})]
    [InlineData(new int[] { 6, 8, 10})]
    public void DeveVerificarOsNumerosSaoParesERetornarVerdadeiro(int[] numeros)
    {
        //Act / Assert

        Assert.All(numeros, num => Assert.True(_calc.EhPar(num)));
    }
}