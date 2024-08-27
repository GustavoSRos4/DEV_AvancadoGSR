using System;
public class Program
{
    //Delegates
    public delegate void ExibirNumero(int numero);


    //Funções
    public static void imprimeNumero(int numero)
    {
        Console.WriteLine("O Numero é : " + numero);
    }

    public static void ExibirQuadrado(int numero)
    {
        Console.WriteLine("O Quadrado do numero é : " + numero * numero);
    }
    //main
    public static void Main()
    {
        ExibirNumero delegateTeste = imprimeNumero;
        delegateTeste += ExibirQuadrado;

        delegateTeste += delegate (int numero)
        {
            Console.WriteLine("O Cubo do numero é : " + numero * numero * numero);
        };

        delegateTeste(10);

    }

}
