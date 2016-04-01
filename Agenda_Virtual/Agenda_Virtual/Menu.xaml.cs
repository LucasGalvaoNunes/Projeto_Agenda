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
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        List<Pessoa> pessoascontato = new List<Pessoa>();
        Utilidade util = new Utilidade();
        public Menu()
        {
            InitializeComponent();
        }


        private void menuSair(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Close();
        }     
        private void consulta(object sender, RoutedEventArgs e)
        {

        }

        private void consultaEmpresa(object sender, RoutedEventArgs e)
        {

        }

        private void btnPessoa_Click(object sender, RoutedEventArgs e)
        {
            ContatosPessoais pessoal = new ContatosPessoais();
            pessoal.btnAltera.IsEnabled = false;
            pessoal.Show();
            this.Close();
        }

        private void btnEmpresa_Click(object sender, RoutedEventArgs e)
        {
            ContatosEmpresas empresa = new ContatosEmpresas();
           empresa. btnAltera.IsEnabled = false;
            empresa.Show();

            this.Close();
        }
    }
}
