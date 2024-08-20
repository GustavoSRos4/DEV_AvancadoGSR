public struct PessoaStruct
{
    private string nomeStruct = "";

    public PessoaStruct(string nomeStruct)
    {
        NomeStruct = nomeStruct;
    }

    public string NomeStruct
    {
        get { return nomeStruct; }
        set { nomeStruct = value; }
    }

    public override string ToString()
    {
        return $"Nome: {nomeStruct}";
    }
}