using System;

class Program
{
    static void Main() {
        double hora,minuto,angulo,anguloo;
        Console.WriteLine("Digite um valor em hora. Ex.: 00:00");
        string[] texto = Console.ReadLine().Split(":");
                 hora = double.Parse(texto[0]);
                 minuto = double.Parse(texto[1]);
                 angulo = hora*30 ;
                 anguloo = angulo -5.5* minuto;
        Console.WriteLine("Ângulo é: " + (anguloo*-1));
  }
}