using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeSuivis.Models;

namespace TradeSuivis.Services
{
    public class CompanyService : ICompanyService
    {
        private SQLiteAsyncConnection _dbConnection;

        public CompanyService()
        {
            SetUpDb();
        }

        private async void SetUpDb()
        {
            if (_dbConnection == null)
            {
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Company.db3");
                _dbConnection = new SQLiteAsyncConnection(dbPath);
                await _dbConnection.CreateTableAsync<Company>();
            }
        }

        public Task<int> AddCompany(Company company)
        {
            return _dbConnection.InsertAsync(company);
        }

        public Task<int> DeleteCompany(Company company)
        {
            return _dbConnection.DeleteAsync(company);
        }

        public Task<Company> GetCompanyById(int companyId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Company>> GetCompanyList()
        {
            var companyList = await _dbConnection.Table<Company>().ToListAsync();
            return companyList;
        }

        public Task<int> UpdateCompany(Company company)
        {
            return _dbConnection.UpdateAsync(company);
        }


    }



    
}
