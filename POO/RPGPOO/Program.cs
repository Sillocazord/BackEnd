using RPGPOO.Classes;
Console.Clear();

Console.WriteLine($"Bem vindo ao nosso RPG Legends!");

Personagem O_Dataminer = new Personagem();

Console.WriteLine($"Informe o nome do seu guri meu cria.");
O_Dataminer.Nome = Console.ReadLine()!;

Console.WriteLine($"Informe agora a idade do {O_Dataminer.Nome}");
O_Dataminer.Idade = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe agora a armadura do {O_Dataminer.Nome}");
O_Dataminer.Armadura = Console.ReadLine()!;

Console.WriteLine($"Informe o nome da IA que te acompanha {O_Dataminer.Nome}.");
O_Dataminer.IA = Console.ReadLine()!;

Console.WriteLine($"Exibindo dados...");
Console.WriteLine($"");

Console.WriteLine($"{O_Dataminer.Nome}");
Console.WriteLine($"{O_Dataminer.Idade}");
Console.WriteLine($"{O_Dataminer.Armadura}");
Console.WriteLine($"{O_Dataminer.IA}");
Console.WriteLine($"");
Console.WriteLine($"");





Console.WriteLine($@"Escolha uma ação:
1- Atacar
2- Defender
3- Restaurar Armadura
");
string resposta = Console.ReadLine()!;

if (resposta == "1")
{
    O_Dataminer.Atacar();
} else if (resposta == "2")
{
    O_Dataminer.Defender();
} else if (resposta == "3")
{
    O_Dataminer.Restaurar();
} else {
    Console.WriteLine($"Respota invalida, do it again");
}
