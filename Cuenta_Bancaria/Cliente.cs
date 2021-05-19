using System;

namespace Cuenta_Bancaria
{
    public class Cliente
    {
        private Cuenta Cuenta;
        private string Nombre { get; set; }
        private string Apellido { get; set; }
        private double Efectivo { get; set; }

        public double Saldo => this.Efectivo + Cuenta.Saldo;

        public Cliente()
        {
            Efectivo = 0;
            Cuenta = new Cuenta();
        }

        public void Acreditar(double acreditar)
        {
            Efectivo = Efectivo + acreditar * 0.8;
            Cuenta.Acreditar(acreditar * 0.2);
        }

        public void Debitar(double debitar)
        {
            Efectivo = Efectivo - debitar * 0.8;
            Cuenta.Debitar(debitar * 0.2);
        }

        public int Cbu => Cuenta.Cbu;

        public bool TieneAlMenos(double x) => Saldo >= x;
    }
}
