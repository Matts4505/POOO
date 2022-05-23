using System;

class Program
{
    static void Main() {
        int a,b;
        Console.WriteLine("Digite um numero:");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite outro:");
        b = int.Parse(Console.ReadLine());
        if (a>b) Console.WriteLine("O maior é " +a);
        else if (b>a) Console.WriteLine("O maior é " + b);
        else Console.WriteLine("São valores identicos");
    }
}