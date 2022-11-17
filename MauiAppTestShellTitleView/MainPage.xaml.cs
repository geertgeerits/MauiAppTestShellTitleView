namespace MauiAppTestShellTitleView;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private async void OnOpenNewPage1(object sender, EventArgs e)    {
        await Navigation.PushAsync(new NewPage1());
    }

}

