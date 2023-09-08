using Farmacia.Model;

namespace Farmacia.Repository
{
    public interface IProdutoRepository
    {
        //CRUD
        public void CriarProduto(Produto produto);
        public void ListarProdutos();
        public void ConsultarProdutoPorId(int id);
        public void AtualizarProduto(Produto produto);
        public void DeletarProduto(int id);
    }
}
