

//ALT SHIFT + F --> IDENÇÃO
using System;
namespace Aula01Variaveis //Namespace SPACE É O ENDEREÇO DE ONDE A CLASSE ESTÁ CONTIDA, E DEVE TER O MESMO NOME QUE O PROJETO (.csproj)
{


    public class Program
    {
        static void Main(string[] args)
        {
            // ConcatenarPalavras();
            // CalcularMedia();
            CalcularTabuada();

        }

        public static void CalcularTabuada()
        {
            Console.WriteLine("Digite a tabuada que deseja calcular: ");
            int tabuada = int.Parse(Console.ReadLine());
            int contador = 0;

            while (contador <= 10)
            {
                string mensagem = string.Format("{0} X {1} = {2}", tabuada, contador, tabuada * contador);
                Console.WriteLine(mensagem);
                contador++;
            }


        }


        public static void CalcularMedia()
        {
            Console.WriteLine("Digite a primeira nota:");
            decimal nota1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota:");
            decimal nota2 = decimal.Parse(Console.ReadLine());

            decimal media = (nota1 + nota2) / 2;
            Console.WriteLine($"A média foi de: {media}");

            if (media > 7)
                Console.WriteLine("Aprovado");
            else if (media < 7 && media >= 4)
                Console.WriteLine("Esta de recuperação");
            else
                Console.WriteLine("Reprovado");

        }
        public static void ConcatenarPalavras()
        {
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            string frase1 = $"Olá {nome}, hoje é {DateTime.Now}";
            Console.WriteLine(frase1);

            Console.WriteLine("===========================");

            Console.WriteLine("Quanto custa um dólar em reais?");
            decimal ValorDolarReais = decimal.Parse(Console.ReadLine());
            string frase2 = string.Format("Hoje é {0:dd/MM/yyyy}, o dólar está custando {1:c2}", DateTime.Now, ValorDolarReais);
            Console.WriteLine(frase2);

            Console.WriteLine("===========================");

            string cabecalho = string.Format("{0:dddd}, {0:dd} de {0:MMMM} de {0:yy} - {0:HH:mm:ss}", DateTime.Now);
            Console.WriteLine(cabecalho);
        }




    }
}