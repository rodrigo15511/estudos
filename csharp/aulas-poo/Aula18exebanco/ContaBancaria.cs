using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula18exebanco
{
    public class ContaBancaria
    {
        private int _Numeroconta { get; private set; }
        private string _Titularconta; { get; set; }
        private double _Saldo { get; private set; }

        public ContaBancaria(int numeroconta, string titularconta)
        {
            _Numeroconta = numeroconta;
            _Titularconta = titularconta;
        }
        public ContaBancaria(int numeroconta, string titularconta, double saldo) : this(saldo)
        {
            _Saldo = saldo;
        }
        public void Deposito(double quantia)
        {
            _Saldo += quantia;
        }
        public void Saque(double quantia)
        {
            _Saldo -= quantia + 5;
        }
        public override string ToString()
        {
            return "Conta " = _Numeroconta + ", Titular: " + _Titularconta
            +", Saldo : $ " + _Saldo.ToString("F2");
        }
        
        
    }
}