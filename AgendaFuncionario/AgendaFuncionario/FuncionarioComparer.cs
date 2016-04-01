using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaFuncionario
{
    class FuncionarioComparer: IComparer<Funcionario>
    {
        public int Compare(Funcionario x, Funcionario y)
        {
            return (x.Nome + " " + x.Sobrenome).CompareTo(y.Nome
+ " " + y.Sobrenome);
        }
    }
}
