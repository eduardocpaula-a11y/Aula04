public static class Exercicio4
{
    public static void Executar()
    {
        // 1. Criando as variáveis e recebendo valores do teclado
        Console.Write("Digite o valor de x: ");
        int x = int.Parse(Console.ReadLine()!);
 
        Console.Write("Digite o valor de y: ");
        int y = int.Parse(Console.ReadLine()!);
 
        // Exibindo valores antes da troca
        Console.WriteLine("\nAntes da troca:");
        Console.WriteLine("x = " + x);
        Console.WriteLine("y = " + y);
 
        // 2. Fazendo a troca usando variável auxiliar
        int temp = x; // guarda o valor de x
        x = y;        // x recebe o valor de y
        y = temp;     // y recebe o valor original de x
 
        // Exibindo valores depois da troca
        Console.WriteLine("\nDepois da troca:");
        Console.WriteLine("x = " + x);
        Console.WriteLine("y = " + y);
    }
}