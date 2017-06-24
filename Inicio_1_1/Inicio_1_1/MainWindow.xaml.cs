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
using Contacts;

namespace Inicio_1_1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnRegisterPerson_Mode_Click(object sender, RoutedEventArgs e)
        {
            Person mode = new Person();
            RegisterPerson modeRegister = new RegisterPerson();
            modeRegister.Show();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Empresas mode = new Empresas();
            ListBusiness modeRegister = new ListBusiness();
            modeRegister.Show();
        }
        private void BtnService_Click(object sender, RoutedEventArgs e)
        {
            Service mode = new Service();
            ServiceMode modeService = new ServiceMode();
            modeService.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        
    }
}
