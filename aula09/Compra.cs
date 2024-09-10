class Compra
{
    public Cliente Cliente { get; set; }
    public List<Produtos> Produtos { get; set; }

    public Compra(Cliente cliente)
    {
        Cliente = cliente;
        Produtos = new List<Produtos>();
    }

    public void adicionarproduto(Produtos produto)
    {
        Produtos.Add(produto);
    }

    public decimal CalcTotal()
    {
        return Produtos.Sum(p => p.Preco);
    }

    public override string ToString()
    {
        string produtosList = string.Join(", ", Produtos.Select(p => p.Nome));
        return $"Compra de {Cliente.Nome}, Produtos: [{produtosList}], Total: {CalcTotal():c}";
    }
}