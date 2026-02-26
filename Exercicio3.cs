public static class Exercicio3
{
    public static void Executar()
    {// Entrada de dados
Console.Write("Digite a distância (km): ");
double distanciakm = Convert.ToDouble (Console.ReadLine());
Console.Write("Digite o consumo do veículo (km/L): ");
double consumoKmPorLitro = Convert.ToDouble (Console.ReadLine());
Console.Write("Digite o preço do combustível (R$/L): ");
double precoLitro = Convert.ToDouble (Console.ReadLine());

// Cálculos
double litros = distanciakm / consumoKmPorLitro;
double custoTotal = litros * precoLitro;
double custoPorkm = custoTotal / distanciakm;

// Saída formatada com 2 casas decimais
Console.WriteLine("\n--- Resultado da Viagem ---");
Console.WriteLine($"Litros necessários: {litros:F2}");
Console.WriteLine($"Custo total: R$ {custoTotal:F2}");
Console.WriteLine($"Custo por km: R$ {custoPorkm:F2}");
}
}