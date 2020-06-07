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
        double saldo;
        double tarifa;

        public void depositar(double pValor)
        {
            valor = pValor;
            saldo += valor;
        }

        public void sacar(double pValor)
        {
            valor = pValor;

            double sacar = valor - saldo - tarifa;
            if(sacar < saldo){
                Console.WriteLine("Saldo insulficiente");
            }
        }

        public double getSaldo() { return saldo; }
    }

    class contaPoupanca : Conta
    {
        double valor;
        double saldo;

        public void depositar(double pValor){
            valor = pValor;
            saldo += valor;
        }

        public void sacar(double pValor){
            valor = pValor;
            double sacar = valor - saldo;
            if(sacar < valor){
                Console.WriteLine("Saldo Insulficiente");
            }
            
        }

        public double getSaldo() { return saldo; }
    }

    class geradorDeExtrato
    {
        
    }
}