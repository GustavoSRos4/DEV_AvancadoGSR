public class Cliente
{
    private int id;
    private string nome;

    public Cliente(int id, string nome)
    {
        Id = id;
        Nome = nome;
    }

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public override string ToString()
    {
        return $"Nome: {nome ?? "Sem nome"}, Id: {id}";
    }
}