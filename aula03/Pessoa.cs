class Pessoa
{
    private string nome = string.Empty;
    private int idade;

    public string Nome(
        get{return nome;}
        set{nome = val;}
    )

    public int Idade(
        get{return idade;}
        set{idade = val;}
    )

    public Pessoa(string nome, int idade){
        Nome = nome;
        Idade = idade;
    } 

    public override string ToString()
    {
        return $"Nome: {nome ?? "Sem nome"}, Idade: {idade ?? 0}";
    }
}
