using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_2___Ex_2
{
    struct Data_Nascimento
    {
        public int Dia;
        public string Mes;
        public int Ano;
    }

    struct Aluno
    {
        public string Nome;
        public string Mail;
        public Data_Nascimento Data;
        public string Telefone; 
    }

    class Program
    {
        static void Preenche(Aluno[] MeuAluno)
        {
            for(int i = 0; i < MeuAluno.Length; i++)
            {
                Console.WriteLine("\nDigite o nome do aluno {0}....................:", i + 1);
                MeuAluno[i].Nome = Console.ReadLine();

                Console.WriteLine("\nDigite o E-mail do Aluno {0} .................:", i + 1);
                MeuAluno[i].Mail = Console.ReadLine();

                Console.WriteLine("\nDigite o Dia de Nascimento do Aluno {0} ......:", i + 1);
                MeuAluno[i].Data.Dia = int.Parse(Console.ReadLine());

                Console.WriteLine("\nDigite o Mês de Nascimento do Aluno {0} ......:", i + 1);
                MeuAluno[i].Data.Mes = Console.ReadLine();

                Console.WriteLine("\nDigite o Ano de Nascimento do Aluno {0} ......:", i + 1);
                MeuAluno[i].Data.Ano = int.Parse(Console.ReadLine());

                Console.WriteLine("\nDigite o Telefone do Aluno {0} ...............:", i + 1);
                MeuAluno[i].Telefone = Console.ReadLine();
            }
        }

        static void MostraAluno(Aluno[] MeuAluno)
        {
            int cont = 0;

            foreach(Aluno x in MeuAluno)
            {
                Console.WriteLine("\nAluno {0}:", ++cont);
                Console.WriteLine("Nome: {0,6} E-mail: {1,6}", x.Nome, x.Mail);
                Console.WriteLine("Data de Nascimento: {0} de {1} de {2}", x.Data.Dia, x.Data.Mes, x.Data.Ano);
                Console.WriteLine("Telefone: {0}", x.Telefone);
            }

            Console.ReadKey();
        }



        static void Main(string[] args)
        {
            

            
        }
    }
}
