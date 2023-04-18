
using menorpreco;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        EstoqueProdutos bolachaRecheada = new EstoqueProdutos();
        bolachaRecheada.nome = "Richester";
        bolachaRecheada.fabricante = "Fabrica Fortaleza";
        bolachaRecheada.codigo = "12A152S3";
        bolachaRecheada.valorUni = 1.00;
        bolachaRecheada.valorCompra = 2.50;
        bolachaRecheada.quantidadeEmEstoque = 100;

        Console.WriteLine(bolachaRecheada.fabricante);
    }
}