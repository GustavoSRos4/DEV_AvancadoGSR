use System;

class Program{
    static List<Pessoa> pessoas = new List<Pessoa>();

    static void Main(string[] args){
        console.Write("Inserir Pessoa na Lista!");
        pessoas.add(new Pessoa("Gustavo", 20));

        foreach(Pessoa aux in pessoas) {
            Console.write("oi")
        }     
    }
}