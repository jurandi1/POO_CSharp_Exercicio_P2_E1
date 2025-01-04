using POO_CSharp_Exercicio_P2_E1;
using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        //EXERCÍCIO 01:
        //Fazer um programa para ler os valores da largura e altura de um retângulo. Em
        //seguida, mostrar na tela o valor de sua área, perímetro e diagonal.Usar uma classe
        //como mostrado no projeto ao lado.

        Retangulo ret = new Retangulo();

        Console.WriteLine("Entre a largura e altura do retângulo: ");
        ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("AREA = " + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("PERIMETRO = " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("DIAGONAL = " + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

    }
}