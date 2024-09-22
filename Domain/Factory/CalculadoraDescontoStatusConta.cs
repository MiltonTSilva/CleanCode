using CleanCode.Domain.Strategy;
using CleanCode.Interfaces;

namespace CleanCode.Domain.Factory;
public class CalculadoraDescontoStatusConta : ICalculadoraDescontoStatusConta
{
    public ICalculadoraDesconto GetCalculoDescontoStatusConta(StatusDaConta statusDaConta)
    {
        ICalculadoraDesconto calcular;

        switch (statusDaConta)
        {
            case StatusDaConta.Padrao:
                calcular = new DescontoPadrao();
                break;
            case StatusDaConta.Especial:
                calcular = new DescontoEspecial();
                break;
            case StatusDaConta.Ouro:
                calcular = new DescontoOuro();
                break;
            case StatusDaConta.Vip:
                calcular = new DescontoVip();
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
        return calcular;
    }
}