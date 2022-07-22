using System;

class Program
{
    static void Main() {
        Console.WriteLine("Digite uma Frase: ");
        string s =  Console.ReadLine();
        string[] v = s.Split();
        foreach(string p in v)
        Console.WriteLine(p);
    }
}
//int.TryParse verifica se é inteiro
//Try.Parse(Console.ReadLine(),out x) == false)