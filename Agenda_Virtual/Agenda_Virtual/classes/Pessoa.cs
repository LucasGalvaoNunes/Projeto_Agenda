using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Virtual.classes
{
    class Pessoa : Endereco
    {

        public string nome { get; set; }
        public string sobrenome { get; set; }
        public string telefoneResidencia { get; set; }
        public string celular { get; set; }
        public string cpf { get; set; }
        public string Email { get; set; }


        public String toString()
        {
            Amigos pessoa = new Amigos();
            string info = "Nome:" + nome + " " + sobrenome + "\nCPF: " + cpf + "\nTelefone: " + telefoneResidencia + "\nCelular: " + celular + "\nEmail: " + Email + "\nData Aniversario: " + pessoa.dataAniversario + "\nFacebook: " + pessoa.facebook;
            return info;
        }

    }
}
