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
using PShop.DataBase;

namespace PShop.Pages
{
	/// <summary>
	/// Логика взаимодействия для AddClientPage.xaml
	/// </summary>
	public partial class AddClientPage : Page
	{
		public static Client client { get; set; }
		public AddClientPage()
		{
			InitializeComponent();
			client = new Client();
			cbType.ItemsSource = BdConnection.connection.TypeClient.ToList();
			cbType.DisplayMemberPath = "Name";
		}

		private void btnSave_Click(object sender, RoutedEventArgs e)
		{
			client.Name = tbName.Text.Trim();
			client.Surname = tbSurname.Text.Trim();
			client.Lastname = tbLastname.Text.Trim();
			client.Adress = tbAdress.Text.Trim();
			client.Email = tbEmail.Text.Trim();
			client.Phone = tbPhone.Text.Trim();
			client.ID_Type = (cbType.SelectedItem as TypeClient).ID;
			BdConnection.connection.Client.Add(client);
			BdConnection.connection.SaveChanges();
			MessageBox.Show(" все гуд");
			NavigationService.Navigate(new ClientsPage());
		}

		private void btnBack_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.Navigate(new ClientsPage());
		}
	}
}
