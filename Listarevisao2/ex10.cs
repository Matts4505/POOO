using System;

class Program
{
    static void Main() {
        int dia,mes,ano;
    Console.WriteLine("Digite uma data (ano com 4 digitos) ex 00/00/0000  :");
        string[] texto = Console.ReadLine().Split("/");
                 dia = int.Parse(texto[0]);
                 mes = int.Parse(texto[1]);
                 ano = int.Parse(texto[2]);
        if (dia>0 && dia<31 && mes > 0 && mes <13 &&  ano<2101 && ano>1900) Console.WriteLine("E uma data valida!!!");
        else Console.WriteLine("Nao e uma data valida!!!");
  }
}