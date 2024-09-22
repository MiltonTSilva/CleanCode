using CleanCode.Interfaces;

namespace CleanCode.Domain.Strategy;
public class DescontoOuro : ICalculadoraDesconto
{
    public decimal AplicarDesconto(decimal preco)
    {
        return preco - (Constantes.DESCONTO_OURO * preco);
    }
}