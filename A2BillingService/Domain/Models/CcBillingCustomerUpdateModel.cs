using System;
using System.Collections.Generic;

namespace A2BillingService.Domain.Models
{
    public partial class CcBillingCustomerUpdateModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public long IdCard { get; set; }

        public DateTime Date { get; set; }

        public long IdInvoice { get; set; }

        public DateTime? StartDate { get; set; }

        #endregion

    }
}
