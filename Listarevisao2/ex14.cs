using System;

class Program
{
    static void Main() {
        int a,b,c,maior,menor,meio,sla;
        Console.WriteLine("Primeiro Lado: ");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Segundo Lado: ");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("Terceiro Lado: ");
        c = int.Parse(Console.ReadLine());
        maior = 0;
        menor = 0;
        meio = 0;
        if (a>b && a>c) a=maior;
        else if (b>a && b>c) b=maior;
        else if (c>a && c>b) c=maior;
        if (a<b && a<c) a=menor;
        else if (b<a && b<c) b=menor;
        else if (c<a && c<b) c=menor;
        if (a != menor && a != maior) a = meio;
        else if (b != menor && b != maior) b = meio;
        else if (c != menor && c != maior) c = meio;
        sla = menor + meio;
        if (sla < maior) Console.WriteLine("Nao forma");
        else   Console.WriteLine("Sim,forma!");
        
        
  }
}