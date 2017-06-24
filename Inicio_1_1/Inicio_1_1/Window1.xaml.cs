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
using Contacts;

namespace Inicio_1_1
{
    /// <summary>
    /// Lógica de interacción para DatsPerson.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private Empresas Empresa { get; set; }
        public delegate void GetEmpresas(Empresas Empresa);
        public event GetEmpresas OnAccept;
        public Window1()
        {
            InitializeComponent();
            Empresa = new Empresas();
        }

        public Window1(Empresas Empresas) : this()
        {
            TbName.Text = Empresas.Name;
            TbAdress.Text = Empresas.Address;
            TbNit.Text = Empresas.NumNit;
            TbWebSite.Text = Empresas.Web;
            TbPhone.Text = Empresas.Telephone;
            
            Empresa = Empresas;
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnAccept_Click(object sender, RoutedEventArgs e)
        {
            Empresa.Name = TbName.Text;
            Empresa.Telephone = TbPhone.Text;
            Empresa.Address = TbAdress.Text;
            Empresa.NumNit = TbNit.Text;
            Empresa.Web = TbWebSite.Text;
            OnAccept(Empresa);
            Close();
        }


    }
}

