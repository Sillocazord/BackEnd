
using System.Diagnostics.Contracts;

Console.WriteLine("Compre umas maças! estamos com uma promoção, se comprar mais de 12 maças, o preço vai de 0,30 para 0,25!");

int compre = int.Parse(Console.ReadLine());
double maças;

if ( compre < 12) {
     maças = 0.30;
    
}else {
    maças = 0.25;
    
}
double valortotal =  maças * compre;

    Console.WriteLine($"Valor total: {valortotal}");