
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Games.Classes;

List<Jogos> estoqueJogos = new List<Jogos>();



Console.WriteLine($"Bem vindo ao site de cadastros!");

Jogos CallOfDuty = new Jogos("Call of Duty", 2014 ,"acao" , 23);
Jogos ApexLegends = new Jogos("Apex Legends", 2019 ,"Battle Royale" , 00);
Jogos Splinter = new Jogos("Splinter Cell Blacklist", 2013 ,"Stealth" , 69);
Jogos Rising = new Jogos("Metal Gear Rising: Revengeance", 2013 ,"Hack and Slash" , 39);
Jogos Personal = new Jogos(Console.ReadLine()!,float.Parse(Console.ReadLine()!),Console.ReadLine()!,float.Parse(Console.ReadLine()!));
CallOfDuty.ExibirDados();
Console.WriteLine($"");
ApexLegends.ExibirDados();
Console.WriteLine($"");
Splinter.ExibirDados();
Console.WriteLine($"");
Rising.ExibirDados();
Console.WriteLine($"");

estoqueJogos.Add(CallOfDuty);
estoqueJogos.Add(ApexLegends);
estoqueJogos.Add(Splinter);
estoqueJogos.Add(Rising);

foreach (var jogo in estoqueJogos)
{
    Console.WriteLine($"Jogos: {jogo.nome}");
    
}

Console.WriteLine(@$"Baseado nesse exemplo, decida oque quer fazer:
-1 Cadastrar Jogos
-2 Listar Jogos
-0 Sair
(use numeros para responder, 0, 1 ou 2)");

int responda = int.Parse(Console.ReadLine()!);

do
{

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
    
    

    Console.WriteLine(@$"Exibindo...
    {Personal.ExibirDados}
    ");

    estoqueJogos.Add(Personal);}
    else if ( responda == 2)
    {
        Console.WriteLine(@$"Exibindo..."
        );

        foreach (var jogo in estoqueJogos)
{
    Console.WriteLine($"Jogos: {jogo.nome}");
    
}
        
    }
} while ( responda == 3);