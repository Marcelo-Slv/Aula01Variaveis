using System;
using System.Globalization;

class Program
{
    static void DetalharData()
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

    static void CalcularDescontoINSS()
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

    static void Main()
    {
        DetalharData();
        CalcularDescontoINSS();
    }
}
