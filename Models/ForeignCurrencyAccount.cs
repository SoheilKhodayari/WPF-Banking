using System;
using System.Collections.Generic;

namespace WpfApplication1.Models
{
    public partial class ForeignCurrencyAccount
    {
        public int AId { get; set; }
        public decimal Remainder { get; set; }
        public Nullable<System.DateTime> OpeningDate { get; set; }
        public int CId_FK { get; set; }
        public int BranchId_FK { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
