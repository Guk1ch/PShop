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
	/// Логика взаимодействия для ClientsPage.xaml
	/// </summary>
	public partial class ClientsPage : Page
	{
		public static ObservableCollection<Client> clients { get; set; }
		public ClientsPage()
		{
			InitializeComponent();
			clients = new ObservableCollection<Client>(BdConnection.connection.Client.ToList());
			DataContext = this;
		}

		private void btnAdd_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.Navigate(new AddClientPage());
		}

		private void lvItem_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			var isSelected = lvItem.SelectedItem as Client;
			if (isSelected != null)
			{
				NavigationService.Navigate(new ClientPage());
			}
		}

		private void btnBack_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.Navigate(new MainPage());
		}
	}
}
