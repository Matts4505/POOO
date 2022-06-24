using System;

class Program
{
    static void Main() {
        int maior,pos,num;
        maior = 0;
        pos = 0;
        num = 0;
        for(int x = 1; x<=100; x++){
            Console.WriteLine("Digite um valor: ");
            num = int.Parse(Console.ReadLine());
                if (num>maior) maior = num;
                if (num>maior) pos = x; 
        }
        
        Console.Write("Maior: "+ num + "Posicao:" + pos);
    }
}