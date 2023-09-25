using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova3bm
{
    class Medico : Funcionario
    {
        private string? nomeMed;
        private string? cpfMed;
        private string? matricMed;
        private DateTime datanascMed;
        private string? sexoMed;
        private double salarioMed;
        private string? crmMed;
        private double valorHrExtraMed;
        private string? especialidadeMed;

        public string CRM { get; set; }
        public double ValorHrExtra { get; set; }
        public string Especialidade { get; set; }

        public Medico(string nome, string cPF, string matricula, DateTime datanasc, string sexo, double salario, 
            string CRM, double ValorHrExtra, string Especialidade) 
            : base(nome, cPF, matricula, datanasc, sexo, salario)
        {
            this.CRM = CRM;
            this.ValorHrExtra = ValorHrExtra;
            this.Especialidade = Especialidade;
        }


        public override string Info()
        {
            return base.Info() + $" CRM:{CRM}, Valor Extra: {ValorHrExtra}, Especialidade {Especialidade}";
        }

    }
}
