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
        //Lista de ingreso y salida de personas
        private List<Person> Persons { get; set; }
        public RegisterPerson()
        {
            InitializeComponent();
            //inicializando el metodo InitRP para lista
            InitRP();
        }
        public void InitRP()
        {
            //variable Persons para la lista 
            Persons = new List<Person>
				           {
                //Personas existentes en la lista  Person
							   new Person
								   {
                                       
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
            //Muestra de los contactos existentes en el DataContext
            DGListPerson.DataContext = Persons;
            DGListPerson.Items.Refresh();
        }
        //Metodo para boton Cerrar 
        private void Btn_Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        //Metodo para boton de Nuevo Contacto Persona
        private void Btn_New_Click(object sender, RoutedEventArgs e)
        {
            //Ventana DatsPerson para registrar un nuevo Contacto Persona
            DatsPerson editor = new DatsPerson();
            editor.OnAccept += AddNewPerson;
            editor.Show();
        }
        //Metedo de añadir
        private void AddNewPerson(Person person)
        {
            //Añadiendo los datos que se le paso de la ventana DatsPerson a la DataContext y en si refrescando los items existentes
            Persons.Add(person);
            DGListPerson.DataContext = Persons;
            DGListPerson.Items.Refresh();
        }
        //Metodo de editar
        private void Update_Click(object sender, RoutedEventArgs e)
        {
            //Persona seleccionada a editar llamando a la ventana DatsPerson para el ingreso de los nuevos Datos de personas seleccionada
            Person selected = (Person)DGListPerson.SelectedItem;
            DatsPerson editor = new DatsPerson(selected);
            editor.OnAccept += EditContact;
            editor.Show();
        }
        //Metodo de boton editar añadadido al DataGrid ListPerson y actualizando los datos nuevos
        private void EditContact(Contact contact)
        {
            DGListPerson.Items.Refresh();
        }
        //Metodo eliminar 
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            //Persona seleccionada a eliminar removiendolo del la Lista y actualizando lista
            Person selected = (Person)DGListPerson.SelectedItem;
            Persons.Remove(selected);
            DGListPerson.Items.Refresh();
        }
        //Metodo de busqueda por nombre
        private void Btn_Search_Click(object sender, RoutedEventArgs e)
        {
            //Hace una busqueda en la lista cuyos Nombres se encuentre en el textBox de Search 
            DGListPerson.DataContext = Persons.Where(c => c.Name.Contains(TbSearch.Text));
            DGListPerson.Items.Refresh();
        }
    }
}