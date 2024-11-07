
namespace RPGPOO.Classes
{
    public class Personagem
    {
        public string Nome = "";
        public int Idade = 0;
        public string Armadura = "";
        public string IA = "";

        public void Atacar (string Atacar = "Atacou!"){
            Console.WriteLine($"{Nome} {Atacar}" );
            
        }

        public void Defender (string Defender = "Defendeu!"){
            Console.WriteLine($"{Nome} {Defender}" );
            
        }
         public void Restaurar (string Restaurar = "Restaurou a armadura!")//o personagem restaura a armadura
         {
            Console.WriteLine($"{Nome} {Restaurar}" );
            
        }

    }
}