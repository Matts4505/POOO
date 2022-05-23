using System;

class Program
{
    static void Main() {
        int a,b,c,maior,menor,meio;
        Console.WriteLine("Digite 3 valores:");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        c = int.Parse(Console.ReadLine());
        if (a>b && a>c) maior = a;
        else if (b>a && b>c) maior = b;
        else maior = c;
        if (a<b && a<c) menor = a;
        else if (b<a && b<c) menor = b;
        else menor = c;
        if (maior = a && menor = c) medio = b;
        else if (maior = b && menor =c) medio = a;
        else if (maior = a && menor =b) medio = c;
        Console.WriteLine(maior + ", " + medio + ", " + menor);
  }
}