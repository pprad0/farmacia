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
            Console.WriteLine($" O produto de número {produto.GetId()} foi criado com sucesso!");
        }



        public void AtualizarProduto()
        {
            throw new NotImplementedException();
        }

        public void ConsultarProdutoPorId(int id)
        {
            throw new NotImplementedException();
        }


        public void DeletarProduto(int id)
        {
            throw new NotImplementedException();
        }

        public void ListarProdutos()
        {
            throw new NotImplementedException();
        }



        //Métodos auxiliares
        public int GerarId()
        {
            return ++numero;
        }
    }
}
