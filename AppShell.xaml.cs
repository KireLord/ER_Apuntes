namespace ER_Apuntes;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(Views.ER_NotePage), typeof(Views.ER_NotePage));
    }

}
