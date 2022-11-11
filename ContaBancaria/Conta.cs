using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    internal class Conta
    {
        private string _nome;
        public int ContaNumero { get; private set; }
        public double Saldo { get; private set; }
        public Conta(int contaNumero, string nome)
        {
            ContaNumero = contaNumero;
            Nome = nome;
        }
        public Conta(int contaNumero, string nome, double depositoInicial) : this(contaNumero, nome)
        {
            Deposito(depositoInicial);
        }
        public string Nome
        {
            get { return _nome; } 
            set { 
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }
        public void Deposito(double valor)
        {
            Saldo += valor;
        }
        public void Saque(double valor)
        {
            Saldo -= (valor + 5.0);
        }

        public override string ToString()
        {
            return "Conta " + ContaNumero + ", Titular: " + Nome + ", Saldo: R$" + Saldo.ToString("F2") + ".";
        }
    }
}
