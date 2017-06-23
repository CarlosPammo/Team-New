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
    /// Lógica de interacción para RegisterPerson.xaml
    /// </summary>
    public partial class RegisterPerson : Window
    {
        private List<Person> Persons { get; set; }
        public delegate void GetPerson(Person Person);
        public RegisterPerson()
        {
            InitializeComponent();
            InitRP();
        }
        public void InitRP()
        {
            Persons = new List<Person>
				           {
							   new Person
								   {
										Name = "Marco Anthony",
                                        LastnameDad="Flores",
                                        LastnameMom="Zarate",
                                        Celular="79398841",
										Telephono = "4725726",
										Address="Pacata Alta",
                                        city="Cochabamba",
                                        Red_Social="Macros-Facebook.com"
								   },
				           };

            DGListPerson.DataContext = Persons;
            DGListPerson.Items.Refresh();
        }

        private void Btn_Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

    }
}