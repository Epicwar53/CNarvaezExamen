using Microsoft.Maui.Controls;
namespace CNarvaezExamen.Views;

public partial class Resumen : ContentPage
{
	public Resumen()
	{
		InitializeComponent();
	}

    private async void LogoutButton_Clicked(object sender, EventArgs e)
    {
        
        await Navigation.PushAsync(new Login());
    }
}

public partial class Login : ContentPage
{
    public Login()
    {
        InitializeComponent();
    }

    private async void LoginButton_Clicked(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new Resumen());
    }
}
