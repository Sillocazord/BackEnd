using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PilaresPOO.Classes.Aprendizagem
{
    public class Veiculos
    {
        public string marca = "";

        public string modelo = "";

        public string cor ="";
        public int potencia;

        public void Ligar()
        {
            Console.WriteLine($"Ligado e pronto pra ir");
            
        }
        public void Desligar()
        {
            Console.WriteLine($"Desligado e pronto pra ficar");
            
        }
        public void Buzina()
        {
            Console.WriteLine($"BipBip");
            
        }
    }
}