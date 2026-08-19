using System;
using System.Globalization;

namespace Aula01Variaveis
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Observe o menu abaixo e digite o número referente a opção desejada: ");
            Console.WriteLine("1 - Concatenar Palavras");
            Console.WriteLine("2 - Verificar Dia da Semana");
            Console.WriteLine("3 - Calcular Média");
            Console.WriteLine("4 - Calcular Tabuada");
            Console.WriteLine("5 - Detalhar Data");
            Console.WriteLine("6 - Calcular Desconto INSS");

            int opcaoEscolhida = int.Parse(Console.ReadLine());

            switch (opcaoEscolhida)
            {
                case 1:
                    ConcatenarPalavras();
                    break;
                case 2:
                    VerificarDiaDaSemana();
                    break;
                case 3:
                    CalcularMedia();
                    break;
                case 4:
                    CalcularTabuada();
                    break;
                case 5:
                    DetalharData();
                    break;
                case 6:
                    CalcularDescontoINSS();
                    break;
                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }
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

        public static void VerificarDiaDaSemana()
        {
            DayOfWeek dia = DateTime.Now.DayOfWeek;
            Console.WriteLine($"Hoje é: {dia}");

            if (dia == DayOfWeek.Saturday || dia == DayOfWeek.Sunday)
                Console.WriteLine("Fim de semana! Não tem aula na ETEC.");
            else
                Console.WriteLine("É dia de semana, tem aula na ETEC!");
        }

        public static void DetalharData()
        {
            Console.Write("Digite uma data (dd/MM/yyyy): ");
            DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", new CultureInfo("pt-BR"));

            Console.WriteLine($"Dia da semana: {data.ToString("dddd", new CultureInfo("pt-BR"))}");
            Console.WriteLine($"Mês: {data.ToString("MMMM", new CultureInfo("pt-BR"))}");

            if (data.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine($"Hora atual: {DateTime.Now.ToString("HH:mm")}");
            }
        }

        public static void CalcularDescontoINSS()
        {
            Console.Write("Digite o valor do salário: ");
            decimal salario = decimal.Parse(Console.ReadLine());

            decimal aliquota;
            if (salario <= 1621.00m)
                aliquota = 0.075m;
            else if (salario <= 2902.84m)
                aliquota = 0.09m;
            else if (salario <= 4354.27m)
                aliquota = 0.12m;
            else if (salario <= 8475.55m)
                aliquota = 0.14m;
            else
                aliquota = 0.14m;

            decimal desconto = salario * aliquota;
            decimal salarioLiquido = salario - desconto;

            Console.WriteLine($"INSS a pagar: R$ {desconto:F2}");
            Console.WriteLine($"Salário líquido: R$ {salarioLiquido:F2}");
        }
    }
}
