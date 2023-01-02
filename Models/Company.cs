using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeSuivis.Models
{
    public class Company
    {
        [PrimaryKey, AutoIncrement]
        public int CompanyId { get; set; }

        public string Name { get; set; }

    }
}
