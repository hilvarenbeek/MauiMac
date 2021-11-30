using System;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;

namespace MauiMac
{
	public partial class MainPage : ContentPage
	{
		int count = 0;

		public MainPage()
		{
			InitializeComponent();
		}

		private void BtnBevestig_Clicked(object sender, EventArgs e)
		{
			count++;
			BtnClicked.Text = $"{count} keer geklikt.";
		}
	}
}
