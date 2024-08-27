using System;
public class Program
{
    public delegate void Notas(List<double> nota);

    public static void verificarNota(List<double> nota)
    {
        double media = 0;
        foreach (double n in nota)
        {
            //Console.WriteLine(media);
            //Console.WriteLine(n);
            media += n;
        }
        //Console.WriteLine("Média: " + media);

        if (media < 60)
        {
            Console.WriteLine("Reprovado");
        }
        else if (media >= 60)
        {
            Console.WriteLine("Aprovado");
        }
        else
        {
            Console.WriteLine("Erro");
        }

    }
    public static void Main()
    {

        Notas MediaNota = verificarNota;


        Console.WriteLine("Digite o nome do Aluno: ");
        string nome = Console.ReadLine();

        List<double> notalist = new List<double>();
        Pessoa p1 = new Pessoa(nome, notalist);

        bool maisnota = true;
        while (maisnota)
        {
            Console.WriteLine("Digite a nota: ");
            double nota = double.Parse(Console.ReadLine());
            p1.Nota.Add(nota);
            Console.WriteLine("Deseja adicionar mais uma nota? (s/n)");
            string resposta = Console.ReadLine();
            if (resposta == "s")
            {
                maisnota = true;
            }
            else
            {
                maisnota = false;
            }
        }
        Console.WriteLine("Nome: " + p1.Nome);
        Console.WriteLine("Notas: ");
        MediaNota(p1.Nota);
    }

}
