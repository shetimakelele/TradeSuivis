using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeSuivis.Models
{
    public class Transaction { 

        public int TransactionId { get; set; }

        public string TransactionName { get; set; } = string.Empty;

        public string TransactionType { get; set; }

        public string TransactionDescription { get; set; }

        public DateTime TransactionDate { get; set; }

        public int CompanyId { get; set; }

        public virtual Company company { get; set; }

    }
}
