namespace Maui.MultiPageApps.NavigationPages;

public partial class Dog : ContentPage
{
	public Dog()
	{
		InitializeComponent();
        btnBeagle.Clicked += async(s, e) => await Shell.Current.GoToAsync("dogdetails?breed=Beagle");
		btnBulldog.Clicked += async (s, e) => await Shell.Current.GoToAsync("dogdetails?breed=Bulldog");
		btnLabrador.Clicked += async (s, e) => await Shell.Current.GoToAsync("dogdetails?breed=Labrador");
    }
}