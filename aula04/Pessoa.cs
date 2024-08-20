class Pessoa
{
    private string nome = "";

    public Pessoa(string nome)
    {
        Nome = nome;
    }

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }



    public override string ToString()
    {
        return $"Nome: {nome ?? "Sem nome"}";
    }

}