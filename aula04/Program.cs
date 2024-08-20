class Program
{
    public static void Main(string[] args)
    {
        Pessoa objPessoa = new Pessoa("Gustavo");
        Console.WriteLine("Antes do metodo (Classe)" + objPessoa.ToString());
        AlteraNomeClasse(objPessoa);
        Console.WriteLine("Depois do metodo (Classe)" + objPessoa.ToString());

        PessoaStruct pessoaStruct = new PessoaStruct("RafaelDoGrau");
        Console.WriteLine("Antes do metodo (Struct)" + pessoaStruct.ToString());
        AlteraNomeStruct(pessoaStruct);
        Console.WriteLine("Depois do metodo (Struct)" + pessoaStruct.ToString());

    }

    public static void AlteraNomeClasse(Pessoa objAux)
    {
        objAux.Nome = "Danielly";
    }

    public static void AlteraNomeStruct(PessoaStruct objAux)
    {
        objAux.NomeStruct = "Rafael Do Grau";
    }
}