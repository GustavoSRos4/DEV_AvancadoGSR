using System;
using System.Collections.Generic;
using System.Linq;

//where

public class Program
{
    public static void Main(String[] args)
    {
        List<int> numeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        List<int> numerosPares = numeros.Where(n => n % 2 == 0).ToList();

        Console.WriteLine("Numeros pares:");
        numerosPares.ForEach(n => Console.WriteLine(n));

        //ordenando a lista de frutas por ordem alfabética
        List<string> frutas = new List<string>() { "banana", "maçã", "abacaxi", "uva", "laranja" };
        List<string> frutasOrdenadas = frutas.OrderBy(f => f).ToList();
        List<string> frutasComM = frutas.Where(f => f.StartsWith("M")).ToList();

        Console.WriteLine("Frutas ordenadas:");
        frutasComM.ForEach(f => Console.WriteLine(f));
    }
}