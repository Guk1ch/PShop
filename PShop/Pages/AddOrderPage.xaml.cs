﻿using System;
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
	/// Логика взаимодействия для AddOrderPage.xaml
	/// </summary>
	public partial class AddOrderPage : Page
	{
		public AddOrderPage()
		{
			InitializeComponent();
		}

		private void btnSave_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btnBack_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.Navigate(new OrdersPage());
		}
	}
}
