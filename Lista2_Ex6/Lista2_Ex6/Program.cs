using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_Ex6
{
    class Funcionario
    {
        private string _Nome;

        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        private string _Endereco;

        public string Endereco
        {
            get { return _Endereco; }
            set { _Endereco = value; }
        }

        private string _Telefone;

        public string Telefone
        {
            get { return _Telefone; }
            set { _Telefone = value; }
        }

        private string _Mail;

        public string Mail
        {
            get { return _Mail; }
            set { _Mail = value; }
        }

        private string _DataAdmissao;

        public string DataAdmissao
        {
            get { return _DataAdmissao; }
            set { _DataAdmissao = value; }
        }

        private string _DataNascimento;

        public string DataNascimento
        {
            get { return _DataNascimento; }
            set { _DataNascimento = value; }
        }

        private string _NomePai;

        public string NomePai
        {
            get { return _NomePai; }
            set { _NomePai = value; }
        }

        private string _NomeMae;

        public string NomeMae
        {
            get { return _NomeMae; }
            set { _NomeMae = value; }
        }

        private string _Identidade;

        public string Identidade
        {
            get { return _Identidade; }
            set { _Identidade = value; }
        }

        private string _CPF;

        public string CPF
        {
            get { return _CPF; }
            set { _CPF = value; }
        }

        private string _CarteiraTrabalho;

        public string CarteiraTrabalho
        {
            get { return _CarteiraTrabalho; }
            set { _CarteiraTrabalho = value; }
        }

        private char _Tipo;

        public char Tipo
        {
            get { return _Tipo; }
            set { _Tipo = value; }
        }


        public void Cadastro()
        {
            Console.Clear();
            Console.WriteLine("Nome................:");
            _Nome = Console.ReadLine();
            Console.WriteLine("Endereço............:");
            _Endereco = Console.ReadLine();
            Console.WriteLine("Telefone............:");
            _Telefone = Console.ReadLine();
            Console.WriteLine("E-mail..............:");
            _Mail = Console.ReadLine();
            Console.WriteLine("Data de Admissão....:");
            _DataAdmissao = Console.ReadLine();
            Console.WriteLine("Data de Nascimento..:");
            _DataNascimento = Console.ReadLine();
            Console.WriteLine("Nome do Pai.........:");
            _NomePai = Console.ReadLine();
            Console.WriteLine("Nome da Mãe.........:");
            _NomeMae = Console.ReadLine();
            Console.WriteLine("Identidade..........:");
            _Identidade = Console.ReadLine();
            Console.WriteLine("CPF.................:");
            _CPF = Console.ReadLine();
            Console.WriteLine("Carteira de Trabalho:");
            _CarteiraTrabalho = Console.ReadLine();
        }

        public void Relatorio()
        {
            Console.WriteLine("Nome: {0}", _Nome);
            Console.WriteLine("Endereço: {0}", _Endereco);
            Console.WriteLine("Telefone: {0}", _Telefone);
            Console.WriteLine("E-mail: {0}", _Mail);
            Console.WriteLine("Data de Admissão: {0}", _DataAdmissao);
            Console.WriteLine("Data de Nascimento: {0}", _DataNascimento);
            Console.WriteLine("Nome do Pai: {0}", _NomePai);
            Console.WriteLine("Nome da Mãe: {0}", _NomeMae);
            Console.WriteLine("Identidade: {0}", _Identidade);
            Console.WriteLine("CPF: {0}", _CPF);
            Console.WriteLine("Carteira de Trabalho: {0}", _CarteiraTrabalho);
            
        }

    }

    class AreaAdministrativa : Funcionario
    {
        private string _Cargo;

        public string Cargo
        {
            get { return _Cargo; }
            set { _Cargo = value; }
        }

        private string _Setor;

        public string Setor
        {
            get { return _Setor; }
            set { _Setor = value; }
        }

        public void CadastroAdministrativo()
        {
            Cadastro();
            
            Console.WriteLine("Cargo...............:");
            _Cargo = Console.ReadLine();
            Console.WriteLine("Setor...............:");
            _Setor = Console.ReadLine();
        }

        public void RelatorioAdministrativo()
        {
            Relatorio();

            Console.WriteLine("Cargo: {0}", _Cargo);
            Console.WriteLine("Setor: {0}", _Setor);
        }

    }

    class Professor : Funcionario
    {
        private int _NHorasAula;

        public int NHorasAula
        {
            get { return _NHorasAula; }
            set { _NHorasAula = value; }
        }

        private string _Titulacao;

        public string Titulacao
        {
            get { return _Titulacao; }
            set { _Titulacao = value; }
        }

        public void CadastroProfessor()
        {
            Cadastro();

            Console.WriteLine("Número de Horas/Aula Semanais:");
            _NHorasAula = int.Parse(Console.ReadLine());

            Console.WriteLine("Titulação....................:");
            _Titulacao = Console.ReadLine();
            Console.ReadKey();
        }

        public void RelatorioProfessor()
        {
            Relatorio();

            Console.WriteLine("Número de Horas/Aula Semanal: {0}", _NHorasAula);
            Console.WriteLine("Titulação: {0}", _Titulacao);
            Console.ReadKey();
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            ArrayList MeusFuncionariosA = new ArrayList();
            ArrayList MeusFuncionariosP = new ArrayList();
            AreaAdministrativa Adm;
            Professor MeuProfessor;
            int op;
            char tipo;

            do
            {
                Console.Clear();
                Console.WriteLine("----------------Menu de Opções----------------");
                Console.WriteLine("1 - Cadastro ");
                Console.WriteLine("2 - Relatório");
                Console.WriteLine("0 - Sair");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine("Digite o tipo de Funcionário: (A - Área Administrativa ou P - Professor)");
                            tipo = char.Parse(Console.ReadLine().ToUpper());


                            if (tipo == 'A')
                            {
                                Adm = new AreaAdministrativa();
                                Adm.Tipo = tipo;

                                Adm.CadastroAdministrativo();
                                MeusFuncionariosA.Add(Adm);
                            }

                            if (tipo == 'P')
                            {
                                MeuProfessor = new Professor();
                                MeuProfessor.Tipo = tipo;

                                MeuProfessor.CadastroProfessor();
                                MeusFuncionariosP.Add(MeuProfessor);
                            }

                            if (tipo != 'A' && tipo != 'P')
                            {
                                Console.WriteLine("Tipo Inválido!");
                            }

                            Console.WriteLine("Enter para Cadastra Novo Funcionário ou ESC para Sair");
                        } while (Console.ReadKey().Key != ConsoleKey.Escape);
                   break;

                   case 2:

                        Console.WriteLine("----------------Relatório de Funcionários----------------");

                        Console.WriteLine("------Área Administrativa-------");
                        foreach (AreaAdministrativa x in MeusFuncionariosA)
                        {
                            x.RelatorioAdministrativo();
                            Console.WriteLine();
                        }

                        Console.WriteLine("\n------Professores-------");
                        foreach(Professor x in MeusFuncionariosP)
                        {
                            x.RelatorioProfessor();
                            Console.WriteLine();
                        }

                   break;

                    default:
                        Console.WriteLine("Opção Inválida!");
                    break;



                }

            } while (op != 0);
        }
    }
}
