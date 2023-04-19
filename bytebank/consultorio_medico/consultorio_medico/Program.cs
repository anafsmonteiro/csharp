

using consultorio_medico;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Pessoa paciente = new Pessoa();
        paciente.nome = "Ana Sousa";
        paciente.idade = 25;
        paciente.altura = 1.60;
        paciente.peso = 79.5;

        Console.WriteLine($"Nome do paciente: {paciente.nome} \nIdade do paciente: {paciente.idade} \nAltura: {paciente.altura} \nPeso: {paciente.peso}");

    }
}