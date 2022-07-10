using System;

namespace reverse_string
{
    class Program
    {
        static string Reverse(string text)
        {
            char[] charArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = charArray.Length - 1; i >= 0; i--)
            {
                reverse += charArray[i];
            }
            return reverse;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um texto: ");
            string original = Console.ReadLine();
            string reversed = Reverse(original);
            Console.WriteLine(reversed);
        }
    }
}