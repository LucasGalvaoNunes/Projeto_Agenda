using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgendaFuncionario
{
    public class Funcionario : Pessoa
    {
        public Funcionario(){}
        public Funcionario(int salario)
        {
            Salario = salario;
        }

        public int Salario { get; set; }

    }
}