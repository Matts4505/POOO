using System;

public class MainClass {
  public static void Main(string[] args) {
      double a,b,c,maior,menor,soma;
    Console.WriteLine("Digite um numero:");
    a = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite outro: ");
    b = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite outro: ");
    c = double.Parse(Console.ReadLine());
    maior = 0;
    menor = 1;
    if (a>b && a>c) maior=a;
    else if (b>c && b>a) maior =b;
    else maior =c;
    if (a<b && a<c) menor=a;
    else if (b<c && b<a) menor =b;
    else menor =c;
    
    soma = maior + menor;
    Console.WriteLine("A soma do menor valor com o maior é " + soma);
  }
}
