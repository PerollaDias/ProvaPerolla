using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova3bm
{
    class FuncionarioADM : Funcionario
    {  
        public string Funcao { get; set; }
        public FuncionarioADM(string nome, string cPF, string matricula, DateTime datanasc, string sexo, double salario, string Funcao) 
            : base(nome, cPF, matricula, datanasc, sexo, salario)
        {
            this.Funcao = Funcao;
        }

        

        public override string Info()
        {
            return base.Info() + $" Função: {Funcao}";
         }




    }
}
