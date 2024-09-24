using aula10_EF.Models;

class Program
{
    public static void Main(string[] args)
    {
        using (var context = new PessoaContext())
        {
            //Criar datavase se nao existir!!
            context.Database.EnsureCreated();

            //ADD nova pessoa
            var pessoa1 = new Pessoa { Nome = "Gustavo", Idade = 20 };

            context.Pessoas.Add(pessoa1);
            context.SaveChanges();

            //Listar as pessoas cadastradas
            var listaPessoas = context.Pessoas.ToList();
            foreach (var p in listaPessoas)
            {
                Console.WriteLine($"Nome: {p.Nome}, Idade: {p.Idade}");
            }
        }
    }
}
