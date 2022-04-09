using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using App.Domain.Exceptions.LogicalExceptions.OrderExceptions;
using App.Domain.Models.Common;
using App.Domain.Models.Orders.OrderProducts;
using App.Domain.Models.Orders.OrderStatuses;
using App.Domain.Models.Users;

namespace App.Domain.Models.Orders
{
    public class Order : DeletableEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Range(0, double.MaxValue)]
        [Required]
        public double Cost { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Required]
        public OrderStatus OrderStatus { get; set; } = OrderStatus.InProgress;

        [Required]
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public ICollection<OrderProduct> OrderProducts { get; set; }

        public static Order Factory(string userId, double cost)
        {
            return new Order
            {
                ApplicationUserId = userId,
                Cost = cost
            };
        }

        public void IncreaseOrderCost(uint newQuantity, double price)
        {
            Cost += newQuantity * price;
        }

        public void DecreaseOrderCost(uint newQuantity, double price)
        {
            Cost -= newQuantity * price;
        }

        public void ChangeOrderStatus(OrderStatus newOrderStatus)
        {
            if(OrderStatus == newOrderStatus)
                throw new OrderAlreadyHasThisStatusException(newOrderStatus.ToString());

            OrderStatus = newOrderStatus;
        }
    }
}
