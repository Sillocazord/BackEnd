
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Games.Classes;

List<Jogos> estoqueJogos = new List<Jogos>();

int responda;
do
{

Jogos Personal = new Jogos("",0f,"",0f);
    Console.WriteLine(@$"Da uma olhada denovo e me diz oque quer fazer:
-1 Cadastrar Jogos
-2 Listar Jogos
-0 Sair
(use numeros para responder, 0, 1 ou 2)");
responda = int.Parse(Console.ReadLine()!);
Console.WriteLine($"");
Console.WriteLine($"");



    if (responda == 1){
    Console.WriteLine($"Informe o nome do jogo");
    Personal.nome = Console.ReadLine()!;

    Console.WriteLine($"Informe o Ano de lançamento");
    Personal.lancamento = float.Parse(Console.ReadLine()!);

    Console.WriteLine($"Informe o Gênero do jogo");
    Personal.genero = Console.ReadLine()!;

    Console.WriteLine($"Informe o preço (somente os dois primeiros digitos)");
    Personal.preco = float.Parse(Console.ReadLine()!);
    Console.WriteLine($"");
    Console.WriteLine($"");
    estoqueJogos.Add(Personal);
    Console.WriteLine($"");
    
    }
    else if ( responda == 2)
    {
        Console.WriteLine(@$"Exibindo..."
        );

        foreach (var jogo in estoqueJogos)
{
    Console.WriteLine(@$"Jogos: {jogo.nome}
    {jogo.lancamento}
    {jogo.genero}
    {jogo.preco}");
    Console.WriteLine($"");
    
    
}
    } else {
    Console.WriteLine($"Bye bye🗿");
    
}
} while ( responda != 0);