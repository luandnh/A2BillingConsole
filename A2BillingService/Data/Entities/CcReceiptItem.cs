using System;
using System.Collections.Generic;

namespace A2BillingService.Data.Entities
{
    public partial class CcReceiptItem
    {
        public CcReceiptItem()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public long Id { get; set; }

        public long IdReceipt { get; set; }

        public DateTime Date { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public long? IdExt { get; set; }

        public string TypeExt { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
