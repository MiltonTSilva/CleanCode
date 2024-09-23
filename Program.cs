using CleanCode;
using CleanCode.Domain;
using CleanCode.Domain.Factory;
using CleanCode.Interfaces;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Calculo feito com a classe código sujo");
Console.WriteLine("--------------------------------------");

calc1 calc = new();

Console.WriteLine("      ");
Console.WriteLine("Tipo 1");
Console.WriteLine("------");
Console.WriteLine("      ");
Console.WriteLine(calc.calculos(1000, 1, 3));

Console.WriteLine("      ");
Console.WriteLine("Tipo 2");
Console.WriteLine("------");
Console.WriteLine("      ");
Console.WriteLine(calc.calculos(1000, 2, 3));

Console.WriteLine("      ");
Console.WriteLine("Tipo 3");
Console.WriteLine("------");
Console.WriteLine("      ");
Console.WriteLine(calc.calculos(1000, 3, 3));

Console.WriteLine("      ");
Console.WriteLine("Tipo 4");
Console.WriteLine("------");
Console.WriteLine("      ");
Console.WriteLine(calc.calculos(1000, 4, 3));
Console.WriteLine("      ");

Console.WriteLine("Calculo feito com a classe código limpo");
Console.WriteLine("---------------------------------------");

var serviceProvider = new ServiceCollection()
            .AddScoped<ICalculadoraDescontoStatusConta, CalculadoraDescontoStatusConta>()
            .AddScoped<ICalculadoraDescontoPorFidelidade, CalculadoraDescontoPorFidelidade>()
            .AddScoped<CalculadoraDeDesconto>()
            .BuildServiceProvider();

var calculadoraDeDesconto = serviceProvider.GetService<CalculadoraDeDesconto>()
    ?? throw new InvalidOperationException("A instância de CalculadoraDeDesconto não pôde ser criada.");

decimal precoProduto = 1000m;
int tempoDeContaEmAnos = 3;

decimal precoComDesconto = calculadoraDeDesconto.AplicarDesconto(precoProduto,
                                    StatusDaConta.Padrao, tempoDeContaEmAnos);
Console.WriteLine($"\nCliente Padrao - Preco com Desconto: {precoComDesconto:C}");

precoComDesconto = calculadoraDeDesconto.AplicarDesconto(precoProduto,
                                    StatusDaConta.Especial, tempoDeContaEmAnos);
Console.WriteLine($"\nCliente Especial - Preco com Desconto: {precoComDesconto:C}");

precoComDesconto = calculadoraDeDesconto.AplicarDesconto(precoProduto,
                                    StatusDaConta.Ouro, tempoDeContaEmAnos);
Console.WriteLine($"\nCliente Ouro - Preco com Desconto: {precoComDesconto:C}");

precoComDesconto = calculadoraDeDesconto.AplicarDesconto(precoProduto,
                                    StatusDaConta.Vip, tempoDeContaEmAnos);
Console.WriteLine($"\nCliente VIP - Preco com Desconto: {precoComDesconto:C}");

Console.ReadKey();