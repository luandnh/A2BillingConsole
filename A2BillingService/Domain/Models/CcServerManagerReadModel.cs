using System;
using System.Collections.Generic;

namespace A2BillingService.Domain.Models
{
    public partial class CcServerManagerReadModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public int? IdGroup { get; set; }

        public string ServerIp { get; set; }

        public string ManagerHost { get; set; }

        public string ManagerUsername { get; set; }

        public string ManagerSecret { get; set; }

        public DateTime LasttimeUsed { get; set; }

        #endregion

    }
}
