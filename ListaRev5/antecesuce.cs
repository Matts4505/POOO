using System;

class Program
{
    static void Main() {
    Console.WriteLine("Digite um número: ");
    int n1 = int.Parse(Console.ReadLine());
        antsuc(n1);

    }
    static void antsuc(double n1){
        Console.WriteLine("Sucessor é = " + (n1+1) + " , já o Antecessor é = " + (n1-1));
        
    }
}