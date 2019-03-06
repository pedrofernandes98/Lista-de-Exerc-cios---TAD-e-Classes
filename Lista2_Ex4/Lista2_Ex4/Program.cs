using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_Ex4
{
    class DVD
    {
        private string _Nome;

        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        private string _Duracao;

        public string Duracao
        {
            get { return _Duracao; }
            set { _Duracao = value; }
        }

        private string _Categoria;

        public string Categoria
        {
            get { return _Categoria; }
            set { _Categoria = value; }
        }

        private string _Diretor;

        public string Diretor
        {
            get { return _Diretor; }
            set { _Diretor = value; }
        }

        public void Cadastro()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------Cadastro de Filme: -----------------------------------");
            Console.WriteLine("Nome.............:");
            _Nome = Console.ReadLine();
            Console.WriteLine("\nDuração........:");
            _Duracao = Console.ReadLine();
            Console.WriteLine("\nCategoria......:");
            _Categoria = Console.ReadLine();
            Console.WriteLine("\nDiretor........:");
            _Diretor = Console.ReadLine();

        }

        public void MostraDVD()
        {
            Console.WriteLine("Nome do Filme: {0}", _Nome);
            Console.WriteLine("Duração......: {0}", _Duracao);
            Console.WriteLine("Categoria....: {0}", _Categoria);
            Console.WriteLine("Diretor......: {0}", _Diretor);
        }

        public void MostraDVD(string tipo)
        {
            if(tipo == _Categoria)
            {
                MostraDVD();
                Console.WriteLine();
            }
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            ArrayList ListaFilmes = new ArrayList();
            DVD MeuDVD;
            string pesquisa;

            for(int i = 0; i < 5; i++)
            {
                MeuDVD = new DVD();

                MeuDVD.Cadastro();

                ListaFilmes.Add(MeuDVD);
            }

            Console.Clear();

            foreach(DVD x in ListaFilmes)
            {
                x.MostraDVD();
                Console.Write("\n");
                
            }
            Console.ReadKey();
            Console.WriteLine("\n");
            Console.Clear();

            Console.WriteLine("Digite a categoria que deseja pesquisar...: ");
            pesquisa = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("----------------------Listagem de Filmes da Categoria {0}----------------------", pesquisa);

            foreach(DVD x in ListaFilmes)
            {
                
                x.MostraDVD(pesquisa);
            }

            Console.ReadKey();

        }
    }
}
