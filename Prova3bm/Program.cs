using Prova3bm;
using System;
class Program
{
    static void Main(string[] args)
    {
        List<Funcionario> funcionarios = new List<Funcionario>();
        while (true)
        {
            Console.WriteLine("Digite qual o tipo de funcionário desejado para o cadastro: " +
                "Médico, Funcionário(Administrativo) ou sair.");
            string OpcaoTipoFuncionario = Console.ReadLine();

            if (OpcaoTipoFuncionario == "Médico")
            {
                Console.WriteLine("Digite o nome: ");
                string Nome = Console.ReadLine();

                Console.WriteLine("Digite o CPF: ");
                string CPF = Console.ReadLine();

                Console.WriteLine("Digite a Matrícula: ");
                string Matricula = Console.ReadLine();

                Console.WriteLine("Digite a data de nascimento: ");
                DateTime Datanasc = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Digite o sexo: ");
                string Sexo = Console.ReadLine();

                Console.WriteLine("Digite o salário: ");
                double Salario = Double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o CRM: ");
                string CRM = Console.ReadLine();

                Console.WriteLine("Digite o valor da hora extra: ");
                double ValorHrExtra = Double.Parse(Console.ReadLine());

                Console.WriteLine("Digite a especialidade: ");
                string Especialidade = Console.ReadLine();

                Medico medico = new Medico(Nome, CPF, Matricula, Datanasc, Sexo, Salario, CRM, ValorHrExtra, Especialidade);
                funcionarios.Add(medico);

            }
            else if (OpcaoTipoFuncionario == "Funcionário(Administrativo)")
            {
                Console.WriteLine("Digite o nome: ");
                string Nome = Console.ReadLine();

                Console.WriteLine("Digite o CPF: ");
                string CPF = Console.ReadLine();

                Console.WriteLine("Digite a Matrícula: ");
                string Matricula = Console.ReadLine();

                Console.WriteLine("Digite a data de nascimento: ");
                DateTime Datanasc = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Digite o sexo: ");
                string Sexo = Console.ReadLine();

                Console.WriteLine("Digite o salário: ");
                double Salario = Double.Parse(Console.ReadLine());

                Console.WriteLine("Digite a função: ");
                string Funcao = Console.ReadLine();

                FuncionarioADM funcionarioADM = new FuncionarioADM(Nome, CPF, Matricula, Datanasc, Sexo, Salario, Funcao);
                funcionarios.Add(funcionarioADM);
            }
            if (OpcaoTipoFuncionario == "sair")
            {
                break;
            }
            Console.WriteLine("Funcionario cadastrado.");
            foreach(var funcionario in funcionarios)
            {
                Console.WriteLine(funcionario.Info());
            }
            //Me preocupei em fazer a teoria e não deu tempo de fazer os cálculos, desculpa. considere pelo menos meu esforço por favor.
        }
    }
}
