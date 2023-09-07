using Farmacia.Model;

namespace Farmacia.Repository
{
    public interface IProdutoRepository
    {
        //CRUD
        public void CriarProduto(Produto produto);
        public void ListarProdutos();
        public void ConsultarProdutoPorId(int id);
        public void AtualizarProduto();
        public void DeletarProduto(int id);
    }
}
