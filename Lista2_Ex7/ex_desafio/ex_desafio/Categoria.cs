using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_desafio
{
    class Categoria
    {
        private int _Codigo = 0;

        public int Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }

        public string Descricao { get; set; }

        
    }
}
