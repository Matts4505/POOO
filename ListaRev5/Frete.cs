using System;

class Program
{
    static void Main() {
    Console.WriteLine("---------------------------------------");
    Console.WriteLine("| Preço Por Massa == R$1 - 1Kh        |");
    Console.WriteLine("| Preço Por Distância == R$10 - 1Km   |");
    Console.WriteLine("---------------------------------------");
    Console.WriteLine("|Digite aqui a Massa a ser carregada:");
    double m = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite aqui a distância: ");
    double d = double.Parse(Console.ReadLine());
        volume(m,d);

    }
    
    static void volume(double n1, double n2){
        double precom =  n1 * 1;
        double precod =  n2 * 10;
        Console.WriteLine(" O Valor Cobrado Para Carregar A Massa é == R$ " + n1);
        Console.WriteLine("    ");
        Console.WriteLine(" O Valor Cobrado Pela Distância Do Destino é == R$ " + n2);
        Console.WriteLine("    ");
        Console.WriteLine(" A soma total é igual  a == R$ " + (precom + precod));
    }
}