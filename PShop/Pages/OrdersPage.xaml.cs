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
	/// Логика взаимодействия для OrdersPage.xaml
	/// </summary>
	public partial class OrdersPage : Page
	{
		public static ObservableCollection<Order> orders { get; set; }
		public OrdersPage()
		{
			InitializeComponent();
			orders = new ObservableCollection<Order>(BdConnection.connection.Order.ToList());
			DataContext = this;
		}

		private void btnBack_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.Navigate(new MainPage());
		}

		private void btnAdd_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.Navigate(new AddOrderPage());
		}
	}
}
