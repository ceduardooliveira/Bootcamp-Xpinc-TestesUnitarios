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
}