using Farmacia.Controller;
using Farmacia.Model;

namespace Farmacia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0, tipo;
            decimal preco;
            string nome, fragancia, generico;

            ProdutoController produtos = new();

            while (opcao != 6)
            {

                string menu = "\n------------------------------------------------------" +
                    "\n\tDROGARIA DA MÁRCIA - FARMÁRCIA" +
                    "\n------------------------------------------------------" +
                    "\n\t1 - Criar Produto " +
                    "\n\t2 - Listar Todos os Produtos" +
                    "\n\t3 - Consultar Produto " +
                    "\n\t4 - Atualizar Produto" +
                    "\n\t5 - Deletar Produto" +
                    "\n\t6 - Sair" +
                    "\n------------------------------------------------------" +
                    "\nDigite a opção desejada: ";



                Console.WriteLine(menu);
                opcao = Convert.ToInt32(Console.ReadLine());


                Console.ForegroundColor = ConsoleColor.Green;
                switch (opcao)
                {
                    case 1:
                        //criar produto
                        //coletar dados

                        Console.WriteLine(" Qual o nome do produto? ");
                        nome = Console.ReadLine()!;

                        Console.WriteLine(" Qual o tipo de produto? ");
                        tipo = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(" Qual o preço do produto? ");
                        preco = Convert.ToDecimal(Console.ReadLine());

                        if (tipo == 1)
                        {
                            Console.WriteLine(" Qual o nome do medicamento? ");
                            generico = Console.ReadLine()!;

                            produtos.CriarProduto(new Medicamento(produtos.GerarId(), nome, 1, preco, generico));
                        }
                        else if (tipo == 2)
                        {
                            Console.WriteLine(" Qual o nome do cosmético? ");
                            fragancia = Console.ReadLine()!;

                            produtos.CriarProduto(new Cosmetico(produtos.GerarId(), nome, 2, preco, fragancia));
                        }
                        else
                            Console.WriteLine("Falha no cadastro do produto.");

                        break;

                    case 2:
                        //listar todos os produtos
                        break;

                    case 3:
                        //consultar produto
                        break;

                    case 4:
                        //atualizar produto
                        break;

                    case 5:
                        //deletar produto
                        break;

                    case 6:
                        //sair
                        break;
                }

                Console.ResetColor();

            }
        }
    }
}