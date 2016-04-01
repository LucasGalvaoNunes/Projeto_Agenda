using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Virtual.classes
{
    class Utilidade
    {
        public Utilidade()
        {

        }
        public string normalizarString(string str)
        {
            string aux = str;
            aux = aux.Trim().ToUpper();
            string[] split = aux.Split(new char[] { ' ' });
            string nome = "";
            for (int i = 0; i < split.Length; i++)
            {
                string s = split[i];
                if (!s.Equals(""))
                {
                    nome += s;
                    if (i < split.Length - 1)
                    {
                        nome += " ";                    }
                    }

            }

            return nome;
        }

        public Boolean validarTelefone(string telefone)
        {            
            char[] prefixo = null;
            char[] numero = null;
            try               
            {
                prefixo = telefone.ToCharArray(1, 2);
                if ((prefixo[0] == ' ' && prefixo[1] != ' ') || (prefixo[0] != ' ' && prefixo[1] == ' '))
                {
                    
                    return false;
                }
                try
                    
                {
                    numero = (telefone.Substring(5, 4) + telefone.Substring(10, 4)).ToCharArray(0, 8);
                    foreach (char c in numero)
                    {
                        if (c == ' ')
                        {
                           
                            return false;
                        }
                    }
                    return true;
                }
                catch 
                {
                   
                    return false;
                }
            }
            catch 
            {
              
                return false;
            }
        }
        public Boolean validaCnpj(string cnpj)
        {
            char[] valorcnpj = null;            
            try
            {
                valorcnpj = (cnpj.Substring(0, 2) + cnpj.Substring(3, 3) + cnpj.Substring(7, 3) + cnpj.Substring(11, 4) + cnpj.Substring(16, 2)).ToCharArray(0, 14);
                foreach(char c in valorcnpj)
                {
                    if(c == ' ')
                    {
                        return false;
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Boolean validaCpf(string cpf)
        {            
            char[] valorcpf = null;
            try
            {
                valorcpf = (cpf.Substring(0, 3) + cpf.Substring(4, 3) + cpf.Substring(8, 3) + cpf.Substring(12, 2)).ToCharArray(0, 11);
                foreach (char c in valorcpf)
                {
                    if (c == ' ')
                    {
                        return false;
                    }

                }
                return true;
            }
            catch
            {
                return false;
            }           
           
        }

       
    }
}
