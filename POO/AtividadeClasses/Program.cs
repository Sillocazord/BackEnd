// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;
using AtividadeClasses.Veiculo;

Veiculo carro = new Veiculo();

string carroligado;

Console.WriteLine("Bo montar um carro meu cria");
Console.WriteLine($"Comece informando a marca");
carro.marca =Console.ReadLine()!;

Console.WriteLine($"Informe o modelo");
carro.modelo = Console.ReadLine()!;

Console.WriteLine($"Informe a cor");
carro.cor = Console.ReadLine()!;

Console.WriteLine($"Quantos Horses de potencia?");
carro.potencia = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Quantas portas?");
carro.qtdportas = int.Parse(Console.ReadLine()!);

Console.WriteLine($"E o barlhinho do escapamento meu cria, fica como?");
carro.Acelerar(Console.ReadLine()!);

Console.WriteLine($"O carro ta on?(sim ou nao)");
carroligado = Console.ReadLine()!;
if (carroligado =="sim")
{
    Console.WriteLine($"{carro.Ligar}");

} else if (carroligado == "nao")
{
    Console.WriteLine($"{carro.Desligar}");
    
} else {
    Console.WriteLine($"RESPONDE DIREITO MISERA");
}

Console.WriteLine($"Qual o somzin do freio?");
carro.Freiar(Console.ReadLine()!);

Console.WriteLine($"Certo, vamos exibir os dados colocados.");
Console.WriteLine($"Marca do carro: {carro.marca}");

Console.WriteLine($"Modelo do carro: {carro.modelo}");

Console.WriteLine($"Cor do carro : {carro.cor}");

Console.WriteLine($"Potencia do carro (em horses (cavalos)): {carro.potencia}");

Console.WriteLine($"Quantidades de portas do carro: {carro.qtdportas}");

Console.WriteLine($"Som do acelerador: {carro.Acelerar}");

Console.WriteLine($"Status do carro : {carroligado}");

Console.WriteLine($"Somzinho do carro ao freiar: {carro.Freiar}");
07210000