using bytebank;
using bytebank.Contas;
using bytebank.Titular;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * ContaCorrente contaDoAndre = new ContaCorrente();
          contaDoAndre.titular = "André Silva";
          contaDoAndre.numero_agencia = 15;
          contaDoAndre.conta = "1010-X";
          contaDoAndre.saldo = 100;
          contaDoAndre.ExibirDadosDaConta();


          Console.WriteLine("Saldo da conta do André = R$ " + contaDoAndre.saldo);

        Console.WriteLine("Saldo da conta do André = R$ " + contaDoAndre.saldo);

        contaDoAndre.Depositar(100);

        Console.WriteLine("Saldo do André após o depósito R$ " + contaDoAndre.saldo);

        if(contaDoAndre.Sacar(300) == true)
        {
        Console.WriteLine("Saldo do André após o saque R$ " + contaDoAndre.saldo);
        }
        else
        {
            Console.WriteLine("Saldo insuficiente para saque.");
        }


        ContaCorrente contaDaMaria = new ContaCorrente();
        contaDaMaria.titular = "Maria Monteiro";
        contaDaMaria.numero_agencia = 17;
        contaDaMaria.conta = "1010-5";
        contaDaMaria.saldo = 350;

        Console.WriteLine("Saldo da conta da Maria = R$ " + contaDaMaria.saldo);

        contaDoAndre.Transferir(50, contaDaMaria);

        Console.WriteLine("Saldo da conta do André após a transferência = R$ " + contaDoAndre.saldo);
        Console.WriteLine("Saldo da conta da Maria após receber a transferência = R$ " + contaDaMaria.saldo);*/

        /* Tipagem por Valor
          
        double valor = 300;
        double valor2 = valor;

        Console.WriteLine(valor==valor2); */

        /* Cliente cliente = new Cliente();
         cliente.nome = "Ana Monteiro";
         cliente.cpf = "11122233344";
         cliente.profissao = "DEV";


         ContaCorrente conta = new ContaCorrente();
         conta.titular = cliente;
         conta.conta = "1010-X";
         conta.numero_agencia = 15;
         conta.saldo = 100;

         conta.ExibirDadosDaConta();

         ContaCorrente conta2 = new ContaCorrente();
         conta2.titular = new Cliente();
         conta2.titular.nome = "Flavia de Sousa";
         conta2.titular.cpf = "12345678911";
         conta2.titular.profissao = "Analista";
         conta2.conta = "9992-2";
         conta2.numero_agencia = 18;
         conta2.saldo = 300;

         conta2.ExibirDadosDaConta();*/

        //ContaCorrente conta3 = new ContaCorrente();
        //conta3.Numero_agencia = 18;
        //conta3.SetSaldo(200);
        //conta3.Conta = "1011-H";
        //Console.WriteLine(conta3.GetSaldo());
        //Console.WriteLine(conta3.Numero_agencia);
        //Console.WriteLine(conta3.Conta);


        //    ContaCorrente conta4 = new ContaCorrente(18,"1010-X");
        //    conta4.SetSaldo(500);
        //    conta4.Titular = new Cliente();

        //    Console.WriteLine(conta4.GetSaldo());
        //    Console.WriteLine(conta4.Numero_agencia);


        //ContaCorrente conta5 = new ContaCorrente(283, "1234-x");
        //Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

        //ContaCorrente conta6 = new ContaCorrente(284, "9876-5");
        //Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

        //ContaCorrente conta7 = new ContaCorrente(284, "9876-5");
        //Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
    }


}

