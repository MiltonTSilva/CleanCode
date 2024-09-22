using CleanCode.Interfaces;

namespace CleanCode.Domain.Strategy;

public class DescontoVip : ICalculadoraDesconto
{
    public decimal AplicarDesconto(decimal preco)
    {
        return preco - (Constantes.DESCONTO_VIP * preco);
    }
}