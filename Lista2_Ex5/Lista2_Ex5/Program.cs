using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_Ex5
{
    class Veiculo
    {
        private string _Placa;

        public string Placa
        {
            get { return _Placa; }
            set { _Placa = value; }
        }

        private string _Marca;

        public string Marca
        {
            get { return _Marca; }
            set { _Marca = value; }
        }

        private string _Modelo;

        public string Modelo
        {
            get { return _Modelo; }
            set { _Modelo = value; }
        }

        private int _Ano_Fabricacao;

        public int Ano_Fabricacao
        {
            get { return _Ano_Fabricacao; }
            set { _Ano_Fabricacao = value; }
        }

        private double _ValorKM;

        public double ValorKM
        {
            get { return _ValorKM; }
            set { _ValorKM = value; }
        }

        private double _KMInicial;

        public double KMInicial
        {
            get { return _KMInicial; }
            set { _KMInicial = value; }
        }

        private double _KMFinal;

        public double KMFinal
        {
            get { return _KMFinal; }
            set { _KMFinal = value; }
        }

        private double _ValorLocacaoIndividual;

        public double ValorLocacaoIndividual
        {
            get { return _ValorLocacaoIndividual; }
            set { _ValorLocacaoIndividual = value; }
        }

        private char _Tipo;

        public char Tipo
        {
            get { return _Tipo; }
            set { _Tipo = value; }
        }

        public void Cadastra()
        {
            Console.Clear();

            Console.WriteLine("Placa.................:");
            _Placa = Console.ReadLine();

            Console.WriteLine("Marca.................:");
            _Marca = Console.ReadLine();

            Console.WriteLine("Modelo................:");
            _Modelo = Console.ReadLine();

            Console.WriteLine("Ano de Fabricação.....:");
            _Ano_Fabricacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor do KM Rodado....:");
            _ValorKM = double.Parse(Console.ReadLine());

            Console.WriteLine("KM Inicial do Veículo.:");
            _KMInicial = double.Parse(Console.ReadLine());

            Console.WriteLine("KM Final do Veículo...:");
            _KMFinal = double.Parse(Console.ReadLine());

            _ValorLocacaoIndividual = (_KMFinal - _KMInicial) * _ValorKM;
        }

        public void Relatorio()
        {

            //Console.Clear();
            Console.WriteLine("Placa: {0} ", this._Placa);
            Console.WriteLine("Marca: {0} ", this._Marca);
            Console.WriteLine("Modelo: {0} ", this._Modelo);
            Console.WriteLine("Ano de Fabricação: {0} ", this._Ano_Fabricacao);
            Console.WriteLine("Valor do KM Rodado: R${0:F2} ", this._ValorKM);
            Console.WriteLine("KM Inicial do Veículo: {0:F2} ", this._KMInicial);
            Console.WriteLine("KM Final do Veículo: {0:F2} ", this._KMFinal);
        }

    }

    class Passeio : Veiculo
    {
        private string _Ar;

        public string Ar
        {
            
            get { return _Ar; }
            set { _Ar = value; }
        }

        private string _TipoCombustivel;

        public string TipoCombustivel
        {
            get { return _TipoCombustivel; }
            set { _TipoCombustivel = value; }
        }

        private int _Portas;

        public int Portas
        {
            get { return _Portas; }
            set { _Portas = value; }
        }

        public void CadastraPasseio()
        {
            Cadastra();
            //Console.WriteLine("Placa.................:");
            Console.WriteLine("Ar-Condicionado(Sim ou Não).......:");
            _Ar = Console.ReadLine();
            Console.WriteLine("Tipo de Combustível...............:");
            _TipoCombustivel = Console.ReadLine();
            Console.WriteLine("Número de Portas..................:");
            _Portas = int.Parse(Console.ReadLine());

        }

        public void RelatorioPasseio()
        {
            Relatorio();

            Console.WriteLine("Tipo: Passeio");
            Console.WriteLine("Ar-Condicionado: {0} ", this._Ar);
            Console.WriteLine("Tipo de Combustível: {0} ", this._TipoCombustivel);
            Console.WriteLine("Número de Portas: {0} ", this._Portas);
            Console.WriteLine("Valor de Locação Individual: {0:F2} ", this.ValorLocacaoIndividual);

            Console.ReadKey();
        }

        public void Pesquisa(string p)
        {
            
            if (this.Placa == p)
            {
                Console.WriteLine("Placa: {0}", p);
                Console.WriteLine("Valor de Locação Individual: {0:F2} ", this.ValorLocacaoIndividual);
            }
        }

    }

    class Carga : Veiculo
    {
        private double _CapacidadeCarga;

        public double CapacidadeCarga
        {
            get { return _CapacidadeCarga; }
            set { _CapacidadeCarga = value; }
        }

        public void CadastraCarga()
        {
            Cadastra();
            Console.WriteLine("Capacidade de Carga (em toneladas):");
            _CapacidadeCarga = double.Parse(Console.ReadLine());
            this.ValorLocacaoIndividual = ValorLocacaoIndividual * 1.1;


        }

        public void RelatorioCarga()
        {
            Relatorio();
            Console.WriteLine("Capacidade de Carga (em toneladas) : {0:F2} ", this._CapacidadeCarga);
            Console.WriteLine("Valor de Locação Individual: {0:F2} ", this.ValorLocacaoIndividual);

            Console.ReadKey();

        }

        public void Pesquisa(string p)
        {
            if(this.Placa == p)
            {
                Console.WriteLine("Placa: {0}", p);
                Console.WriteLine("Valor de Locação Individual: {0:F2} ", this.ValorLocacaoIndividual);
            }
        }


    }

    class Program
    {
        

        static void Main(string[] args)
        {
            char tipo;
            string pesquisa;

            ArrayList CadastroVeiculosP = new ArrayList();
            ArrayList CadastroVeiculosC = new ArrayList();
            Passeio MeuVeiculoPasseio;
            Carga MeuVeiculoCarga;
            int op;

            //Menu de Opções
            do
            {
                Console.Clear();
                Console.WriteLine("------------Menu de Opções----------");
                Console.WriteLine("1 - Cadastro");
                Console.WriteLine("2 - Relatório");
                Console.WriteLine("3 - Pesquisa");
                Console.WriteLine("0 - Sair..");
                op = int.Parse(Console.ReadLine());

                

                switch (op)
                {
                    case 1:
                        
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Digite o tipo de veícula a ser cadastrado: (P - Passeio ou C - Carga) ");
                            tipo = char.Parse(Console.ReadLine().ToUpper());


                            if (tipo == 'P')
                            {
                                MeuVeiculoPasseio = new Passeio();
                                MeuVeiculoPasseio.Tipo = 'P';

                                MeuVeiculoPasseio.CadastraPasseio();
                                CadastroVeiculosP.Add(MeuVeiculoPasseio);
                            }

                            if (tipo == 'C')
                            {
                                MeuVeiculoCarga = new Carga();
                                MeuVeiculoCarga.Tipo = 'C';
                                MeuVeiculoCarga.CadastraCarga();
                                CadastroVeiculosC.Add(MeuVeiculoCarga);
                            }

                            Console.WriteLine("ENTER para novo cadastro ou ESC para parar");
                        } while (Console.ReadKey().Key != ConsoleKey.Escape);
                    break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("-----------Relatório de Veículos Cadastrados -----------");

                        Console.WriteLine("--------------Veículos de Passeio--------------");
                        
                        foreach(Passeio x in CadastroVeiculosP)
                        {
                            x.RelatorioPasseio();
                            Console.WriteLine();
                        }
                        
                        Console.WriteLine("--------------Veículos de Carga--------------");

                        foreach(Carga x in CadastroVeiculosC)
                        {
                            x.RelatorioCarga();
                            Console.WriteLine();
                        }

                    break;

                    case 3:
                        //Console.WriteLine("Digite o tipo que deseja pesquisar: (P - Passeio ou C - Carga)");
                        //tipo = char.Parse(Console.ReadLine().ToUpper());
                        int cont = 0;

                        Console.WriteLine("Digite a placa que deseja pesquisar:");
                        pesquisa = Console.ReadLine();

                        foreach(Passeio x in CadastroVeiculosP)
                        {
                            x.Pesquisa(pesquisa);
                            Console.ReadKey();
                            ++cont;
                        }

                        foreach(Carga x in CadastroVeiculosC)
                        {
                            x.Pesquisa(pesquisa);
                            Console.ReadKey();
                            ++cont;
                        }

                        if (cont == 0)
                        {
                            Console.WriteLine("Placa não encontrada");
                        }
                        break;

                    default:

                        Console.WriteLine("Opção inválida!");

                    break;

                            
                }





            } while (op != 0);




            
        }
    }
}
