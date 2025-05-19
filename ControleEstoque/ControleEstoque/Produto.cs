using System.Globalization;

namespace Course
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        // função para calcular o valor total
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        // adiciona produto no estoque
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        // remove produto do estoque 
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }


        // transforma um object em string para leitura do usuario
        public override string ToString()
        {
            return Nome + ", $" + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade
                + (" unidades, Total: $") + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}