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

namespace Agenda_Virtual
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            Menu menu = new Menu();
            if(txbUsuario.Text == "admin" && pswSenha.Password == "admin")
            {
               
                menu.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Senha/Usuario incorreto!!");
                txbUsuario.Focus();
            }
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void txbUsuario_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
