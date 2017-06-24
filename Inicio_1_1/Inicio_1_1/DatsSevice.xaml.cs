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
    /// Lógica de interacción para DatsSevice.xaml
    /// </summary>
    public partial class DatsSevice : Window
    {
        private Service Service { get; set; }
        public delegate void GetService(Service services);
        public event GetService OnAccept;
        public DatsSevice()
        {
            InitializeComponent();
            Service = new Service();
        }
        public DatsSevice(Service services) : this()
		{
            TbName.Text = services.Name;
            TbTelephone.Text = services.Telephone;
            TbAddress.Text = services.Address;
            Service = Service;
		}

		private void BtnCancel_Click(object sender, RoutedEventArgs e)
		{
			Close();
		}
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Service.Name = TbName.Text;
            Service.Telephone = TbTelephone.Text;
            Service.Address = TbAddress.Text;
            OnAccept(Service);
            Close();
        }
    }
}
