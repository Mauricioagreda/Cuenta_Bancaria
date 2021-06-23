namespace Cuenta_Bancaria
{
    public class Cuenta
    {
        static int Contador { get; set; } = 0;
        public int Cbu { get; set; }
        public double Saldo { get; set; }

        public void Acreditar(double acreditar)
        {
            Saldo += acreditar;
        }

        public void Debitar(double debitar)
        {
            Saldo -= debitar;
        }

        public bool TieneAlMenos(double x) => Saldo >= x;

        public Cuenta()
        {
            Cbu = ++Contador;
            Saldo = 0;
        }

        public interface IEstrategia
        {
            void Debitar(Cliente cliente, double monto);
        }
    }
}