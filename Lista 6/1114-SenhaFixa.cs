using System;

class Program
{
    static void Main() {
        int recebe;
        int senha = 2002;
        int recebfinal = 0;
        while(senha != recebfinal){
          Console.WriteLine("Digite uma senha: ");
          recebe = int.Parse(Console.ReadLine());
          recebfinal = recebe;
          if (recebfinal == senha) Console.WriteLine("Senha Correta!!!");
          else Console.WriteLine("Senha Errada!!!");
        }
    }
}