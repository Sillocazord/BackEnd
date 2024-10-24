// See https://aka.ms/new-console-template for more information
using System.Runtime.Intrinsics.Arm;

Console.WriteLine("Insira as medidas dos lados de um triangulo, e eu vou determinar se é equilatero, isosceles ou escaleno");
int lado1 = int.Parse (Console.ReadLine());
int lado2 = int.Parse (Console.ReadLine());
int lado3 = int.Parse (Console.ReadLine());

if (lado1 == lado2 && lado2 == lado3 && lado3 == lado1) {

Console.WriteLine($"Resultado: Triangulo equilatero, {lado1} - {lado2} - {lado3}");

} else if (lado1 != lado2 && lado2 == lado3) {
    Console.WriteLine($"Resultado:Triangulo isóscele, -{lado1} - {lado2} - {lado3}");
    
} else if (lado1 != lado2 && lado2 != lado3 && lado3 != lado1) {
    Console.WriteLine($"Resultado: Triangulo Escaleno, -{lado1} - {lado2} - {lado3}");
    
} else if (lado2 == lado3 && lado3 != lado1) {
    Console.WriteLine($"Resultado:Triangulo isóscele, -{lado1} - {lado2} - {lado3}");

} else if (lado1 == lado2 && lado2 != lado3 && lado3 != lado1) {
    Console.WriteLine($"Resultado:Triangulo isóscele, -{lado1} - {lado2} - {lado3}");
} else {
    Console.WriteLine($"faz o negocio direito");
    
}
    
