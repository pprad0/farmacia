using Farmacia.Model;
using Farmacia.Repository;

namespace Farmacia.Controller
{
    internal class ProdutoController : IProdutoRepository
    {
        private readonly List<Produto> listaProdutos = new();

        int numero = 0;

        //CRUD
        public void CriarProduto(Produto produto)
        {
            listaProdutos.Add(produto);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n O produto de número {produto.GetId()} foi criado com sucesso!");
            Console.ResetColor();
        }

        public void ListarProdutos()
        {
            foreach (var item in listaProdutos)
                item.Visualizar();
        }

        public void ConsultarProdutoPorId(int id)
        {
            if (this.ProcurarNaCollection(id) != null)
            {
                listaProdutos[id - 1].Visualizar();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($" Nenhum produto foi encontrado com o número {id}.");
                Console.ResetColor();
            }
        }


        public void AtualizarProduto(Produto produto)
        {
            var produtoExiste = this.ProcurarNaCollection(produto.GetId());

            if (produtoExiste != null)
            {
                var index = listaProdutos.IndexOf(produtoExiste);
                listaProdutos[index] = produto;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($" Produto de número {produto.GetId()} atualizado com sucesso!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" Nenhum produto foi encontrado com este número.");
                Console.ResetColor();
            }
        }



        public void DeletarProduto(int id)
        {
            var buscarProduto = this.ProcurarNaCollection(id);

            if (buscarProduto != null)
            {

                if (listaProdutos.Remove(buscarProduto) == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($" O produto com o número {id} foi apagado com sucesso!");
                    Console.ResetColor();

                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($" Nenhum produto foi encontrado com o número {id}.");
                Console.ResetColor();
            }
        }



        //Métodos auxiliares
        public int GerarId()
        {
            return ++numero;
        }

        public Produto? ProcurarNaCollection(int id)
        {
            foreach (var item in listaProdutos)
            {
                if (item.GetId() == id)
                    return item;
            }

            return null;
        }
    }
}
