using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_desafio
{
    class Operacoes
    {
        private Dados MeusDados = new Dados();
        private Produto MeuProduto;
        private Categoria MinhaCategoria;

        public void CadastraProduto()
        {

            do
            {
                Console.Clear();
                MeuProduto = new Produto();
                Console.Write("Nome do Produto:");
                MeuProduto.NomeProduto = Console.ReadLine();
                do
                {
                    Console.Write("Código da Categoria do Produto:");
                    MeuProduto.CodigoCategoria = int.Parse(Console.ReadLine());
                } while (!Pesquisa(MeuProduto.CodigoCategoria));

                Console.Write("Preço Unitário: R$");
                MeuProduto.PrecoUnitario = double.Parse(Console.ReadLine());

                Console.Write("Quantidade em Estoque:");
                MeuProduto.QuantidadeEstoque = int.Parse(Console.ReadLine());

                MeusDados.InsereProduto(MeuProduto);

                Console.WriteLine("ENTER para cadastra novo produto ou ESC para sair");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }

        public bool Pesquisa(int Cod)
        {
            ArrayList Pesquisa = new ArrayList();
            Pesquisa = MeusDados.RetornaListaCategoria();
            foreach(Categoria x in Pesquisa)
            {
                if(x.Codigo == Cod)
                {
                    return true;
                }
            }

            return false;
        }

        public string PesquisaDescricao(int Cod)
        {
            ArrayList Pesquisa = new ArrayList();
            Pesquisa = MeusDados.RetornaListaCategoria();
            foreach (Categoria x in Pesquisa)
            {
                if (x.Codigo == Cod)
                {
                    return x.Descricao;
                }
            }

            return "";
            
        }

        public void CadastraCategoria()
        {
            do
            {
                Console.Clear();
                MinhaCategoria = new Categoria();
                MinhaCategoria.Codigo = MeusDados.RetornaCodCategoria() + 1;
                Console.Write("Código da Categoria: {0}\n", MinhaCategoria.Codigo);
                Console.Write("Descrição da Categoria:");
                MinhaCategoria.Descricao = Console.ReadLine();

                MeusDados.InsereCategoria(MinhaCategoria);

                Console.WriteLine("ENTER para cadastrar uma nova categoria ou ESC para Sair");

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }

        public void Relatorio()
        {
            ArrayList ListaProdutos = new ArrayList();
            ArrayList ListaCategoria = new ArrayList();

            ListaProdutos = MeusDados.RetornaListaProdutos();
            ListaCategoria = MeusDados.RetornaListaCategoria();

            ListaRelatorio(ListaProdutos, ListaCategoria);


        }

        public void ListaRelatorio(ArrayList P, ArrayList C)
        {
            Console.Clear();
            Console.WriteLine("Relatório de Estoque");
            string Descricao;

            foreach(Produto x in P)
            {
                Descricao = PesquisaDescricao(x.CodigoCategoria);

                Console.WriteLine("{0} - {1} - R${2:F2} - {3}",x.NomeProduto,Descricao,x.PrecoUnitario,x.QuantidadeEstoque);
            }

            Console.ReadKey();
        }

        public void Inventario()
        {
            Console.Clear();
            ArrayList ListaProdutos = new ArrayList();
            

            ListaProdutos = MeusDados.RetornaListaProdutos();
            double soma = 0;
            foreach(Produto x in ListaProdutos)
            {
                Console.WriteLine("{0} - R${1:F2} - {2} - {3:F2}", x.NomeProduto, x.PrecoUnitario, x.QuantidadeEstoque, x.PrecoUnitario * x.QuantidadeEstoque);
                soma += (x.PrecoUnitario * x.QuantidadeEstoque);
            }
            Console.WriteLine("\n\n\nValor Total do Estoque: R${0:F2}",soma);

            Console.ReadKey();

        }
    }
}
