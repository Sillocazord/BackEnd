

Console.WriteLine($"Informe seu salario");
float salario = float.Parse (Console.ReadLine());

Console.WriteLine($"Informe seus gastos");
float gastos = float.Parse ( Console.ReadLine());

if( gastos <= salario){
    Console.WriteLine($"Pelo visto esta tudo nos conformes");
    
} else {
    Console.WriteLine($"Voce faliu");
    
}


