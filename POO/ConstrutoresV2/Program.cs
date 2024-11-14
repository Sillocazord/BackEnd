
using ConstrutoresV2.Classes;

Aluno2 SillasEndrigo = new Aluno2("Sillas Endrigo");
SillasEndrigo.cpf = 1234;
Aluno2 HerikManAndChad = new Aluno2("Menegas");
HerikManAndChad.cpf = 1234;
Aluno2 eduCosta = new Aluno2();
eduCosta.cpf = 1234;
Aluno2 Spada = new Aluno2("Herik Spada",1234);
Console.WriteLine($"{SillasEndrigo.nome}");
Console.WriteLine($"{SillasEndrigo.cpf}");

Console.WriteLine($"");

Console.WriteLine($"{HerikManAndChad.nome}");
Console.WriteLine($"{HerikManAndChad.cpf}");

Console.WriteLine($"{Spada.nome}");
Console.WriteLine($"{Spada.cpf}");
