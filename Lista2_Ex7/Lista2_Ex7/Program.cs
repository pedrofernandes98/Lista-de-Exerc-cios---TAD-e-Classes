using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_Ex7
{
    class Categoria
    {
        private int _Codigo;

        public int Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }

        private string _Descricao;

        public string Descricao
        {
            get { return _Descricao; }
            set { _Descricao = value; }
        }

        public void CadastroCategoria()
        {
            Console.WriteLine("Cadatro de Categoria");
            Console.WriteLine("\n\nCódigo....: ");
            _Codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Descrição.:");
            _Descricao = Console.ReadLine();
        }

        

    }

    class Produto : Categoria
    {
        private string _Nome;

        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        private double _PrecoUnit;

        public double PrecoUnit
        {
            get { return _PrecoUnit; }
            set { _PrecoUnit = value; }
        }

        private int _QuantidadeEstoque;

        public int QuantidadeEstoque
        {
            get { return _QuantidadeEstoque; }
            set { _QuantidadeEstoque = value; }
        }

        public void CadastroProduto(ArrayList c)
        {
            int cod;
            Console.WriteLine("Cadastro de Novo Produto");
            Console.Write("\n\n");
            Console.WriteLine("Nome.................:");
            _Nome = Console.ReadLine();
            Console.WriteLine("Código da Categoria..:");
            cod = int.Parse(Console.ReadLine());
            foreach(Categoria x in c)
            {
                if(x.Codigo == cod)
                {
                    this.Codigo = x.Codigo;
                    this.Descricao = x.Descricao;
                }
            }         
            
            Console.WriteLine("Preço Unitário.......:");
            _PrecoUnit = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade em Estoque:");
            _QuantidadeEstoque = int.Parse(Console.ReadLine());
        }

        public void Relatorio()
        {
            //Console.Clear();
            
            
            Console.WriteLine("{0,6} | {1,6} | R${2:F2} | {3,6} ", _Nome, this.Descricao, _PrecoUnit, _QuantidadeEstoque);
            

            //Console.ReadKey();
        }

        public void Inventario()
        {
            
            
            
            

            Console.WriteLine("{0,6} | R${1:F2}", _Nome, (_QuantidadeEstoque * _PrecoUnit));
                
            

            
            //Console.ReadKey();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ArrayList ListaProdutos = new ArrayList();
            ArrayList ListaCategoria = new ArrayList();
            Produto MeuProduto;
            Categoria MinhaCategoria;

            int op;


            do
            {
                Console.Clear();
                Console.WriteLine("----------Menu de Opções----------");
                Console.WriteLine("1 - Cadastro de Categorias");
                Console.WriteLine("2 - Cadastro de Produtos");
                Console.WriteLine("3 - Relatório");
                Console.WriteLine("4 - Inventário de Estoque");
                Console.WriteLine("0 - Sair");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:

                        do
                        {
                            Console.Clear();
                            MinhaCategoria = new Categoria();
                            MinhaCategoria.CadastroCategoria();
                            ListaCategoria.Add(MinhaCategoria);

                            Console.WriteLine("ENTER para cadastrar nova categoria ou ESC para voltar ao Menu");
                        } while (Console.ReadKey().Key != ConsoleKey.Escape);

                    break;


                    case 2:

                        do
                        {
                            Console.Clear();
                            MeuProduto = new Produto();
                            MeuProduto.CadastroProduto(ListaCategoria);
                            ListaProdutos.Add(MeuProduto);

                            Console.WriteLine("ENTER para cadastrar novo produto ou ESC para voltar ao Menu");
                        } while (Console.ReadKey().Key != ConsoleKey.Escape);

                    break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("--------------Relatório Geral---------------");

                        foreach(Produto x in ListaProdutos)
                        {
                            x.Relatorio();

                        }
                        Console.ReadKey();
                    break;

                    case 4:
                        Console.Clear();
                        double soma = 0;
                        Console.WriteLine("--------------Inventário de Estoque---------------");

                        foreach(Produto x in ListaProdutos)
                        {
                            x.Inventario();
                            soma += (x.QuantidadeEstoque * x.PrecoUnit);
                        }
                        Console.WriteLine("Soma Total: R${0:F2}", soma);

                        Console.ReadKey();


                    break;

                    default:

                        Console.WriteLine("Opção Inválida!");

                    break;
                }
            } while (op != 0);
        }
    }
}
