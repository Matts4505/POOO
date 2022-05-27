using System;

class Program
{
    static void Main() {
        int um,dois,tres,quatro,cinco,seis,sete,oito,nove,dez,maior;
    Console.WriteLine("Digite 10 numeros em sequencia:");
        string[] texto = Console.ReadLine().Split();
                 um = int.Parse(texto[0]);
                 dois = int.Parse(texto[1]);
                 tres = int.Parse(texto[2]);
                 quatro = int.Parse(texto[3]);
                 cinco = int.Parse(texto[4]);
                 seis = int.Parse(texto[5]);
                 sete = int.Parse(texto[6]);
                 oito = int.Parse(texto[7]);
                 nove = int.Parse(texto[8]);
                 dez = int.Parse(texto[9]);
                 maior = 0;
        if (um>dois && um>tres && um>quatro && um>cinco && um>seis && um>sete && um>oito && um>nove && um>dez) maior=um;
        else if (dois>um && dois>tres && dois>quatro && dois>cinco && dois>seis && dois>sete && dois>oito && dois>nove && dois>dez) maior=dois;
        else if (tres>um && tres>dois && tres>quatro && tres>cinco && tres>seis && tres>sete && tres>oito && tres>nove && tres>dez) maior=tres;
        else if (quatro>um && quatro>dois && quatro>tres && quatro>cinco && quatro>seis && quatro>sete && quatro>oito && quatro>nove && quatro>dez) maior=quatro;
        else if (cinco>um && cinco>dois && cinco>tres && cinco>quatro && cinco>seis && cinco>sete && cinco>oito && cinco>nove && cinco>dez) maior = cinco;
        else if (seis>um && seis>dois && seis>tres && seis>quatro && seis>cinco && seis>sete && seis>oito && seis>nove && seis>dez) maior = seis;
        else if (sete>um &&sete>dois && sete>tres && sete>quatro && sete>cinco && sete>seis && sete>oito && sete>nove && sete>dez) maior = sete;
        else if (oito>um && oito>dois && oito>tres && oito>quatro && oito>cinco && oito>seis && oito>sete && oito>nove && oito>dez) maior = oito;
        else if (nove>um && nove>dois && nove>tres && nove>quatro && nove>cinco && nove>seis && nove>sete && nove>nove && nove>dez) maior = nove;
        else maior = dez;
        
        Console.WriteLine("O maior é: " + maior);
  }
}