using System;
using System.Collections.Generic;

namespace A2BillingService.Domain.Models
{
    public partial class CcAutorefillReportReadModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public DateTime Daterun { get; set; }

        public int? Totalcardperform { get; set; }

        public decimal? Totalcredit { get; set; }

        #endregion

    }
}
