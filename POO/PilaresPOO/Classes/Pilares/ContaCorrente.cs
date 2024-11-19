using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace PilaresPOO.Classes.Pilares
{
    public class ContaCorrente : Conta
    {
        public float Limite{get;set;}

        public bool Transferir(float valor, Conta contaDestino){
            return false;
        }

        public override bool Depositar(float valor)
        {
            if(valor > 0){
            saldo = saldo + valor;
            return true;}
            else {
                return false;
            }
        }
        public override float Sacar(float valor)
        {
            if (saldo >= 0){
            saldo = saldo - valor;
            return valor;
            } else {
                return 0;
            }
        }

    }
}