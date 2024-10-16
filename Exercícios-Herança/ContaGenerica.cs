using System.Globalization;

namespace Exercícios_Herança
{
    public abstract class ContaGenerica
    {
        public string Banco { get; set; }
        public int Agencia { get; set; }
        public int Conta { get; set; }
        public double Saldo { get; set; }

        public abstract void depositar();
        public abstract void sacar();
    }

    public class ContaCorrente : ContaGenerica
    {
        public double limite { get; set; }
        public override void depositar()
        {
            Console.WriteLine("Você depositou 100 reais");
        }

        public override void sacar()
        {
            Console.WriteLine("Você sacou 100 reais");
        }
    }
}
