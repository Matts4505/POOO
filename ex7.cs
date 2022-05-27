using System;

class Program
{
    static void Main() {
        int a,b,c;
    Console.WriteLine("Digite o a o b e o c da equacao em uma mesma linha: ");
        string[] texto = Console.ReadLine().Split();
                 a = int.Parse(texto[0]);
                 b = int.Parse(texto[1]);
                 c = int.Parse(texto[2]);
        double delta = (b * b) - (4 * a * c);
        double raiz = Math.Sqrt(delta);
        var x1 = ((-(b)) + raiz) / (2 * a);
        var x2 = ((-(b)) - raiz) / (2 * a);
        Console.WriteLine("Valor de X': " + x1);
        Console.WriteLine("Valor de X'': " +  x2);
    }
}