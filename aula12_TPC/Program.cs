using System.Linq;

namespace aula12_TPC
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
                context.Alunos.Add(new Aluno { Nome = "João", Matricula = "123" });
                context.Professores.Add(new Professor { Nome = "Maria", Disciplina = "Matemática" });
                context.SaveChanges();

                //Consulta dados

                var alunos = context.Alunos.ToList();
                foreach (var p in alunos)
                {
                    System.Console.WriteLine($"Id: {p.Id} - Nome: {p.Nome}");
                }

                var professores = context.Professores.ToList();
                foreach (var p in professores)
                {
                    System.Console.WriteLine($"Id: {p.Id} - Nome: {p.Nome}");
                }
            }

        }
    }
}