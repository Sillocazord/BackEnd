using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PilaresPOO.Classes.Aprendizagem
{
    public class Professor : Pessoa
    {
        //Numero de identificação do fiscal - nif
        //Salario
        public int NIF {get; set;}
        public int salario {get; set;}
//ctor(cria um construtor)
        public Professor(int _nif)
        {
            NIF = _nif;
        }
        public Professor(){}

    }
}