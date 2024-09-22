using CleanCode.Interfaces;

namespace CleanCode.Domain.Strategy;
public class DescontoEspecial : ICalculadoraDesconto
{
    public decimal AplicarDesconto(decimal preco)
    {
        return preco - (Constantes.DESCONTO_ESPECIAL * preco);
    }
}
