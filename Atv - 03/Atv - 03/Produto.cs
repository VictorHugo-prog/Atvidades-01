namespace Atv___03
{

        public class Produto
        {
            public double Codigo { get; set; }

            public string Nome { get; set; }

            public double Preco { get; set; }

            public double Estoque { get; set; }

            public Produto(double codigo, string nome, double preco, double estoque)
            {
                Codigo = codigo;
                Nome = nome;
                Preco = preco;
                Estoque = estoque;
            }

            /* Método */
            public void valorEstoque()
            {
                Console.WriteLine($"O produto {Nome} contem: {Estoque} unidades");

            }
        }
    }