using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutoresV2.Classes
{
    public class Aluno2
    {
        public string nome ="";
        public int cpf;

        public Aluno2(){}
        public Aluno2(string chuchu){
            nome = chuchu;
        }

        public Aluno2(string _nome,int _cpf){
            nome = _nome;
            cpf = _cpf;
        }
    }
}