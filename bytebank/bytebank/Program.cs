using bytebank;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        ContaCorrente contaDoAndre = new ContaCorrente();
        contaDoAndre.titular = "André Silva";
        contaDoAndre.numero_agencia = 15;
        contaDoAndre.conta = "1010-X";
        contaDoAndre.saldo = 100;

        Console.WriteLine("Saldo da conta do André = R$ " + contaDoAndre.saldo);

        /*Console.WriteLine("Saldo da conta do André = R$ " + contaDoAndre.saldo);

        contaDoAndre.Depositar(100);

        Console.WriteLine("Saldo do André após o depósito R$ " + contaDoAndre.saldo);

        if(contaDoAndre.Sacar(300) == true)
        {
        Console.WriteLine("Saldo do André após o saque R$ " + contaDoAndre.saldo);
        }
        else
        {
            Console.WriteLine("Saldo insuficiente para saque.");
        }*/


        ContaCorrente contaDaMaria = new ContaCorrente();
        contaDaMaria.titular = "Maria Monteiro";
        contaDaMaria.numero_agencia = 17;
        contaDaMaria.conta = "1010-5";
        contaDaMaria.saldo = 350;

        Console.WriteLine("Saldo da conta da Maria = R$ " + contaDaMaria.saldo);

        contaDoAndre.Transferir(50, contaDaMaria);

        Console.WriteLine("Saldo da conta do André após a transferência = R$ " + contaDoAndre.saldo);
        Console.WriteLine("Saldo da conta da Maria após receber a transferência = R$ " + contaDaMaria.saldo);


    }
}

