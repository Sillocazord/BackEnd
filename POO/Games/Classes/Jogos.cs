using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Games.Classes
{
    public class Jogos
    {
        public string nome {get; set;}
        public float lancamento {get; set;}
        public string genero {get; set;}
        public float preco {get; set;}

        public Jogos(string no, float lan, string ge, float pre){
            nome = no;
            lancamento = lan;
            genero = ge;
            preco = pre;
        }

        public void ExibirDados(){

            Console.WriteLine(@$"
            Dados do jogo: {nome}
            Lançamento: {lancamento}
            Gênero: {genero}
            Preço: {preco}");
        }
        


    }
}