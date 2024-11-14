using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PilaresPOO.Classes.Aprendizagem
{
    public abstract class Pessoa
    {       // Atributos(São Caracteristicas)
            // Nome
            // Idade
            // Cpf
            // Peso
            // Altura
        public string nome = "";
        public int idade;
        public string cpf = "";
        public float peso;
        public float altura;

        //Metodos:
        //visibilidade tipoDeDadoRetornado nome(parametros){}
        //Envelhecer
        //Engordar
        //Emagrecer

        public void Envelhecer(){
            idade++;
        }

        public void Engordar(float _kg){
            peso = peso + _kg;
        }

        public void Emagrecer(float _kg){
            peso = peso - _kg;
        }

    }
}