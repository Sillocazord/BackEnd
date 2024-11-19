using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PilaresPOO.Classes.Aprendizagem
{
    public class Personagem
    { //virtual significa que o metodo pode ser sobreescrito na classe filha/subclasse
        public virtual void Atacar(){
            Console.WriteLine($"O personagem atacou");
        }

        public void Defender(){
            Console.WriteLine($"O Personagem defendeu");
            
        }
    }
}