namespace ER_Apuntes.Views;

public partial class ER_AboutPage : ContentPage
{
	public ER_AboutPage()
	{
		InitializeComponent();
	}
    private async void ER_AcercaDe_Clicked(object sender, EventArgs e)
    {
        if (BindingContext is Models.About about)
        {
            // Navigate to the specified URL in the system browser.
            await Launcher.Default.OpenAsync(about.MoreInfoUrl);
        }
    }

}