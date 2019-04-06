using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            Operacoes MinhasOperacoes = new Operacoes();
            int op;
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Cadastro de Categoria");
                Console.WriteLine("2 - Cadastro de Produto");
                Console.WriteLine("3 - Relatório de Produtos");
                Console.WriteLine("4 - Inventário de Estoque");
                Console.WriteLine("0 - Sair");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:

                        MinhasOperacoes.CadastraCategoria();

                        break;

                    case 2:

                        MinhasOperacoes.CadastraProduto();

                        break;

                    case 3:

                        MinhasOperacoes.Relatorio();

                        break;

                    case 4:

                        MinhasOperacoes.Inventario();

                        break;

                    case 0:

                        Console.WriteLine("Encerrando o programa...");
                        break;

                    default:

                        Console.WriteLine("Opção Inválida");

                        break;
                }
            } while (op != 0);
        }
    }
}
