namespace PushModalTest;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		await this.Navigation.PushModalAsync(new ContentPage()
        {
			BackgroundColor = Colors.Red
        });
	}
}

