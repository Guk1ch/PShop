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
using System.Collections.ObjectModel;
using PShop.DataBase;


namespace PShop.Pages
{
	/// <summary>
	/// Логика взаимодействия для ClientPage.xaml
	/// </summary>
	public partial class ClientPage : Page
	{ public static Client client1 { get; set; }
		public ClientPage(Client client)
		{
			InitializeComponent();
			client1 = client;
			DataContext = client1;
		}

		private void btnBack_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.Navigate(new ClientsPage());
		}

		private void btnEdit_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.Navigate(new EditClientPage(client1));
		}

		private void btnDelete_Click(object sender, RoutedEventArgs e)
		{
			BdConnection.connection.Client.Remove(client1);
			BdConnection.connection.SaveChanges();
			NavigationService.Navigate(new ClientsPage());
		}
	}
}
