Console.WriteLine(@$"
----------------------------------------
|         Bem vindo ao programa        |
|              Contador                |
|                 De                   |
|               Pessoas                |
----------------------------------------
");

Console.WriteLine($"Quantas pessoas tem na sua mesa?");
int qtdDeEntrevistados = int.Parse (Console.ReadLine()!);


int QtdMulher = 0;
int QtdHomem = 0;
int esporte = 0; //para pessoas que gostam de esporte
int nesporte = 0; //para pessoas que nao gostam de esporte

for (int i =1; i <= qtdDeEntrevistados; i++)
{
    Console.WriteLine($"Qual é o seu sexo ? m/f");
    string sexo = Console.ReadLine()!;
    
    if(sexo == "f"){
        QtdMulher++;
    }else{
        QtdHomem++;
    }
    Console.WriteLine($"Gosta de esportes? (s ou n)");
    string son = Console.ReadLine()!;//son é a variavel em que o usuario vai dizer se gosta ou nao de esporte
    if (son == "s"){
        esporte++;
    } else {
        nesporte++;
    }
}

Console.WriteLine($"Quantidade de Mulheres : {QtdMulher}");
Console.WriteLine($"Quantidade de Homens : {QtdHomem}");
Console.WriteLine($"Total de Entrevistado : {QtdMulher + QtdHomem}");
Console.WriteLine($"Gostam de esporte : {esporte}");
Console.WriteLine($"Não gostam de esportes : {nesporte}");

 int porcentagem = 100 / qtdDeEntrevistados * esporte;
//100 dividido pelo total(/) vezes a quantidade que gosta(*)
 Console.WriteLine($"Porcentagem que gostam: {porcentagem}%");