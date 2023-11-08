using System;

class Program {
    static int CalcRank(int vitorias, int derrotas) {
    int resultado = vitorias - derrotas;
    return resultado;
    }
    static void Main(string[] args) {
            Console.WriteLine("Digite a quantidade de vitórias: ");
    int qtdVitorias = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a quantidade de derrotas: ");
    int qtdDerrotas = int.Parse(Console.ReadLine());
    int rank = CalcRank(qtdVitorias, qtdDerrotas);
    switch (rank) {
        case < 10:
        Console.WriteLine("Seu Rank é Ferro");
            break;
        case < 20:
        Console.WriteLine("Seu Rank é Bronze");
            break;
        case < 50:
        Console.WriteLine("Seu Rank é Prata");
            break;
        case < 80:
        Console.WriteLine("Seu Rank é Ouro");
            break;
        case < 90:
        Console.WriteLine("Seu Rank é Diamante");
            break;
        case < 100:
        Console.WriteLine("Seu Rank é Lendário");
            break;
        case > 100:
        Console.WriteLine("Seu Rank é IMORTAL");
            break;
        default:
        Console.WriteLine("Não foi possível determinar seu rank!");
        break;
    }
    }
}




