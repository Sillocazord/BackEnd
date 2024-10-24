// See https://aka.ms/new-console-template for more information
using System.Net.Mail;

Console.WriteLine(@$"
 --------------------------------------
|         Bem vindo ao programa        |
|              Contador                |
|                 De                   |
|               Pessoas                |
 --------------------------------------
");

int ContadorM = 0;
int ContadorMS = 0;
int ContadorMN = 0;

int ContadorF = 0;
int ContadorFS = 0;
int ContadorFN = 0;

int ContadorS = 0;
int ContadorN = 0;

Console.WriteLine(@$"Hoje estamos colhendo dados acerca de um produto lançado, por favor, solicitamos que informe os dados solicitados abaixo.");


for (int entrevistados = 0; entrevistados <= 9; entrevistados++){

    Console.WriteLine(@$"Informe o seu sexo(Masculino = m ; Feminino = f)");
    string sexo = Console.ReadLine()!;

    if (sexo == "m") {
        ContadorM++;

        Console.WriteLine($@"Informe se gostou ou não do nosso produto (s ou n)");
        string resposta = Console.ReadLine()!;

        if (resposta == "s"){
            ContadorMS++;
            ContadorS++;
        } else {
            ContadorMN++;
            ContadorN++;
        }

    } else {
        ContadorF++;

        Console.WriteLine($@"Informe se gostou ou não do nosso produto (s ou n)");
        string resposta = Console.ReadLine()!;

        if (resposta == "s"){
            ContadorFS++;
            ContadorS++;
        } else {
            ContadorFN++;
            ContadorN++;
        }
    }

}
    int porcentagemM = 100 / ContadorM * ContadorMN;
    Console.WriteLine(@$"Obrigado por fornecer os dados, exibindo resultados... (e comprando um Corsa no seu nome)");

    Console.WriteLine(@$"Numero de pessoas entrevistadas : 10");
    Console.WriteLine(@$"Entrevistados masculinos : {ContadorM}");
     Console.WriteLine(@$"Entrevistados femininos : {ContadorF}");
      Console.WriteLine(@$"Entrevistados que responderam Sim : {ContadorS}");
      Console.WriteLine(@$"Mulheres entrevistadas que responderam sim : {ContadorFS}");
       Console.WriteLine(@$"Porcentagem de homens entrevistados que responderam não : {porcentagemM}");