namespace Maui.MultiPageApps.NavigationPages
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("dogdetails", typeof(DogDetail));
        }
    }
}