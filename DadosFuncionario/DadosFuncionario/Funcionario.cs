using System.Globalization;

namespace DadosFuncionario
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

       public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

       public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += SalarioBruto * (porcentagem / 100.0);
        }

        public override string ToString()
        {
            return "Funcionário: " +Nome+ ", $" + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
