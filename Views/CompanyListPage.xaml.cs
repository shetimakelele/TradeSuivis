using TradeSuivis.ViewModels;

namespace TradeSuivis.Views;

public partial class CompanyListPage : ContentPage
{
	public CompanyListPage(CompanyListPageViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext= viewModel;
	}
}