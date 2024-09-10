class Produtos
{
    private int id;
    private string nome;
    private decimal preco;

    public Produtos(int id, string nome, decimal preco)
    {
        Id = id;
        Nome = nome;
        Preco = preco;
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

    public decimal Preco
    {
        get { return preco; }
        set { preco = value; }
    }

    public override string ToString()
    {
        return $"Nome: {nome ?? "Sem nome"}, Id: {id}, Preço: {preco}";
    }

}