using System;

class Program
{
    static void Main() {
        Console.WriteLine("Digite um valor: ");
        int numero = int.Parse(Console.ReadLine());
        int sla = 0;
        Console.WriteLine("Até a tabuada de: ");
        int tab = int.Parse(Console.ReadLine());
        while (sla != tab){
            sla += 1;
            Console.WriteLine(sla + " x " + numero + " = " + sla*1);
        }
            
    }
}