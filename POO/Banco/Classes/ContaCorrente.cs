using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banco.Classes
{
    public class ContaCorrente
    {
        public int numeroConta = 0;

        public string ? Titular;

        public float Saldo = 0f;

        public void Depositar(float valor)
        {
            Saldo = Saldo + valor;
        }

        public void Sacar(float valor)
        {
            Saldo = Saldo - valor;
        }
    }
}