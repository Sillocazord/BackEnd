int[] numeros = new int[6];
int par = 0;
int impar = 0;

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Digite um {i + 1} número");
    int numerosDigitado = int.Parse(Console.ReadLine()!);

    if(numerosDigitado % 2 == 0){
        par++;
    }else{
        impar++;
    }
}

Console.WriteLine($"Quantidade de números pares: {par}");
for (int i = 0; i < numeros.Length; i++)
{
    if ( numeros[i] % 2 == 0)
    {
        Console.WriteLine($@"{numeros[i]}");
        
    }
}

Console.WriteLine($"Quantidade de números ímpares: {impar}");
for (int i = 0; i < numeros.Length; i++){
    if (numeros[i] % 1 == 0)
    {
        Console.WriteLine($"{numeros[i]}");
        
    }
}

