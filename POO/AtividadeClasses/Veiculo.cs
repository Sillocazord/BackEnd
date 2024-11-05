using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeClasses.Veiculo
{
    public class Veiculo
    {
        public string propiedades;
        public string marca;
        public string modelo;
        public string cor;
        public int potencia = 0;
        public int qtdportas = 0;
        
        public void Acelerar( string acelerar = "stututututu")
        {
            Console.WriteLine($"som do carro ao acelerar : {acelerar}");
  
        }

        public void Ligar (string ligar = "ligado")
        {
            Console.WriteLine($"carro: {ligar}");
            
        }
        public void Desligar (string desligar = "desligado")
        {
            Console.WriteLine($"carro : {desligar}");
            
        }
        public void Freiar(string freiar)
        {
            Console.WriteLine($"Som do carro ao freiar: {freiar}");
            
        }
    }
}