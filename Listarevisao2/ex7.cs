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
        if (x1 > -1000000 && x1 <1000000 && x2 > -1000000 && x2 <1000000)Console.WriteLine(" O Valor de X' é = " + x1 + " e o valor de X'' é = " + x2);
        else Console.WriteLine("Impossivel calcular!!!");
        
    }
}