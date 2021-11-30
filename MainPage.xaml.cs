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
			ReadClipboard();
		}

		private void ReadClipboard()
        {
			if (Clipboard.HasText)
			{
				Chcode.Text = Clipboard.GetTextAsync().GetAwaiter().GetResult();
            }
		}

		private void BtnBevestig_Clicked(object sender, EventArgs e)
		{
			count++;
			BtnClicked.Text = $"{count} keer geklikt.";
			Prgrss.Progress = count > 10 ? 1 : count * .1;
		}
	}
}
