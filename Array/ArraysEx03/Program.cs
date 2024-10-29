// See https://aka.ms/new-console-template for more information
int []temperatura = new int[12];

for ( int i = 0; i < temperatura.Length; i++){
    Console.WriteLine($@"Insira abaixo a temperatura de cada mes do { i + 1}:");

    temperatura[i] = int.Parse(Console.ReadLine()!);
}
int maiortemperatura = temperatura.Max();
int menortemperatura = temperatura.Min();

Console.WriteLine($@"Maior temperatura foi = { maiortemperatura}");
Console.WriteLine($@"Menor temperatura foi = {menortemperatura}");


