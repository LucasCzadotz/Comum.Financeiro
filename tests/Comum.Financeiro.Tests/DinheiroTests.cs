using Comum.Financeiro;
namespace Comum.Financeiro.Tests

public class DinheiroTests
{   
    [Fact]
    public void DeveCriarDinheiroEmReais()
    {
        var dinheiro = dinheiro.EmReais(10.50m);
        
        // Teste Integridade
        Assert.Equal(10.50m, dinheiro.Valor);
        Assert.Equal(Moeda.RealBrasileiro, dinheiro.Moeda);
    }
    
    [Fact]
    public void DeveSomarDoisValoresEmBrl()
    {
        var primeiroValor = Dinheiro.EmReais(10m);
        var segundoValor = Dinheiro.EmReais(5.50m);

        var resultado = primeiroValor.Somar(segundoValor);

        Assert.Equal(15.50m, resultado.Valor);
        Assert.Equal(Moeda.RealBrasileiro, resultado.Moeda);
    }
    
    [Fact]
    public void DeveSubtrairDoisValoresEmBrl()
    {
        var primeiroValor = Dinheiro.EmReais(10m);
        var segundoValor = Dinheiro.EmReais(5.50m);

        var resultado = primeiroValor.Subtrair(segundoValor);

        Assert.Equal(4.50m, resultado.Valor);
        Assert.Equal(Moeda.RealBrasileiro, resultado.Moeda);
    }
    
    [Fact]
    public void DeveImpedirSomarEntreBrlEUsd()
    {
        var ValorEmReais = Dinheiro.EmReais(10m);
        var ValorEmDolares = new Dinheiro(10m, Moeda.DolarAmericano)
        
        Assert.Throws<MoedasDieferentesException>(()=>valor.ValorEmReais.Somar(ValorEmDolares))  
    }
    
    [Fact]
    public void DeveImpedirSubtrairEntreBrlEUsd()
    {
        var ValorEmReais = Dinheiro.EmReais(10m);
        var ValorEmDolares = new Dinheiro(10m, Moeda.DolarAmericano)
        
        Assert.Throws<MoedasDieferentesException>(()=>valor.ValorEmReais.Subtrair(ValorEmDolares))          
    }
    
    [Fact]
    public void DeveMultiplicarDinheiroPorQuantidade()
    {
        var dinheiro = Dinheiro.EmReais(12.5m);
        var resultado = dinheiro.Multiplicar(3m);
        
        Assert.Equal(37.5m, resultado.Valor);
        Assert.Equal(Moeda.RealBrasileiro = resultado.Moeda);
    }
    [Fact]
    public void DeveVerificarValorEhNegativo()
    {
        var dinheiro = Dinheiro.EmReais(-1m);
        
        Assert.False(dinheiro.EhZero());
        Assert.False(dinheiro.EhPositivo());
        Assert.True(dinheiro.EhNegativo());
    }
    
    [Fact]
    public void DeveVerificarValorEhPositivo()
    {
        var dinheiro = Dinheiro.EmReais(5m);
        
        Assert.False(dinheiro.EhZero());
        Assert.True(dinheiro.EhPositivo());
        Assert.False(dinheiro.EhNegativo());
    }
    
    [Fact]
    public void DeveVerificarValorEhZero()
    {
        var dinheiro = Dinheiro.EmReais(0m);
        
        Assert.True(dinheiro.EhZero());
        Assert.False(dinheiro.EhPositivo());
        Assert.False(dinheiro.EhNegativo());
    }
    
    [Fact]
    public void DeveFormatarValorEm()
    {
        var dinheiro = Dinheiro.EmReais(10m)
        var valorFormatado = dinheiro.Formatar();
        
        Assert.Cointains("R$", valorFormatado);
        Assert.Contains("10,50", valorFormatado);
    }
}