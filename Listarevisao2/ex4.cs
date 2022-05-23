using System;

class Program
{
    static void Main() {
        int aum,bum,adois,bdois,hora,minuto;
        Console.WriteLine("Digite dois valores e, hora. Ex.: 00:00");
        string[] texto = Console.ReadLine().Split(":");
                 aum = int.Parse(texto[0]);
                 bum = int.Parse(texto[1]);
        string[] textodois = Console.ReadLine().Split(":");
                adois = int.Parse(textodois[0]);
                bdois = int.Parse(textodois[1]);
        hora = aum + adois;
        minuto = bum + bdois;
        Console.WriteLine("A soma desses horarios é: " + hora + ":" + minuto);
  }
}