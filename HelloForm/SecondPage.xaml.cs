using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloForm
{
	public partial class SecondPage : ContentPage
	{
		public SecondPage()
		{
			InitializeComponent();
		}

		async void OnButtonClicked(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new AnotherPage());
		}
	}
}

