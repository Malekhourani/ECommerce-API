using System;
using App.Domain.Models.Discounts.DiscountActivationInfo.DiscountActivateCondition;
using Microsoft.EntityFrameworkCore;

namespace App.Domain.Models.Discounts.DiscountActivationInfo
{
    [Keyless]
    public class ActivationInfo
    {
        public int MinValueToActivateDiscount { get; set; }

        public Int64 DiscountId { get; set; }
        public Discount Discount { get; set; }

        public short ActivateConditionId { get; set; }
        public ActivateCondition ActivateCondition { get; set; }

        public static ActivationInfo Factory(int minValue, Int64 discountId, short activateConditionId)
        {
            return new ActivationInfo
            {
                MinValueToActivateDiscount = minValue,
                ActivateConditionId = activateConditionId,
                DiscountId = discountId
            };
        }
    }
}
