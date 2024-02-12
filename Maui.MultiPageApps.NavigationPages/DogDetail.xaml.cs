namespace Maui.MultiPageApps.NavigationPages;

[QueryProperty(nameof(Breed), "breed")]
public partial class DogDetail : ContentPage
{
	private string breed;
    public string Breed 
	{ 
		get
		{
			return breed;
		}
		set
		{
			breed = value;
			lblTitle.Text = breed;
		}
	}
    public DogDetail()
	{
		InitializeComponent();
	}
}