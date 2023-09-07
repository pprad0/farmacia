namespace Farmacia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;

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

                Console.Clear();
            }
        }
    }
}