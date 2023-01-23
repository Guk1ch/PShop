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

namespace PShop.Pages
{
	/// <summary>
	/// Логика взаимодействия для EditPenPage.xaml
	/// </summary>
	public partial class EditPenPage : Page
	{ public static Pen pen2 { get; set; }
		public EditPenPage(Pen pen)
		{
			InitializeComponent();
			pen2 = pen;
			DataContext = pen2;
		}

		private void btnSave_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btnBack_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.Navigate(new OnePenPage(pen2));
		}
	}
}
