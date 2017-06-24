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
    /// Lógica de interacción para ListBusiness.xaml
    /// </summary>
    public partial class ListBusiness : Window
    {
        private List<Empresas> Empresas { get; set; }

        private Empresas Empresa { get; set; }
        public delegate void GetEmpresas(Empresas Service);
        public ListBusiness()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            Empresas = new List<Empresas>
                           {
                               new Empresas
                                   {
                                        Name = "Comteco",
                                        Address = "Prado",
                                        Telephone = "70309082",
                                        NumNit = "12345678946",
                                        Web= "www.Comteco.com"
                                   },
                                   new Empresas
                                   {
                                        Name = "Jalasoft",
                                        Address = "Av. Simon Lopez",
                                        Telephone = "70312344",
                                        NumNit = "987654321123",
                                        Web = "www.jalasoft.com"
                                   },
                           };

            DGEmpresas.DataContext = Empresas;
            DGEmpresas.Items.Refresh();
        }
       

        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            DGEmpresas.DataContext = Empresas.Where(c => c.Name.Contains(TbSearch.Text));
            // Obtiene todos los contactos cuya propiedad Name 
            // Contenga el texto del texbnox Search

            DGEmpresas.Items.Refresh();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            DGEmpresas.DataContext = Empresas;
            Close();
        }
        private void BtnNew_Click(object sender, RoutedEventArgs e)
        {
            Window1 editor = new Window1();
            editor.OnAccept += AddNewEmpresas;
            editor.Show();
        }
        private void AddNewEmpresas(Empresas Empresa)
        {
            Empresas.Add(Empresa);
            DGEmpresas.DataContext = Empresas;
            DGEmpresas.Items.Refresh();
        }
    }
}
