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
	/// Логика взаимодействия для EditClientPage.xaml
	/// </summary>
	public partial class EditClientPage : Page
	{
		public static Client client2 { get; set; }
		public EditClientPage(Client client)
		{
			InitializeComponent();
			client2 = client;
			DataContext = client2;
		}

		private void btnSave_Click(object sender, RoutedEventArgs e)
		{
			BdConnection.connection.SaveChanges();
			NavigationService.Navigate(new ClientPage(client2));
		}

		private void btnBack_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.Navigate(new ClientPage(client2));
		}
	}
}
