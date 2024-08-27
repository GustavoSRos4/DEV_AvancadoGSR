public class Pessoa
{
    private string nome;
    private List<double> nota;

    public Pessoa(string nome, List<double> nota)
    {
        Nome = nome;
        Nota = nota;
    }

    //faça o get e set
    public string Nome
    {
        get
        {
            return nome;
        }
        set
        {
            nome = value;
        }
    }

    public List<double> Nota
    {
        get
        {
            return nota;
        }
        set
        {
            nota = value;
        }
    }

}