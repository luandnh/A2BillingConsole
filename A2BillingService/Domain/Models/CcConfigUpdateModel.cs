using System;
using System.Collections.Generic;

namespace A2BillingService.Domain.Models
{
    public partial class CcConfigUpdateModel
    {
        #region Generated Properties
        public int Id { get; set; }

        public string ConfigTitle { get; set; }

        public string ConfigKey { get; set; }

        public string ConfigValue { get; set; }

        public string ConfigDescription { get; set; }

        public int ConfigValuetype { get; set; }

        public string ConfigListvalues { get; set; }

        public string ConfigGroupTitle { get; set; }

        #endregion

    }
}
