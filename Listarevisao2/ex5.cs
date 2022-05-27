using System;

public class MainClass {
  public static void Main(string[] args) {
      int u;
    Console.WriteLine("Digite um numero que corresponde a um mês do ano: ");
    u = int.Parse(Console.ReadLine());
    if (u == 1) Console.WriteLine("Janeiro é do primeiro timestre"); 
    else if (u == 2)Console.WriteLine("Fevereiro é do primeiro timestre ");
    else if (u==3)Console.WriteLine("Março é do primeiro timestre");
    else if (u==4)Console.WriteLine(" Maio é do segundo timestre");
    else if (u==5) Console.WriteLine(" Abril é do segundo timestre");
    else if(u==6)Console.WriteLine("Junho é do segundo timestre");
    else if(u==7)Console.WriteLine("Julho é do terceiro timestre");
    else if(u==8)Console.WriteLine("Agosto é do terceiro timestre");
    else if(u==9)Console.WriteLine("Setembro é do terceiro timestre");
    else if(u==10)Console.WriteLine("Outubro é do quarto timestre");
    else if(u==11)Console.WriteLine("Novembro é do quarto timestre");
    else if(u==12)Console.WriteLine("Dezembro é do quarto timestre");
    else Console.WriteLine("Ops!!! Esse mês é inválido!!!");
  }
}