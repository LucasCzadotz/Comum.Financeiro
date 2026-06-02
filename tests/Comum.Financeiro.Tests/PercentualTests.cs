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

    [Fact]
    public void DeveConverterParaFatorDeDesconto()
    {
        var percentual = Percentual.De(10m);
        var fator = percentual.ComFatorDeDesconto();

        Assert.Equal(0.90m, fator);
    }

    [Fact]
    public void DeveConverterParaFatorDeAcrescimo()
    {
        var percentual = Percentual.De(10m);
        var fator = percentual.ComFatorDeAcrescimo();
        
        Assert.Equal(1.10m, fator);
    }
}