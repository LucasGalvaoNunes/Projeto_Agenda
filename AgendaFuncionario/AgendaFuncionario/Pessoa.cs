using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgendaFuncionario
{
    public class Pessoa
    {
        public String Login { get; set; }
        public String Senha { get; set; }
        public String Nome { get; set; }
        public String Sobrenome { get; set; }
        public Char Sexo { get; set; }
        public String Telefone { get; set; }
        public String RG { get; set; }
        public String Email { get; set; }
        public long CPF { get; set; }
        public DateTime dataNasc { get; set; }
        public Endereco Endereco { get; set; }

    }
}