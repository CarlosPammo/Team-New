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
    /// Lógica de interacción para ServiceMode.xaml
    /// </summary>
    public partial class ServiceMode : Window
    {
        private List<Service> Servicios { get; set; }

        private Service Service { get; set; }
        public delegate void GetService(Service Service);
        public ServiceMode()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            Servicios = new List<Service>
				           {
							   new Service
								   {
										Name = "Hospital del Niño",
										Address = "AV. Oquendo",
										Telephone = "70309082"
								   },
								   new Service
								   {
										Name = "SAR Bolivia",
										Address = "Por alli",
										Telephone = "70312344"
								   },
				           };

            DGEmergency.DataContext = Servicios;
            DGEmergency.Items.Refresh();
        }
        private void BtnAtras_Click(object sender, RoutedEventArgs e)
        {
            DGEmergency.DataContext = Servicios;
            Close();

        }

        private void BtnBuscar_Click(object sender, RoutedEventArgs e)
        {
            DGEmergency.DataContext = Servicios.Where(c => c.Name.Contains(TbBuscar.Text));
                // Obtiene todos los contactos cuya propiedad Name 
                // Contenga el texto del texbnox Search
                
            DGEmergency.Items.Refresh();
        }

        private void BtnNuevo_Click(object sender, RoutedEventArgs e)        {
            DatsSevice editor = new DatsSevice();
            editor.OnAccept += AddNewService;
            editor.Show();
        }

        private void AddNewService(Service service)
        {
            Servicios.Add(service);
            DGEmergency.DataContext = Service;
            DGEmergency.Items.Refresh();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            Service selected = (Service)DGEmergency.SelectedItem;
            Servicios.Remove(selected);
            DGEmergency.Items.Refresh();
        }

    }
}
