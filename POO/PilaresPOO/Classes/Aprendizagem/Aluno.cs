using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PilaresPOO.Classes.Aprendizagem
{
    public class Aluno : Pessoa
    {
        public int matricula { get; set;}
        public string curso = "";
        public float media{ get; set;}
    }
}