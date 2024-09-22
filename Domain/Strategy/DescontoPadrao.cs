using CleanCode.Interfaces;

namespace CleanCode.Domain.Strategy;
internal class DescontoPadrao : ICalculadoraDesconto
{
    public decimal AplicarDesconto(decimal preco)
    {
        return preco;
    }
}