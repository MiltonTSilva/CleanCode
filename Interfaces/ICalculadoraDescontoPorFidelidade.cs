namespace CleanCode.Interfaces;

public interface ICalculadoraDescontoPorFidelidade
{
    decimal CalcularDesconto(decimal precoProduto, int tempoDaContaEmAnos);
}