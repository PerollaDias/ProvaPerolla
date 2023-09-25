using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova3bm
{
    class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Matricula { get; set; }
        public DateTime Datanasc { get; set; }
        public string Sexo { get; set; }
        public double Salario { get; set; }

        public Funcionario(string nome, string cPF, string matricula, DateTime datanasc, string sexo, double salario)
        {
            this.Nome = nome;
            this.CPF = cPF;
            this.Matricula = matricula;
            this.Datanasc = datanasc;
            this.Sexo = sexo;
            this.Salario = salario;
        }

        public virtual string Info()
        {
            return $" Nome: {Nome}, CPF: {CPF}, Matrícula: {Matricula}, Data de nascimento: {Datanasc}, Sexo: {Sexo}";
        }
    }
}
