
using System.Security.Cryptography;

Console.WriteLine($"Informe o nome do primeiro time");
string time1 = Console.ReadLine()!;
Console.WriteLine($"Informe o nome do segundo time");
string time2 = Console.ReadLine()!;





Console.WriteLine("Informe os gols do primeiro time");
int placar1 = int.Parse (Console.ReadLine())!;

Console.WriteLine($"Informe os gols do segundo time");
int placar2 = int.Parse (Console.ReadLine())!;

if ( placar1 == placar2 ) {
    Console.WriteLine($"Resultado do jogo: empate");
    
} else if (placar1 > placar2) {
    Console.WriteLine($"Resultado do jogo: Vitoria do {time1}");
    
} else if (placar1 < placar2) {
    Console.WriteLine($"Resultado do jogo: Vitoria do {time2}");
    
}



