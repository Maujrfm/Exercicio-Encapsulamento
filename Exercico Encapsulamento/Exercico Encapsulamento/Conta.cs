using System;
using System.Globalization;

namespace Exercico_Encapsulamento
{
    class Conta
    {
        public int NumeroConta { get; private set; }
        public String Titular { get; set; }
        public double Saldo { get; private set; }

        public Conta(int numeroconta, string titular)
        {
            NumeroConta = numeroconta;
            Titular = titular;
        }

        public Conta(int numeroconta, string titular, double saldo) : this(numeroconta, titular)
        {
            DepositoConta(saldo);
        }


        public void DepositoConta(double valor)
        {
            Saldo += valor;
        }

        public void SaqueConta(double valor)
        {
            Saldo -= valor + 5.00;

        }

        public override string ToString()
        {
            return "Conta: " + NumeroConta.ToString("D4") + ", Titular: "
                + Titular + ", Saldo: $"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
