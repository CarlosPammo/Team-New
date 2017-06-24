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
                                       //Id=1,
										Name = "Marco Anthony",
                                        LastnameDad="Flores",
                                        LastnameMom="Zarate",
                                        Celular="79398841",
										Telephone = "4725726",
										Address="Pacata Alta",
                                        city="Cochabamba",
                                        Red_Social="Macros-Facebook.com"
								   },
                                   new Person
								   {
                                       //Id=2,
										Name = "Diana",
                                        LastnameDad="Guzman",
                                        LastnameMom="Rojas",
                                        Celular="79398851",
										Telephone = "4725726",
										Address="Pacata Alta",
                                        city="Cochabamba",
                                        Red_Social="Maya-Facebook.com"
								   }
				           };

            DGListPerson.DataContext = Persons;
            DGListPerson.Items.Refresh();
        }

        private void Btn_Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void Btn_New_Click(object sender, RoutedEventArgs e)
        {
            DatsPerson editor = new DatsPerson();
            editor.OnAccept += AddNewPerson;
            editor.Show();
        }
        private void AddNewPerson(Person person)
        {
            Persons.Add(person);
            DGListPerson.DataContext = Persons;
            DGListPerson.Items.Refresh();
        }
        private void Update_Click(object sender, RoutedEventArgs e)
        {
            Person selected = (Person)DGListPerson.SelectedItem;
            DatsPerson editor = new DatsPerson(selected);
            editor.OnAccept += EditContact;
            editor.Show();
        }
        private void EditContact(Contact contact)
        {
            DGListPerson.Items.Refresh();
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            Person selected = (Person)DGListPerson.SelectedItem;
            Persons.Remove(selected);
            DGListPerson.Items.Refresh();
        }

        private void Btn_Search_Click(object sender, RoutedEventArgs e)
        {
            DGListPerson.DataContext = Persons
                // Obtiene todos los contactos cuya propiedad Name 
                // Contenga el texto del texbnox Search
                .Where(c => c.Name.Contains(TbSearch.Text));
            DGListPerson.Items.Refresh();
        }
    }
}