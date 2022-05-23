using System;

class Program
{
    static void Main() {
        int a,b,c,d,media;
        Console.WriteLine("Primeiro numero:");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Segundo numero:");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("Terceiro numero:");
        c = int.Parse(Console.ReadLine());
        Console.WriteLine("Quarto numero:");
        d = int.Parse(Console.ReadLine());
        media = (a+b+c+d)/4;
        Console.WriteLine("Media == " + media);
        if (a>b && a>c && a>d) Console.WriteLine("O maior é " +a);
        else if (b>a && b>c && b>d) Console.WriteLine("O maior é " + b);
        else if (c>a && c>b && c>d) Console.WriteLine("O maior é " + c);
        else if (d>a && d>c && d>b) Console.WriteLine("O maior é " + d);
        else Console.WriteLine("São valores identicos");
        Console.WriteLine("Numeros menores que a media:");
        if (a<media) Console.WriteLine(" " + a);
        if (b<media) Console.WriteLine(" " + b);
        if (c<media) Console.WriteLine(" " + c);
        if (d<media) Console.WriteLine(" " + d);
        Console.WriteLine("Numeros maioress que a media:");
        if (a>media) Console.WriteLine(" " + a);
        if (b>media) Console.WriteLine(" " + b);
        if (c>media) Console.WriteLine(" " + c);
        if (d>media) Console.WriteLine(" " + d);
    }
}