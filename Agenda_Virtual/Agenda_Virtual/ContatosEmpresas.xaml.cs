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
using System.Windows.Shapes;
using Agenda_Virtual.classes;
namespace Agenda_Virtual
{
    /// <summary>
    /// Interaction logic for ContatosEmpresas.xaml
    /// </summary>
    public partial class ContatosEmpresas : Window
    {
        Utilidade util = new Utilidade();

        List<ContatoProfissional> pessoaLista = new List<ContatoProfissional>();

        public ContatosEmpresas()
        {
            InitializeComponent();
        }

        private void btnCadastra_Click(object sender, RoutedEventArgs e)
        {
            Adciona();

        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            string nome = util.normalizarString(txbInformaNomeA.Text);
            string sobrenome = util.normalizarString(txbInformaSobrenomeA.Text);
            var mostrar = from c in pessoaLista.ToList() where c.nome == nome && c.sobrenome == sobrenome select c;

            foreach (var c in mostrar)
            {
                txbNomeC.Text = c.nome;
                txbSobrenomeC.Text = c.sobrenome;
                txbCpfC.Text = c.cpf;
                txbTelefoneC.Text = c.telefoneResidencia;
                txbCelularC.Text = c.celular;
                txbEmailC.Text = c.Email;
                txbEmpresaC.Text = c.nomeEmpresa;
                txbCnpjC.Text = c.cnpjEmpre;
                txbRuaC.Text = c.rua;
                txbBairoC.Text = c.bairro;
                txbNumeroC.Text = c.numero;
                btnAltera.IsEnabled = true;
            }
        }

        private void btnAltera_Click(object sender, RoutedEventArgs e)
        {
            btnAltera.IsEnabled = true;
            string nomeAltera = util.normalizarString(txbInformaNomeA.Text);
            string sobrenomeAltera = util.normalizarString(txbInformaSobrenomeA.Text);
            var excluir = from c in pessoaLista.ToList() where c.nome == nomeAltera && c.sobrenome == sobrenomeAltera select c;

            foreach (var c in excluir)
            {
                pessoaLista.Remove(c);
            }
            Adciona();
            lbPesquisa.Items.Clear();
            btnAltera.IsEnabled = false;
        }

        private void btnExclui_Click(object sender, RoutedEventArgs e)
        {
            string nome = util.normalizarString(txbInformaNomeA.Text);
            string sobrenome = util.normalizarString(txbInformaSobrenomeA.Text);
            var list = (from c in pessoaLista
                        where c.nome == nome && c.sobrenome == sobrenome
                        select c).ToList();

            list.ForEach(c => { lbContatos.Items.Remove("Nome: " + c.nome + " " + c.sobrenome + "\nCPF: " + c.cpf + "\nTelefone: " + c.telefoneResidencia + "\nCelular: " + c.celular + "\nEmail: " + c.Email + "\nEmpresa: " + c.nomeEmpresa + "\nCNPJ: " + c.cnpjEmpre + "\nRua: " + c.rua + "\nBairo: " + c.bairro + "\nNumero: " + c.numero); });

            var excluir = from c in pessoaLista.ToList() where c.nome == nome && c.sobrenome == sobrenome select c;

            foreach (var c in excluir)
            {
                pessoaLista.Remove(c);
            }
            lbPesquisa.Items.Clear();

        }

        private void btnPesquisa_Click(object sender, RoutedEventArgs e)
        {
            string nome = util.normalizarString(txbInformaNomeA.Text);
            string sobrenome = util.normalizarString(txbInformaSobrenomeA.Text);
            var list = (from c in pessoaLista
                        where c.nome == nome && c.sobrenome == sobrenome
                        select c).ToList();

            lbPesquisa.Items.Clear();

            list.ForEach(c => { lbPesquisa.Items.Add("Nome: " + c.nome + " " + c.sobrenome + "\nCPF: " + c.cpf + "\nTelefone: " + c.telefoneResidencia + "\nCelular: " + c.celular + "\nEmail: " + c.Email + "\nEmpresa: " + c.cnpjEmpre + "\nCNPJ: " + c.cnpjEmpre + "\nRua: " + c.rua + "\nBairo: " + c.bairro + "\nNumero: " + c.numero); });

        }

        private void voltaMenu(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
        private void Adciona()
        {
            string nome = txbNomeC.Text;
            nome = util.normalizarString(nome);
            if (nome == "")
            {
                MessageBox.Show("Insira um Nome!!");
                txbNomeC.Focus();
                return;
            }
            else
            {
                string sobrenome = txbSobrenomeC.Text;
                sobrenome = util.normalizarString(sobrenome);
                if (sobrenome == "")
                {
                    MessageBox.Show("informe um Sobrenome!!");
                    txbSobrenomeC.Focus();
                }
                else
                {

                    if (!util.validaCpf(txbCpfC.Text))
                    {
                        MessageBox.Show("Informe um CPF valido !!");
                        txbCpfC.Focus();
                    }
                    else
                    {

                        if (!util.validarTelefone(txbCelularC.Text))
                        {
                            MessageBox.Show("Informe o celular");
                            txbCelularC.Focus();
                        }
                        else
                        {

                            if (!util.validarTelefone(txbTelefoneC.Text))
                            {
                                MessageBox.Show("Telefone Incorreto!!");
                                txbTelefoneC.Focus();
                            }
                            else
                            {
                                if (txbEmailC.Text == "")
                                {
                                    MessageBox.Show("Email Invalido!");
                                    txbEmailC.Focus();
                                }
                                else
                                {
                                    string nomeEmpresa = txbEmpresaC.Text;
                                    if (nomeEmpresa == "")
                                    {
                                        MessageBox.Show("Informe o Nome da Empresa");
                                        txbEmpresaC.Focus();
                                    }
                                    else
                                    {
                                        if (!util.validaCnpj(txbCnpjC.Text))
                                        {
                                            MessageBox.Show("Informe Um CNPJ  valido!");
                                            txbCnpjC.Focus();
                                        }
                                        else
                                        {
                                            if (txbRuaC.Text == "")
                                            {
                                                MessageBox.Show("Informe Uma rua!!");
                                                txbRuaC.Focus();

                                            }
                                            else
                                            {
                                                if (txbBairoC.Text == "")
                                                {
                                                    MessageBox.Show("Informe Um bairo!!");
                                                    txbBairoC.Focus();
                                                }
                                                else
                                                {
                                                    if (txbNumeroC.Text == "")
                                                    {
                                                        MessageBox.Show("Informe Um Numero!!");
                                                        txbNumeroC.Focus();
                                                    }
                                                    else
                                                    {
                                                        ContatoProfissional pessoa = new ContatoProfissional();
                                                        

                                                        pessoa.nome = nome;
                                                        pessoa.sobrenome = sobrenome;
                                                        pessoa.cpf = txbCpfC.Text;
                                                        pessoa.celular = txbCelularC.Text;
                                                        pessoa.telefoneResidencia = txbTelefoneC.Text;
                                                        pessoa.Email = txbEmailC.Text;
                                                        pessoa.nomeEmpresa = txbEmpresaC.Text;
                                                        pessoa.cnpjEmpre = txbCnpjC.Text;
                                                        pessoa.rua = txbRuaC.Text;
                                                        pessoa.bairro = txbBairoC.Text;
                                                        pessoa.numero = txbNumeroC.Text;

                                                        
                                                        pessoaLista.Add(pessoa);

                                                        lbContatos.Items.Clear();


                                                        pessoaLista.ForEach(c => { lbContatos.Items.Add("Nome: " + c.nome + " " + c.sobrenome + "\nCPF: " + c.cpf + "\nTelefone: " + c.telefoneResidencia + "\nCelular: " + c.celular + "\nEmail: " + c.Email + "\nEmpresa: " + c.nomeEmpresa + "\nCNPJ: " + c.cnpjEmpre + "\nRua: " + c.rua + "\nBairo: " + c.bairro + "\nNumero: " + c.numero); });
                                                        LimpaDados();

                                                    }
                                                }
                                            }
                                        }

                                    }
                                }

                            }
                        }
                    }
                }
            }
        }
        private void LimpaDados()
        {
            txbNomeC.Text = "";
            txbSobrenomeC.Text = "";
            txbCpfC.Text = "";
            txbTelefoneC.Text = "";
            txbCelularC.Text = "";
            txbEmailC.Text = "";
            txbEmpresaC.Text = "";
            txbCnpjC.Text = "";
            txbRuaC.Text = "";
            txbBairoC.Text = "";
            txbNumeroC.Text = "";
        }

    }

}
