using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course
{
    class Banco
    {
        public string   Nome;
        public int      Conta { get; private set; }
        private double  _saldo;

        public Banco()
        {
            _saldo = 0;
        }

        public Banco(string nome, int conta) : this()
        {
            Nome = nome;
            Conta = conta;
        }

        public Banco(string nome, int conta, double depositoInicial) : this(nome, conta)
        {
            Deposito(depositoInicial);
        }

        public double Saldo
        {
            get { return _saldo; }
            set
            {
                if(value < 0)
                {
                    _saldo = value;
                }
            }
        }

        public void Saque(double valor)
        {
            _saldo -= valor + 5;
        }

        public void Deposito(double valor)
        {
            _saldo += valor;
        }

        public override string ToString()
        {
            return "Conta "
                + Conta
                + ", Titular: "
                + Nome
                + ", Saldo: $ "
                + _saldo.ToString("F2", CultureInfo.InvariantCulture);


        }
    }
}
