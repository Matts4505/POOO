using System;

class Program
{
    static void Main() {
        int a,b,c,d,par,impar;
    Console.WriteLine("Digite 4 numeros em uma mesma linha: ");
        string[] texto = Console.ReadLine().Split();
                 a = int.Parse(texto[0]);
                 b = int.Parse(texto[1]);
                 c = int.Parse(texto[2]);
                 d = int.Parse(texto[3]);
        par = 0;
        impar = 0 ;
        if (a%2 == 0) par = par + a;
        if (b%2 == 0) par = par + b;
        if (c%2 == 0) par = par + c;
        if (d%2 == 0) par = par + d;
        if (a%2 == 1) impar = impar + a;
        if (b%2 == 1) impar = impar + b;
        if (c%2 == 1) impar = impar + c;
        if (d%2 == 1) impar = impar + d;
        Console.WriteLine("Soma dos pares: " + par);
        Console.WriteLine("Soma dos impares: " +  impar);
    }
}