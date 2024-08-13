public class Program{
    public static void Main(string[] args){
        Console.WriteLine("Cadastro de Pessoa!");
        Console.WriteLine("Digite o nome: ");
        string? NomeP = Console.ReadLine();
        Console.WriteLine("Digite a idade: ");
        int? IdadeP = int.Parse(Console.ReadLine());


        Pessoa p1 = new Pessoa(NomeP, IdadeP);
        Pessoa p2 = new Pessoa("João", 20);

        Console.WriteLine(p1);
        Console.WriteLine(p2);
    }
}
