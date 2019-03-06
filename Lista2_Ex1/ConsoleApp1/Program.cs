using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    struct Aluno
    {
        public string Nome;
        public string Mail;
        public string Data;
        public string Telefone;
    }

    class Program
    {
        public static void Preenche(Aluno[] MeuAluno)
        {
            for(int i = 0; i < MeuAluno.Length; i++)
            {
                Console.WriteLine("Digite o Nome do Aluno {0}.................:", i + 1);
                MeuAluno[i].Nome = Console.ReadLine();

                Console.WriteLine("Digite o E-mail do Aluno {0}...............:", i + 1);
                MeuAluno[i].Mail = Console.ReadLine();

                Console.WriteLine("Digite a Data de Nascimento do Aluno {0} ..:", i + 1);
                MeuAluno[i].Data = Console.ReadLine();

                Console.WriteLine("Digite o Telefone do Aluno {0} ............:", i + 1);
                MeuAluno[i].Telefone = Console.ReadLine();
            }
        }

        public static void MostraAlunos(Aluno[] MeuAluno)
        {
            int cont = 0;

            Console.Clear();
            Console.WriteLine("---------------Lista de Alunos--------------------");
            foreach (Aluno x in MeuAluno) 
            {
                Console.WriteLine("Aluno {0} :",++cont);
                Console.WriteLine("Nome {0,6} Email: {1,6}", x.Nome, x.Mail);
                Console.WriteLine("Data de Nascimento: {0,6} Telefone: {1,6}", x.Data, x.Telefone);
                Console.WriteLine("");

            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Aluno[] MeuAluno = new Aluno[5];

            Preenche(MeuAluno);

            MostraAlunos(MeuAluno);

            




        }
    }
}
