using TradeSuivis.Views;

namespace TradeSuivis;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(AddUpdateCompany), typeof(AddUpdateCompany));
	}
}
