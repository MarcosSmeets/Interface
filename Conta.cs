using System;

namespace Lista4_
{
    interface Conta
    {
        void depositar(double valor);
        void sacar(double valor);

        double getSaldo();
    }

    class contaCorrente : Conta
    {
        double valor;
        double saldo = 2000;
        double tarifa = 1.50;

        public void depositar(double pValor)
        {
            valor = pValor;
            saldo += valor;
        }

        public void sacar(double pValor)
        {
            valor = pValor;

            saldo = saldo - valor - tarifa;
            if(saldo > 0){
                Console.WriteLine("Saldo insulficiente");
            }
        }

        public double getSaldo() { return saldo; }
    }

    class contaPoupanca : Conta
    {
        double valor;
        double saldo = 100;

        public void depositar(double pValor){
            valor = pValor;
            saldo += valor;
        }

        public void sacar(double pValor){
            valor = pValor;
            saldo = saldo - valor;
            if(saldo > 0){
                Console.WriteLine("Saldo Insulficiente");
            }
            
        }

        public double getSaldo() { return saldo; }
    }

    class geradorDeExtrato
    {
        public void GerarExtrato(Conta c){
            c.getSaldo();
        }
    }
}