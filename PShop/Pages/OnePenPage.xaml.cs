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
using Pen = PShop.DataBase.Pen;
using PShop.DataBase;

namespace PShop.Pages
{
	/// <summary>
	/// Логика взаимодействия для OnePenPage.xaml
	/// </summary>
	public partial class OnePenPage : Page
	{
		public static Pen pen1 { get; set;}
		public OnePenPage(Pen pen)
		{
			InitializeComponent();
			pen1 = pen;
			DataContext = pen1;
		}

		private void btnBack_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.Navigate(new PenPage());
		}

		private void btnEdit_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.Navigate(new EditPenPage(pen1));
		}

		private void btnDelete_Click(object sender, RoutedEventArgs e)
		{
			BdConnection.connection.Pen.Remove(pen1);
			BdConnection.connection.SaveChanges();
			NavigationService.Navigate(new PenPage());
		}
	}
}
