using Farmacia.Controller;
using Farmacia.Model;

namespace Farmacia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0, tipo, id;
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


                Console.ForegroundColor = ConsoleColor.DarkBlue;
                switch (opcao)
                {
                    case 1:
                        //*criar produto* ok
                        //coletar dados

                        Console.WriteLine(" Qual o nome do produto? ");
                        nome = Console.ReadLine()!;

                        Console.WriteLine(" Qual o preço do produto? ");
                        preco = Convert.ToDecimal(Console.ReadLine());

                        Console.WriteLine(" Qual o tipo de produto? ");
                        tipo = Convert.ToInt32(Console.ReadLine());


                        if (tipo == 1)
                        {
                            Console.WriteLine(" Qual o nome do generico? ");
                            generico = Console.ReadLine()!;

                            produtos.CriarProduto(new Medicamento(produtos.GerarId(), nome, 1, preco, generico));
                        }
                        else if (tipo == 2)
                        {
                            Console.WriteLine(" Qual o nome da fragancia? ");
                            fragancia = Console.ReadLine()!;

                            produtos.CriarProduto(new Cosmetico(produtos.GerarId(), nome, 2, preco, fragancia));
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Falha no cadastro do produto, 'tipo' incorreto.");
                            Console.ResetColor();
                        }
                        break;

                    case 2:
                        //*listar produtos* ok
                        produtos.ListarProdutos();
                        break;

                    case 3:
                        //*consultar produto* ok
                        Console.WriteLine(" Digite o número do produto: ");
                        opcao = Convert.ToInt32(Console.ReadLine());

                        produtos.ConsultarProdutoPorId(opcao);
                        break;

                    case 4:
                        //*atualizar produto* ok
                        //conferir se id existe
                        Console.WriteLine(" Digite o número do produto: ");
                        id = Convert.ToInt32(Console.ReadLine());

                        if (produtos.ProcurarNaCollection(id) != null)
                        {
                            //atualizar informações
                            Console.WriteLine(" Qual o nome do produto? ");
                            nome = Console.ReadLine()!;

                            Console.WriteLine(" Qual o preço do produto? ");
                            preco = Convert.ToDecimal(Console.ReadLine());

                            Console.WriteLine(" Qual o tipo de produto? ");
                            tipo = Convert.ToInt32(Console.ReadLine());


                            if (tipo == 1)
                            {
                                Console.WriteLine(" Qual o nome do generico? ");
                                generico = Console.ReadLine()!;

                                produtos.AtualizarProduto(new Medicamento(id, nome, 1, preco, generico));
                            }
                            else if (tipo == 2)
                            {
                                Console.WriteLine(" Qual o nome da fragancia? ");
                                fragancia = Console.ReadLine()!;

                                produtos.AtualizarProduto(new Medicamento(id, nome, 2, preco, fragancia));
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Falha no cadastro do produto, 'tipo' incorreto.");
                                Console.ResetColor();
                            }

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($" Nenhum produto foi encontrado com o número {opcao}.");
                            Console.ResetColor();
                        }

                        break;

                    case 5:
                        //*deletar produto*

                        Console.WriteLine(" Qual o Número do Produto? ");
                        id = Convert.ToInt32(Console.ReadLine());

                        produtos.DeletarProduto(id);

                        break;

                    case 6:
                        //*sair* ok
                        break;
                }

                Console.ResetColor();

            }
        }
    }
}