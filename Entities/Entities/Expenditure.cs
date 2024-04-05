using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Expenditure : Base
    {
        public decimal Value { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public EExpenditureType ExpenditureType { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime AltDate{ get; set; }
        public DateTime PayDate { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsPaid { get; set; }
    }
}
