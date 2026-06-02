namespace Comum.Financeiro;

public sealed class Percentual
{
    public decimal Valor {get;}

    private Percentual(decimal valor)
    {
        if (valor < 0)
        {
            throw new ValorFinanceiroInvalidoException("Percentual não pode ser negativo");
        }
        Valor = valor;

        public decimal ComFatorDeDesconto()
        {
            return 1 - (Valor / 100m);
        }

        public decimal ComFatorDeAcrescimo()
        {
            return 1 + (Valor / 100m);
        }
        
        public override string ToString()
        {
            return $"{valor}%";
        }
    }
}