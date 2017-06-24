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
    public partial class DatsPerson : Window
    {
        //instanciacion de persona el delegado con su firma de delegado 
        private Person Person { get; set; }
        public delegate void GetPerson(Person persons);
        public event GetPerson OnAccept;
        public DatsPerson()
        {
            InitializeComponent();
            //inicializando person
            Person = new Person();
        }

        public DatsPerson(Person persons) : this()
		{
            //Textboxs tomando valores repectivos
            TbName.Text = persons.Name;
            TbLastnameDad.Text = persons.LastnameDad;
            TbLastnameMom.Text = persons.LastnameMom;
            TbTelephone.Text = persons.Telephone;
            TbCelular.Text = persons.Celular;
            TbAddress.Text = persons.Address;
            TbRedSocial.Text = persons.Red_Social;
            Person = persons;
		}
        //metodo cancelar
		private void BtnCancel_Click(object sender, RoutedEventArgs e)
		{
			Close();
		}
        //metodo de boton aceptar
		private void BtnAccept_Click(object sender, RoutedEventArgs e)
		{
            //Datos ingresados a los textbox
			Person.Name= TbName.Text;
			Person.LastnameDad = TbLastnameDad.Text;
            Person.LastnameMom = TbLastnameMom.Text;
			Person.Telephone = TbTelephone.Text;
            Person.Celular = TbCelular.Text;
            Person.Address = TbAddress.Text;
            Person.Red_Social = TbRedSocial.Text;
			OnAccept(Person);
			Close();
		}

    
    }
}
