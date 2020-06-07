using System;

namespace Lista4_
{
    class Program
    {
        static void Main(string[] args)
        {
            contaCorrente cc = new contaCorrente();
            cc.depositar(1000);
            Console.WriteLine(cc.getSaldo());
            cc.sacar(1000);
            Console.WriteLine(cc.getSaldo());

            contaPoupanca cp = new contaPoupanca();
            cp.depositar(200);
            Console.WriteLine(cp.getSaldo());
            cp.sacar(300);
            Console.WriteLine(cp.getSaldo());

            geradorDeExtrato ge = new geradorDeExtrato();
            ge.GerarExtrato(cc);
            ge.GerarExtrato(cp);
        }
    }
}
