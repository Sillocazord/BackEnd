
using PilaresPOO.Classes.Aprendizagem;

Carro carro = new Carro();

carro.marca = "Nissan";
carro.modelo = "Skyline";
carro.cor = "Roxo";
carro.potencia = 150;//horses de potencia
carro.qtdPortas= 3;
Console.WriteLine($"HIHIHIHA");
Console.WriteLine(@$"
Marca: {carro.marca}
Modelo: {carro.modelo}
Cor: {carro.cor}
Potencia: {carro.potencia}
Quantidade de portas: {carro.qtdPortas}
");
carro.Ligar();