using Calculator.Classes;
Console.Clear();

Console.WriteLine("Bem vindo ao programa Calculadora Reles Mortal!");
Console.WriteLine("Nos informe o primeiro numero.");

Calculadora digito1 = new Calculadora();
Calculadora digito2 = new Calculadora();
Calculadora results = new Calculadora();

digito1.numero1 = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe o segundo numero.");

digito2.numero2 = float.Parse(Console.ReadLine()!);

Console.WriteLine(@$"Agora selecione a operaçaõ.
-1 Somar.
-2 Subtrair.
-3 Multiplicar
-4 Dividir.
");
string operation = Console.ReadLine()!;
if (operation == "1")
{
    operation.Somar(digito1, digito2);
}






