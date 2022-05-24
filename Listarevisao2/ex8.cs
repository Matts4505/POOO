using System;

public class MainClass {
  public static void Main(string[] args) {
      double a,b,c,d,maior,menor,soma;
    Console.WriteLine("Digite um numero:");
    a = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite outro: ");
    b = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite outro: ");
    c = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite outro,por fim.");
    d = double.Parse(Console.ReadLine());
    maior = 0;
    menor = 1;
    if (a>b && a>c && a>d) maior=a;
    else if (b>c && b>a && b>d) maior =b;
    else if (c>a && c>b && c>d) maior =c;
    else maior =d;
    if (a<b && a<c && a<d) menor=a;
    else if (b<c && b<a && b<d) menor =b;
    else if (c<a && c<b && c<d) menor =c;
    else menor =d;
    
    
    soma = maior + menor;
    Console.WriteLine("Maior= " + maior + " e o Menor = " + menor);
    Console.WriteLine("A soma do menor valor com o maior é " + soma);
  }
}