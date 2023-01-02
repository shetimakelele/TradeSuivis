using TradeSuivis.ViewModels;

namespace TradeSuivis.Views;

public partial class AddUpdateCompany : ContentPage
{
	public AddUpdateCompany(AddUpdateCompanyViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext= viewModel;
	}
}