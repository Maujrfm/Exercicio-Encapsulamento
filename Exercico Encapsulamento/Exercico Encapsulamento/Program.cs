using System;
using System.Globalization;
namespace Exercico_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c;

            Console.WriteLine("Entre com o Numero da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre o Titular da conta: ");
            string titular = Console.ReadLine();
            Console.WriteLine("Haverá deposito incial? (s/n)");
            char depi = char.Parse(Console.ReadLine());
            if (depi == 's' || depi == 'S')
            {
                Console.WriteLine("Entre o valor de deposito inicial: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c = new Conta(conta, titular, saldo);
            }
            else
            {
                double saldo = 0.00;
                c = new Conta(conta, titular, saldo);
            }
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(c);
            Console.WriteLine();
            Console.WriteLine("Entre com um valor para deposito: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.DepositoConta(valor);
            Console.WriteLine("Dados Atualizados: ");
            Console.WriteLine(c);
            Console.WriteLine("Entre com um valor para Saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.SaqueConta(valor);
            Console.WriteLine("Dados Atualizados: ");
            Console.WriteLine(c);
        }
    }
}
