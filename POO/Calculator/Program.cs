using Calculator.Classes;
Console.Clear();

Console.WriteLine("Bem vindo ao programa Calculadora Reles Mortal!");
Console.WriteLine("Nos informe o primeiro numero.");

Calculadora digito1 = new Calculadora();
Calculadora digito2 = new Calculadora();

digito1.numero1 = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe o segundo numero.");

digito2.numero2 = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Agora selecione a operaçaõ.(somar,subtrair,multiplicar,dividir)");
string operation = Console.ReadLine()!;
if (operation == "somar")
{
    Calculadora operatio = new Calculadora();
    operatio.Somar();
    Console.WriteLine(@$"Exibindo resultados...
    {operatio.Somar}
    ");
}






