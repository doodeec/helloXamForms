using Xamarin.Forms;

namespace HelloForm
{
	public partial class HelloFormPage : ContentPage
	{
		public HelloFormPage()
		{
			InitializeComponent();
		}

		async void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			//TODO click handler
			await Navigation.PushAsync(new SecondPage());
			//App.Current.MainPage = new SecondPage();
		}
	}
}

