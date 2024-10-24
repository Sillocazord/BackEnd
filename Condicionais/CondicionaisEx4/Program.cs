
Console.WriteLine("Insira a senha");
int senha = int.Parse(Console.ReadLine());
int luck = 1234;
if (senha == luck) {
    Console.WriteLine($"ACESSO LIBERADO");
    
} else {
    Console.WriteLine($"ACESSO NEGADO");
    
}
