using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeSuivis.Services;

namespace TradeSuivis.ViewModels
{
    public partial  class AddUpdateCompanyViewModel : ObservableObject
    {
        private readonly ICompanyService _companyService;
        public AddUpdateCompanyViewModel(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [ObservableProperty]
        private string _Name;


        [RelayCommand]
        public async void AddUpdateCompany()
        {
            var response = await  _companyService.AddCompany(new Models.Company
            {
                Name = Name
            });

            if(response > 0)
            {
                await Shell.Current.DisplayAlert("Record Added", "Record Added to Company Table", "OK");
            }
            else
            {
                await Shell.Current.DisplayAlert("Not Added", "Something went wrong", "OK");
            }
        }
    }
}
