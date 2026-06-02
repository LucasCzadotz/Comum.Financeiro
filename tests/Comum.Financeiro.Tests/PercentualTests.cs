using Comum.Financeiro;
namespace Comum.Financeiro.Tests

public class PercentualTests
{
    [Fact]
    public void DeveCriarPercentual()
    {
        var percentual = Percentual.De(10m);
        Assert.Equal(10m, percentual.Valor);
    }
}