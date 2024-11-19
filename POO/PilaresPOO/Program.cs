using PilaresPOO.Classes.Pilares;

Console.Clear();
ContaCorrente ctEdu = new ContaCorrente();
ctEdu.titular = "Eduardo Mendes da Costa";
ctEdu.Depositar(1000000f);

Console.WriteLine($"Titular da conta: {ctEdu.titular}");
Console.WriteLine($"Saldo da conta: {ctEdu.getSaldo()}");

float valorSacado = ctEdu.Sacar(1200f);

Console.WriteLine($"Valor do saque:{valorSacado}");
Console.WriteLine($"Novo saldo: {ctEdu.getSaldo()}");