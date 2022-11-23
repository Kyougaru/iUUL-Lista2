using System;
using System.Collections.Generic;

namespace iUUL_Lista_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, cpf, dataNasc, rendaMensal, estadoCivil, dependentes;
            Validador validaCliente = new Validador();
            IDictionary<Enum, string> erros = new Dictionary<Enum, string>();

            Console.WriteLine("Insira o nome do cliente");
            nome = Console.ReadLine();
            Console.WriteLine("Insira o CPF do cliente");
            cpf = Console.ReadLine();
            Console.WriteLine("Insira a data de nascimento do cliente");
            dataNasc = Console.ReadLine();
            Console.WriteLine("Insira a renda mensal do cliente");
            rendaMensal = Console.ReadLine();
            Console.WriteLine("Insira o estado civil do cliente");
            estadoCivil = Console.ReadLine();
            Console.WriteLine("Insira o número de dependentes do cliente");
            dependentes = Console.ReadLine();

            do
            {
                //Valida os dados
                erros = validaCliente.ValidarCliente(nome, cpf, dataNasc, rendaMensal, estadoCivil, dependentes);

                //Imprime os erros se tiver, e pede pra inserir novamente os campos incorretos
                foreach (KeyValuePair<Enum, string> erro in erros)
                    Console.WriteLine(erro.Value);

                foreach (KeyValuePair<Enum, string> erro in erros)
                {
                    switch (erro.Key)
                    {
                        case ErrosClientes.NomeInvalido:
                            Console.WriteLine("Insira o nome do cliente");
                            nome = Console.ReadLine();
                            break;
                        case ErrosClientes.CpfInvalido:
                            Console.WriteLine("Insira o CPF do cliente");
                            cpf = Console.ReadLine();
                            break;
                        case ErrosClientes.DataNascInvalida:
                            Console.WriteLine("Insira a data de nascimento do cliente");
                            dataNasc = Console.ReadLine();
                            break;
                        case ErrosClientes.RendaMensalInvalida:
                            Console.WriteLine("Insira a renda mensal do cliente");
                            rendaMensal = Console.ReadLine();
                            break;
                        case ErrosClientes.EstadoCivilInvalido:
                            Console.WriteLine("Insira o estado civil do cliente");
                            estadoCivil = Console.ReadLine();
                            break;
                        case ErrosClientes.DependentesInvalido:
                            Console.WriteLine("Insira o número de dependentes do cliente");
                            dependentes = Console.ReadLine();
                            break;
                    }
                }
            } while (erros.Count != 0);

            //Imprime os dados corretos e encerra o programa
            Cliente c = new Cliente(nome, cpf, dataNasc, rendaMensal, estadoCivil, dependentes);
            Console.WriteLine("Nome: " + c.Nome + " CPF: " + c.Cpf + " Data Nasc: " + c.DataNasc +
                " Renda Mensal: " + c.RendaMensal + " Estado Civil: " + c.EstadoCivil +
                " Dependentes: " + c.Dependentes);
        }
    }
}
