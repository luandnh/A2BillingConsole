using System;
using System.Collections.Generic;

namespace A2BillingService.Domain.Models
{
    public partial class CcReceiptItemUpdateModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public long IdReceipt { get; set; }

        public DateTime Date { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public long? IdExt { get; set; }

        public string TypeExt { get; set; }

        #endregion

    }
}
