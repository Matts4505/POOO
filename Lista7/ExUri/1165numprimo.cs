using System;

class Program
{
    static void Main() {
    Console.WriteLine("Digite um valor: ");
    int um = int.Parse(Console.ReadLine());
    Console.WriteLine("Agora digite outro valor: ");
    int dois = int.Parse(Console.ReadLine());
    Console.WriteLine("Agora um último  valor: ");
    int tres = int.Parse(Console.ReadLine());
        primo(um);
        primo(dois);
        primo(tres);

    }
    
    static void primo(int n1){
        if (n1%2 != 0 || n1%3 != 0 || n1%5 != 0  || n1%7 != 0  || n1%11 != 0 || n1%13 != 0 ) Console.WriteLine(n1 + " não é primo !!! !!!");
    }
}