using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AgendaFuncionario
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string msg;
        List<Funcionario> listaContatos = new List<Funcionario>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private string normalizarString(string str)
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
                        nome += " ";
                    }
                }

            }

            return nome;
        }

        private Boolean validarTelefone(string telefone)
        {
            char[] prefixo = null;
            char[] numero = null;

            try
            {
                prefixo = telefone.ToCharArray(1, 2);

                if ((prefixo[0] == ' ' && prefixo[1] != ' ') ||
(prefixo[0] != ' ' && prefixo[1] == ' '))
                {
                    msg = "Prefixo do telefone errado!";

                    MessageBox.Show(msg);

                    return false;
                }

                try
                {
                    numero = (telefone.Substring(5, 4)
+ telefone.Substring(10, 4)).ToCharArray(0, 8);

                    foreach (char c in numero)
                    {
                        if (c == ' ')
                        {
                            msg = "Numero do telefone errado!";

                            MessageBox.Show(msg);

                            return false;
                        }
                    }

                    return true;

                }
                catch (ArgumentOutOfRangeException e)
                {
                    msg = "Erro no número do telefone! \n" + e.Message;

                    MessageBox.Show(msg);

                    return false;
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                msg = "Erro no prefixo do telefone! \n" + e.Message;

                MessageBox.Show(msg);

                return false;
            }
        }

        private void btnSeleciona_Click(object sender, RoutedEventArgs e)
        {
            if (lBFuncionarios.Items.Count > 0)
            {
                Funcionario contato =
                   listaContatos[lBFuncionarios.SelectedIndex];

                txNome.Text = contato.Nome;
                txSobrenome.Text = contato.Sobrenome;
                txTelefone.Text = contato.Telefone;
            }
            else
            {
                MessageBox.Show("Lista Vazia");
            }

            btnNovo.Focus();

        }

        private void btnAdicionar_Click(object sender, RoutedEventArgs e)
        {
            string primeiroNome = txNome.Text;
            primeiroNome = normalizarString(primeiroNome);

            if (primeiroNome.Equals(""))
            {
                msg = "Informe seu nome";
                MessageBox.Show(msg);
                txNome.Focus();
                return;
            }
            else
            {
                string sobrenome = txSobrenome.Text;

                sobrenome = normalizarString(sobrenome);

                if (sobrenome.Equals(""))
                {
                    msg = "Informe seu sobrenome";
                    MessageBox.Show(msg);
                    txSobrenome.Focus();
                    return;
                }
                else
                {
                    string telefone = txTelefone.Text;

                    if (!validarTelefone(telefone))
                    {
                        txTelefone.Focus();

                        return;
                    }
                    else
                    {

                        Funcionario funcionario = new Funcionario();
                        funcionario.Nome = primeiroNome;
                        funcionario.Sobrenome = sobrenome;
                        funcionario.Telefone = txTelefone.Text;

                        listaContatos.Add(funcionario);
                        // forma tradicional
                        // listaContatos.Sort(new FuncionarioComparer());

                        // forma usando o LINQ
                        // var list = listaContatos.OrderBy(c => c.Nome).ToList();

                        // forma decrescente no sobrenome
                        var list = (from c in listaContatos
                                    orderby c.Nome, c.Sobrenome descending
                                    select c).ToList();
                        lBFuncionarios.Items.Clear();

                        // ordem crescente

                        list.ForEach(c => {
                            lBFuncionarios.Items.Add(c.Nome
+ " " + c.Sobrenome);
                        });

                        

                        // forma tradicional
                        /* foreach (Funcionario c in listaContatos)
                         {
                             lBFuncionarios.Items.Add(c.Nome
  + " " + c.Sobrenome);
                         }*/
                    }
                }
            }
            btnNovo.Focus();
        }

        private void btnNovo_Click(object sender, RoutedEventArgs e)
        {
        
        }
    }
}

    
    
