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

namespace PShop.Pages
{
	/// <summary>
	/// Логика взаимодействия для MainPage.xaml
	/// </summary>
	public partial class MainPage : Page
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private void btnBackClick(object sender, RoutedEventArgs e)
		{
			NavigationService.Navigate(new AuthorisPage());
		}

	

		private void tbBtn_MouseDown(object sender, MouseButtonEventArgs e)
		{
			NavigationService.Navigate(new PenPage());
		}

		private void tbBtn_MouseEnter(object sender, MouseEventArgs e)
		{
			tbBtn.Foreground = new SolidColorBrush(Colors.Red);
		}

		private void tbBtn_MouseLeave(object sender, MouseEventArgs e)
		{
			tbBtn.Foreground = new SolidColorBrush(Colors.Black);
		}



		private void tbBtn1_MouseDown(object sender, MouseButtonEventArgs e)
		{
			NavigationService.Navigate(new ClientsPage());
		}
		private void tbBtn1_MouseEnter(object sender, MouseEventArgs e)
		{
			tbBtn1.Foreground = new SolidColorBrush(Colors.Red);
		}
		private void tbBtn1_MouseLeave(object sender, MouseEventArgs e)
		{
			tbBtn1.Foreground = new SolidColorBrush(Colors.Black);
		}


		private void tbBt2_MouseDown(object sender, MouseButtonEventArgs e)
		{
			NavigationService.Navigate(new OrdersPage());
		}
		private void tbBt2_MouseEnter(object sender, MouseEventArgs e)
		{
			tbBt2.Foreground = new SolidColorBrush(Colors.Red);
		}

		private void tbBt2_MouseLeave(object sender, MouseEventArgs e)
		{
			tbBt2.Foreground = new SolidColorBrush(Colors.Black);
		}

		

		private void btnVisblClick(object sender, RoutedEventArgs e)
		{
			spbtn.Visibility = Visibility.Visible;
		}

		private void tbCloseMouseDown(object sender, MouseButtonEventArgs e)
		{
			spbtn.Visibility=Visibility.Hidden;
		}

		private void tbCloseMouseEnter(object sender, MouseEventArgs e)
		{
			tbClose.Foreground = new SolidColorBrush(Colors.Red);
		}

		private void tbCloseMouseLeave(object sender, MouseEventArgs e)
		{
			tbClose.Foreground = new SolidColorBrush(Colors.Black);
		}
	}
}
