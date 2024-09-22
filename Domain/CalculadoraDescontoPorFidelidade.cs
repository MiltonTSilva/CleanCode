using CleanCode.Interfaces;

namespace CleanCode.Domain;

public class CalculadoraDescontoPorFidelidade : ICalculadoraDescontoPorFidelidade
{
    public decimal CalcularDesconto(decimal precoProduto, int tempoDaContaEmAnos)
    {
        decimal percentualDescontoPorFidelidade =
                (tempoDaContaEmAnos > Constantes.DESCONTO_MAXIMO_POR_FIDELIDADE) ?
                (decimal)Constantes.DESCONTO_MAXIMO_POR_FIDELIDADE / 100 :
                (decimal)tempoDaContaEmAnos / 100;

        var precoComDesconto = precoProduto - (percentualDescontoPorFidelidade * precoProduto);

        return precoComDesconto;
    }
}