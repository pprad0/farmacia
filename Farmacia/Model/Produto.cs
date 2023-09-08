namespace Farmacia.Model
{
    public abstract class Produto
    {
        private int id, tipo;
        private string nome;
        private decimal preco;


        public Produto(int id, string nome, int tipo, decimal preco)
        {
            this.id = id;
            this.nome = nome;
            this.tipo = tipo;
            this.preco = preco;
        }

        public int GetId() { return id; }
        public void SetId(int id) { this.id = id; }
        public string GetNome() { return nome; }
        public void SetNome(string nome) { this.nome = nome; }
        public int GetTipo() { return tipo; }
        public void SetTipo(int tipo) { this.tipo = tipo; }
        public decimal GetPreco() { return preco; }
        public void SetPreco(decimal preco) { this.preco = preco; }


        public virtual void Visualizar()
        {
            string mensagem =
                "\n------------------------------------------------------" +
                $"\t\n Número do produto: {this.id}" +
                $"\t\n Nome: {this.nome}" +
                $"\t\n Tipo: {this.tipo}" +
                $"\t\n Preço: {this.preco}";

            Console.WriteLine(mensagem);
        }
    }
}
