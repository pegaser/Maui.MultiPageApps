namespace Maui.MultiPageApps;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
	}

    private async void MenuItem_Clicked(object sender, EventArgs e)
    {
		await DisplayAlert("Alerta", "La ayuda va en camino", "OK");
    }
}
