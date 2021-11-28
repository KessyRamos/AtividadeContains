using System;

namespace AtividadeContains
{
    class Program
    {  
        static void Main(string[] args)
        {
            ContainsLetra();
            Console.WriteLine("");
            ContainsNome();
        }
        private static void ContainsLetra()
        {
            string nomes = "Kessy";
            bool letra = nomes.Contains('K');

            Console.WriteLine("O nome é o seguinte: Kessy");
            Console.WriteLine($"Existe a letra K no nome?");
            Console.Write($"Resposta: {letra}");
        }
        private static void ContainsNome()
        {
            string frase = "Ontem fui ao comercio!";
            string palavra = "mercado";
            bool resposta = frase.Contains(palavra);

            Console.WriteLine("A frase é a seguinte: Ontem fui ao comercio! ");
            Console.WriteLine("Existe a palavra MERCADO na frase?");
            Console.Write( $"Resposta: {resposta}");
        }
        
    }
}
