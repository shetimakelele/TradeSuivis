using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeSuivis.Models;

namespace TradeSuivis.Services
{
    public interface ICompanyService
    {
        Task<List<Company>> GetCompanyList();

        Task<int> AddCompany(Company company);
        Task<int> DeleteCompany(Company company);
        Task<int> UpdateCompany(Company company);
        Task<Company> GetCompanyById(int companyId);
    }
}
