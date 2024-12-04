using System;

class Program
{
    static void Main()
    {
        // Leitura do valor de dias
        int dias = int.Parse(Console.ReadLine());
        
        // Cálculo dos anos, meses e dias
        int anos = dias / 365;  // Divisão para obter o número de anos
        dias %= 365;  // Restante de dias após calcular os anos
        
        int meses = dias / 30;  // Divisão para obter o número de meses
        dias %= 30;  // Restante de dias após calcular os meses
        
        // Imprimir o resultado
        Console.WriteLine($"{anos} ano(s)");
        Console.WriteLine($"{meses} mes(es)");
        Console.WriteLine($"{dias} dia(s)");
    }
}