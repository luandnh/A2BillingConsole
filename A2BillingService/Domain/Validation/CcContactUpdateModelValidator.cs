using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcContactUpdateModelValidator
        : AbstractValidator<CcContactUpdateModel>
    {
        public CcContactUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
