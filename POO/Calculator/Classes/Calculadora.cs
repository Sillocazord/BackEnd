using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Classes
{
    public class Calculadora
    {
        public float numero1 = 0f;
        public float numero2 = 0f;

        public void Somar()
        {
            float resultado = numero1 + numero2;
            Console.WriteLine($"Resultado : {resultado}");
            
        }
        public void Subtrair()
        {
            float resultado = numero1 - numero2;
            Console.WriteLine($"Resultado : {resultado}");
        }
        public void Multiplicar()
        {
            float resultado = numero1 * numero2;
            Console.WriteLine($"Resultado : {resultado}");
        }
        public void Dividir()
        {
            float resultado = numero1 / numero2;
            Console.WriteLine($"Resultado : {resultado}");
        }

    }
}