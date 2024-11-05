// See https://aka.ms/new-console-template for more information
using Banco.Classes;
Console.Clear();

Console.WriteLine("Banco do Brasuca meus crias, seu dinheiro, nossa alegria!");
Console.WriteLine($"");

ContaCorrente contaSillas = new ContaCorrente(); //contaEmilly
ContaCorrente contaMennegheti = new ContaCorrente(); //contaClara

contaSillas.Titular = "Sillas";
contaSillas.Depositar(10000f);

contaMennegheti.Titular = "Mennegheti";
contaMennegheti.Depositar(10000f);

Console.WriteLine($"Conta do {contaSillas} tem R$ {contaSillas.Saldo}");

contaSillas.Sacar(250f);

Console.WriteLine($"{contaSillas}, voce sacou {contaSillas.Sacar} ");
Console.WriteLine($"Seu saldo atual é de: {contaSillas.Saldo}");

