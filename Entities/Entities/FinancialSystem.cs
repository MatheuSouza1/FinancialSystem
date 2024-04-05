using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class FinancialSystem : Base
    {
        public int Month { get; set; }
        public int Year { get; set; }
        public int MonthlyClosing { get; set; }
        public bool CreateCopy { get; set; }
        public int CopyMonth { get; set; }
        public int CopyYear { get; set; }
    }
}
