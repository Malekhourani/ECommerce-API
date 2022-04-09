using App.Domain.Models.Products;
using App.Domain.Exceptions.LogicalExceptions.OrderExceptions;

namespace App.Domain.Models.Orders.OrderProducts
{
    // TODO: We Need to add Product Price for this Model,
    // Since Shop Owner Can Change Product's Price,
    // And Because of that, we won't be able to Know Product Price when we bought it! 
    public class OrderProduct
    {
        public uint ProductId { get; set; }
        public Product Product { get; set; }

        public Guid OrderId { get; set; }
        public Order Order { get; set; }

        public uint Quantity { get; set; }

        public double PricePerPiece { get; set; }

        public static OrderProduct Factory(Guid orderId, uint productId, uint quantity, double pricePerPiece)
        {
            return new OrderProduct
            {
                OrderId = orderId,
                ProductId = productId,
                Quantity = quantity,
                PricePerPiece = pricePerPiece
            };
        }

        public void ChangeProductQuantity(uint newQuantity)
        {
            ValidateProductsNewQuantity(newQuantity);

            if (newQuantity > Quantity)
                IncreaseProductQuantity(newQuantity);

            else
                DecreaseProductQuantity(newQuantity);
        }

        public void IncreaseProductQuantity(uint newQuantity)
        {
            Quantity += newQuantity;

            Order.IncreaseOrderCost(newQuantity, Product.Price);
        }

        public void DecreaseProductQuantity(uint newQuantity)
        {
            Quantity -= newQuantity;

            Order.DecreaseOrderCost(newQuantity, Product.Price);
        }

        private void ValidateProductsNewQuantity(uint newQuantity)
        {
            if (newQuantity == Quantity) throw new NewQuantityIsTheSameAsOldQuantityException();

            Product.ValidateNewProductsQuantity(newQuantity);
        }
    }
}
