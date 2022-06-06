using System;

class Program
{
    static void Main() {
    int qtd,a,b;

        Console.WriteLine("Digite a  quantidade de Valores:");
        qtd = int.Parse(Console.ReadLine());
        for(int qtd=1 ; qtd <=10; qtd++){
            Console.WriteLine("Digite dois valores em mesma linha: ");
            string[] texto = Console.ReadLine().Split(" ");
            a = int.Parse(texto[0]);
            b = int.Parse(texto);
            int divisao = (a/b);
            Console.WriteLine("Divisão = " + divisao);

        }
    }
}