using System;

class Program
{
    static void Main() {
        int a,b,c,maior,menor,meio;
        Console.WriteLine("Primeiro numero: ");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Segundo numero: ");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("Terceiro numero: ");
        c = int.Parse(Console.ReadLine());
        maior = 1;
        menor = 0;
        meio = 0;
        if (a>b && a>c) a=maior;
        if (b>a && b>c) b=maior;
        if (c>a && c>b) c=maior;
        if (a<b && a<c) a=menor;
        if (b<a && b<c) b=menor;
        if (c<a && c<b) c=menor;
        if (a != menor && a != maior) a = meio;
        if (b != menor && b != maior) b = meio;
        if (c != menor && c != maior) c = meio;
        Console.WriteLine(maior + "," + meio + "," + menor);
        
        
  }
}