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
using Pen = PShop.DataBase.Pen;
using Type = PShop.DataBase.Type;

namespace PShop.Pages
{
	/// <summary>
	/// Логика взаимодействия для AddPenPage.xaml
	/// </summary>
	public partial class AddPenPage : Page
	{
		public static Pen pen { get; set; }
		public AddPenPage()
		{
			InitializeComponent();
			pen = new Pen();
			cbCompany.ItemsSource = BdConnection.connection.Company.ToList();
			cbCompany.DisplayMemberPath = "Name";
			cbType.ItemsSource = BdConnection.connection.Type.ToList();
			cbType.DisplayMemberPath = "Name";

		}

		private void btnBack_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.Navigate(new PenPage());
		}

		private void btnSave_Click(object sender, RoutedEventArgs e)
		{
			pen.ID_Company = (cbCompany.SelectedItem as Company).ID;
			pen.ID_Type = (cbType.SelectedItem as Type).ID;
			pen.Color = tbColor.Text.Trim();
			pen.Price = Convert.ToInt32(tbPrice.Text.Trim());
			pen.Size = Convert.ToInt32(tbSize.Text.Trim());
			BdConnection.connection.Pen.Add(pen);
			BdConnection.connection.SaveChanges();
			NavigationService.Navigate(new PenPage());
		}
	}
}
