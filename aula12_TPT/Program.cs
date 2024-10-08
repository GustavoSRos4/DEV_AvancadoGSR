using System.Linq;

namespace aula12_TPT
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                //add pessoa
                context.Pessoas.Add(new Aluno { Nome = "João", Matricula = "123" });
                context.Pessoas.Add(new Professor { Nome = "Maria", Disciplina = "Matemática" });
                context.SaveChanges();

                //Consulta dados

                var pessoas = context.Pessoas.ToList();
                foreach (var p in pessoas)
                {
                    System.Console.WriteLine($"Id: {p.Id} - Nome: {p.Nome}");
                }
            }

        }
    }
}