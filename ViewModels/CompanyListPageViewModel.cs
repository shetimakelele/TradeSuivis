using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeSuivis.ViewModels
{
    public partial class CompanyListPageViewModel:ObservableObject
    {


        [RelayCommand]
        public async void AddUpdateCompany()
        {
            await AppShell.Current.GoToAsync(nameof(AddUpdateCompany));
        }
     }
}
