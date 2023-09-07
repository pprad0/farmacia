namespace Farmacia.Repository
{
    public interface IProdutoRepository
    {
        //CRUD
        public void CriarProduto();
        public void ListarProdutos();
        public void ConsultarProdutoPorId(int id);
        public void AtualizarProduto();
        public void DeletarProduto(int id);
    }
}
