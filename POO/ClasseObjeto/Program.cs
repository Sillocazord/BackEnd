﻿using ClasseObjeto.Classes;

Animal cachorro = new Animal();

cachorro.nome = "Knor";
cachorro.raca = "Tempero";
cachorro.cor = "Galinha Caipira";
cachorro.idade = 6;

Console.WriteLine($"Nome do cachorrinho:{cachorro.nome}");
Console.WriteLine($"Idade do cachorrinho:{cachorro.idade}");
Console.WriteLine($"Cor do cachorrinho:{cachorro.cor}");
Console.WriteLine($"Raça do cachorrinho:{cachorro.raca}");

Animal urso = new Animal();

urso.nome = "Freddy";
urso.raca = "Fazzbear";
urso.cor = "marrom";
urso.idade = 1983;

Console.WriteLine($"Nome do Urso:{urso.nome}");
Console.WriteLine($"Idade do Urso:{urso.idade}");
Console.WriteLine($"Cor do Urso:{urso.cor}");
Console.WriteLine($"Raça do Urso:{urso.raca}");

Animal coelho = new Animal();

coelho.nome = "William";
coelho.raca = "Afton";
coelho.cor = "Amarelo";
coelho.idade = 1983;

Console.WriteLine($"Nome do Coelho:{coelho.nome}");
Console.WriteLine($"Raça do Coelho:{coelho.raca}");
Console.WriteLine($"Cor do Coelho:{coelho.cor}");
Console.WriteLine($"Idade do Coelho:{coelho.idade}");

cachorro.FazerBarulho("Au-Au");
Console.WriteLine($"Idade de {cachorro.nome} é {cachorro.idade}");
cachorro.Envelhecer();
Console.WriteLine($"nova idade de {cachorro.nome} é {cachorro.idade}");


urso.FazerBarulho();
Console.WriteLine($"Idade de {urso.nome} é {urso.idade}");
urso.Envelhecer();
Console.WriteLine($"Nova idade de {urso.nome} é {urso.idade}");

coelho.FazerBarulho("Chega ae mano, chega ae");
Console.WriteLine($"idade de {coelho.nome} é {coelho.idade}");
coelho.Envelhecer();
Console.WriteLine($"Nova idade de {coelho.nome} é {coelho.idade}");






