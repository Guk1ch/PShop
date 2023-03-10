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
	/// Логика взаимодействия для AuthorisPage.xaml
	/// </summary>
	public partial class AuthorisPage : Page
	{
		public static User user { get; set; }
		public AuthorisPage()
		{
			InitializeComponent();
		}
		private void btnRegClick(object sender, RoutedEventArgs e)
		{
			NavigationService.Navigate(new RegPage());
		}

		private void btnEnterClick(object sender, RoutedEventArgs e)
		{
			string login = tbLog.Text.Trim();
			string password = tbPass.Password.Trim();
			user = BdConnection.connection.User.Where(x => x.Login == login && x.Password == password).FirstOrDefault();
			if(user == null)
			{
				MessageBox.Show("Все не гуд");
			}
			else if (user != null)
			{
				NavigationService.Navigate(new MainPage());
			}

		}
	}
}
