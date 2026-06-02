namespace Comum.Financeiro;

public static class PoliticaArredondamento
{
    public static decimal Arredondar()
    {
        return Math.Round(valor, 2, MidpoinRouding.AwayFromZero);
    }
    
}