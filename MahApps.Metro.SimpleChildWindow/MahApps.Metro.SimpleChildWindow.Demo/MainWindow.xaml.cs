﻿using System.ComponentModel;
using System.Windows;
using MahApps.Metro.Controls;

namespace MahApps.Metro.SimpleChildWindow.Demo
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : MetroWindow
	{
		public MainWindow()
		{
			this.InitializeComponent();
		}

		private void FirstTest_OnClick(object sender, RoutedEventArgs e)
		{
			this.child01.IsOpen = true;
		}

		private async void SecTest_OnClick(object sender, RoutedEventArgs e)
		{
			await this.ShowChildWindowAsync(new TestChildWindow(), this.RootGrid);
		}

		private async void ThirdTest_OnClick(object sender, RoutedEventArgs e)
		{
			await this.ShowChildWindowAsync(new CoolChildWindow() {IsModal = false}, RootGrid);
		}

		private void CloseFirst_OnClick(object sender, RoutedEventArgs e)
		{
			this.child01.Close();
		}

		private void Child01_OnClosing(object sender, CancelEventArgs e)
		{
			//e.Cancel = true; // don't close
		}

		private async void MovingTest_OnClick(object sender, RoutedEventArgs e)
		{
			await this.ShowChildWindowAsync(new CoolChildWindow() {IsModal = true, AllowMove = true}, RootGrid);
		}
	}
}