using CleanCode.Interfaces;

namespace CleanCode;
public class CalculadoraDeDesconto
{
    private readonly ICalculadoraDescontoStatusConta _calculadoraDescontoStatusConta;
    private readonly ICalculadoraDescontoPorFidelidade _calculadoraDescontoPorFidelidade;
    public CalculadoraDeDesconto(ICalculadoraDescontoStatusConta calculadoraDescontoStatusConta,
                                 ICalculadoraDescontoPorFidelidade calculadoraDescontoPorFidelidade)
    {
        this._calculadoraDescontoStatusConta = calculadoraDescontoStatusConta;
        this._calculadoraDescontoPorFidelidade = calculadoraDescontoPorFidelidade;
    }

    public decimal AplicarDesconto(decimal precoDoProduto, StatusDaConta statusDaConta, int tempoDaContaEmAnos)
    {

        var calculadoraDesconto = _calculadoraDescontoStatusConta.GetCalculoDescontoStatusConta(statusDaConta);

        var precoComDescontoStatus = calculadoraDesconto.AplicarDesconto(precoDoProduto);

        var precoFinal = _calculadoraDescontoPorFidelidade.CalcularDesconto(precoComDescontoStatus, tempoDaContaEmAnos);

        return precoFinal;
    }
}