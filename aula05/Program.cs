public class Program
{
    public static void Main(String[] args)
    {
        //faça uma conversao de dados explicita e outra implicita e uma usando o Convert, e imprima o resultado de cada um
        //conversao implicita
        int a = 10;
        double b = a;
        Console.WriteLine(b);
        //conversao explicita
        double c = 10.5;
        int d = (int)c;
        Console.WriteLine(d);
        //conversao com Convert
        string e = "10";
        int f = Convert.ToInt32(e);
        Console.WriteLine(f);
    
    }
}