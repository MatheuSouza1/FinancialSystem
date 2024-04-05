using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class UserFinancialSystem
    {
        public int Id { get; set; }
        public string UserEmail { get; set; }
        public bool Admin { get; set; }
        public bool ActualSystem { get; set; }

        [ForeignKey("FinancialSystem")]
        [Column(Order = 1)]
        public int SystemId { get; set; }
        public virtual FinancialSystem FinancialSystem { get; set;}
    }
}
