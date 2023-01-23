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
using Pen = PShop.DataBase.Pen;

namespace PShop.Pages
{
	/// <summary>
	/// Логика взаимодействия для PenPage.xaml
	/// </summary>
	public partial class PenPage : Page
	{
		public static ObservableCollection<Pen> pens { get; set; }
		public PenPage()
		{
			InitializeComponent();
			pens = new ObservableCollection<Pen>(BdConnection.connection.Pen.ToList());
			DataContext = this;
		}

		private void btnBackClick(object sender, RoutedEventArgs e)
		{
			NavigationService.Navigate(new MainPage());
		}

		private void btnAdd_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.Navigate(new AddPenPage());
		}

		private void lvItem_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			var isSelected = lvItem.SelectedItem as Pen;
			if(isSelected != null)
			{
				NavigationService.Navigate(new OnePenPage(isSelected));
			}
		}
	}
}
