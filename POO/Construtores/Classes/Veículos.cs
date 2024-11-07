using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores.Classes
{
    public class Veículos
    {
        public string marca { get; set;}
        public string modelo { get; set;}
        public int ano { get; set;}
        public string cor { get; set;}
        public Veículos (string ma, string md, int an, string cr){
            marca = ma;
            modelo = md;
            ano = an;
            cor = cr;

        }
        public void ExibirDados()
        {
            Console.WriteLine($@"
            marca: {marca}
            modelo: {modelo}
            ano: {ano}
            cor: {cor}
            ");
            
        }


    }
}