using System;
using System.Globalization;

namespace ExercicioContaBancaria
{
    class Banco
    {
        public int _nroConta { get; private set; }
        public string TitularConta { get; set; }
        public double _saldo { get; private set; }

        public Banco()
        {
        }

        public Banco(int nroConta, string titularConta)
        {
            _nroConta = nroConta;
            TitularConta = titularConta;
        }
        public Banco(int nroConta, string titularConta, double saldo) : this(nroConta, titularConta)
        {
            _saldo = saldo;
        }

        public void Deposito(double deposito)
        {
            _saldo += deposito;
        }

        public void Saque(double saque)
        {
            _saldo = (_saldo - saque) - 5;
        }

        public override string ToString()
        {
            return "Conta "
                + _nroConta
                + ", Titular: "
                + TitularConta
                + ", Saldo $ "
                + _saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
