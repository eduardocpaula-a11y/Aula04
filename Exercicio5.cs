public static class Exercicio5
{
    public static void Executar()
    {
        // Entradas
        Console.Write("Digite o valor da venda: ");
        double valorVenda = double.Parse(Console.ReadLine()!);

        Console.Write("Digite a quantidade vendida: ");
        int quantidade = int.Parse(Console.ReadLine()!);

        Console.Write("Digite o percentual de comissão (%): ");
        double percentualComissao = double.Parse(Console.ReadLine()!);

        Console.Write("Digite o salário fixo: ");
        double salarioFixo = double.Parse(Console.ReadLine()!);

        // Cálculos
        double totalVendido = valorVenda * quantidade;
        double comissao = totalVendido * (percentualComissao / 100.0);
        double totalReceber = salarioFixo + comissao;

        // Saídas com 2 casas decimais
        Console.WriteLine("\n--- Resultado ---");
        Console.WriteLine($"Total vendido: {totalVendido:F2}");
        Console.WriteLine($"Comissão: {comissao:F2}");
        Console.WriteLine($"Total a receber: {totalReceber:F2}");
    }
}