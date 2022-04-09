using System;
using App.Application.DTOs.Order;
using App.Application.DTOs.Product;
using App.Domain.Models.Products;

namespace App.Application.Extensions
{
    public static class IEnumerableExtensions
    {
        internal static double CalculateOrderCost(this IEnumerable<Product> products, IEnumerable<OrderProductInfoDto> orderProductInfoList)
        {
            double totalCost = 0; 

            foreach (var product in products)
            {
                var quantity = orderProductInfoList.First(productInfo => productInfo.ProductId == product.Id).Quantity;

                totalCost += product.CalculateProductCost(quantity);
            }

            return totalCost;
        }

        internal static IEnumerable<uint> SelectProductIds(this IEnumerable<OrderProductInfoDto> orderProductInfoList)
        {
            return orderProductInfoList.Select(x => x.ProductId);
        }

        internal static IEnumerable<uint> SelectProductIds(this IEnumerable<Product> products)
        {
            return products.Select(x => x.Id);
        }
    }
}
