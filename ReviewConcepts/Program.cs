Console.WriteLine($"Ola, digite teu nome");
string nome = Console.ReadLine()!;
Console.WriteLine($"Ola {nome}, digite seu sobrenome");
string sobrenome = Console.ReadLine ()!;
Console.WriteLine($"Obrigado {nome} {sobrenome}");
Console.WriteLine(@"

                +---------------------------------------+
                |       Boas vindas ao nosso site!      |
                +---------------------------------------+
                |                                       |
                |                Seja muito             |
                |                Bem vindo              |
                |                Ao nosso               |
                |                 Site!                 |
                |                                       |
                +---------------------------------------+
                ");
Console.WriteLine($"Informe o ano do seu nascimento");
int data = int.Parse (Console.ReadLine());
int anoatual = DateTime.Now.Year;
int idade = data - anoatual;

Console.WriteLine($"Agora informe seu Email");
string Email = Console.ReadLine()!;

Console.WriteLine($"Informe seu numero de telefone");
UInt128 telefone = UInt128.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe seu cpf");
UInt128 cpf = UInt128.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe o seu endereco");
string endereco = Console.ReadLine()!;

Console.WriteLine($"informe seu estado civil (casado, solteiro, viuvo, etc...)");
string casado = Console.ReadLine()!;

Console.WriteLine($"Exibindo dados...");
Console.WriteLine(@$" 
-{nome} {sobrenome} 
-{idade} 
-{Email} 
-{telefone} 
-{cpf} 
-{endereco} 
-{casado}
");