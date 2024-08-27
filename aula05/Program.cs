public class Program
{
    public static void Main(String[] args)
    {
        //faça uma conversao de dados explicita e outra implicita e uma usando o Convert, e imprima o resultado de cada um
        //conversao implicita
        int a = 10;
        double b = a;
        Console.WriteLine($"Conversao implicita, int {a} -> double {b}");

        //conversao explicita
        double c = 10.5;
        int d = (int)c;
        Console.WriteLine($"Conversao explicita, double {c} -> int {d}");

        //conversao com Convert
        string e = "10";
        int f = Convert.ToInt32(e);
        Console.WriteLine($"Conversao com Convert, string {e} -> int {f}");

        //conversao com o Parse
        string g = "10";
        int h = int.Parse(g);
        Console.WriteLine($"Conversao com Parse, string {g}  -> int {h}");

    }
}