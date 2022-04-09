using System;
using App.Domain.Models.Users;

namespace App.Domain.Models.Discounts.UserDiscounts
{
    public class UserDiscount
    {
        public Int64 DiscountId { get; set; }
        public Discount Discount { get; set; }

        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public static UserDiscount Factory(Int64 discountId, string userId)
        {
            return new UserDiscount
            {
                DiscountId = discountId,
                ApplicationUserId = userId
            };
        }
    }
}
