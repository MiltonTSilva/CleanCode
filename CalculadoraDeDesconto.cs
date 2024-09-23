namespace CleanCode;
public class CalculadoraDeDesconto
{
    public decimal CalcularDesconto(decimal precoDoProduto,
                                    StatusDaConta statusDaConta,
                                    int tempoDaContaEmAnos)
    {
        decimal precoDepoisDoDesconto = 0;

        decimal percentualDoDescontoPorFidelidade = (tempoDaContaEmAnos > Constantes.DESCONTO_MAXIMO_POR_FIDELIDADE) ?
                                                   (decimal)Constantes.DESCONTO_MAXIMO_POR_FIDELIDADE / 100 :
                                                   (decimal)tempoDaContaEmAnos / 100;

        switch (statusDaConta)
        {
            case StatusDaConta.Padrao:
                precoDepoisDoDesconto = precoDoProduto;
                break;
            case StatusDaConta.Especial:
                precoDepoisDoDesconto = CalcularPrecoDepoisDoDesconto(precoDoProduto,
                                                                  Constantes.DESCONTO_ESPECIAL,
                                                                  percentualDoDescontoPorFidelidade);
                break;
            case StatusDaConta.Ouro:
                precoDepoisDoDesconto = CalcularPrecoDepoisDoDesconto(precoDoProduto,
                                                                  Constantes.DESCONTO_OURO,
                                                                  percentualDoDescontoPorFidelidade);
                break;
            case StatusDaConta.Vip:
                precoDepoisDoDesconto = CalcularPrecoDepoisDoDesconto(precoDoProduto,
                                                                  Constantes.DESCONTO_VIP,
                                                                  percentualDoDescontoPorFidelidade);
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
        return precoDepoisDoDesconto;
    }

    public decimal CalcularPrecoDepoisDoDesconto(decimal precoDoProduto,
                                                 decimal percentualDesconto,
                                                 decimal percentualDoDescontoPorFidelidade)
    {
        decimal precoComDesconto = precoDoProduto - (percentualDesconto * precoDoProduto);
        return precoComDesconto - (percentualDoDescontoPorFidelidade * precoComDesconto);
    }
}