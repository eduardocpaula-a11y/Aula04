public static class Exercicio2
{
public static void Executar()
{ 
Console.Write("Informe a temperatura em Celcius (*C): ");
double celsius = double.Parse(Console.ReadLine()!);

// TODO: corrigir o cálculo abaixo (bug) 
double fahrenheit = celsius * 9/5 + 32;

Console.WriteLine($"Temperatura em Farenheit (*F): {fahrenheit:F2}");
}
}