class Program
{
    public static void Main(string[] args)
    {
        Cliente c1 = new Cliente(1, "Gustavo");
        Cliente c2 = new Cliente(2, "Ana");

        Produtos p1 = new Produtos(1, "Caneta", 2.3m);
        Produtos p2 = new Produtos(2, "Lápis", 1.0m);
        Produtos p3 = new Produtos(3, "Borracha", 3.95m);
        Produtos p4 = new Produtos(4, "Caderno", 10m);

        Compra compra1 = new Compra(c1);
        compra1.adicionarproduto(p1);
        compra1.adicionarproduto(p4);

        Compra compra2 = new Compra(c2);
        compra2.adicionarproduto(p2);
        compra2.adicionarproduto(p3);

        Console.WriteLine(compra1);
        Console.WriteLine(compra2);

    }
}