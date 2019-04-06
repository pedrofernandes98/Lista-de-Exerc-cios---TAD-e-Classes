using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_desafio
{
    class Dados
    {
        private ArrayList ListaProdutos = new ArrayList();
        private ArrayList ListaCategorias = new ArrayList();
        //Produto MeuProduto;
        //Categoria MinhaCategoria;

        public void InsereProduto(Produto MeuProduto)
        {
            ListaProdutos.Add(MeuProduto);
        }

        public void InsereCategoria(Categoria MinhaCategoria)
        {
            ListaCategorias.Add(MinhaCategoria);
        }

        public ArrayList RetornaListaProdutos()
        {
            return ListaProdutos;
        }

        public ArrayList RetornaListaCategoria()
        {
            return ListaCategorias;
        }

        public int RetornaCodCategoria()
        {
            return ListaCategorias.Count;
        }
    }
}
