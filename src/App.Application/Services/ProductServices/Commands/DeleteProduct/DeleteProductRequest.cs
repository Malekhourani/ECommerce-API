using System;
using MediatR;

namespace App.Application.Services.ProductServices.Commands.DeleteProduct
{
    public class DeleteProductRequest : IRequest
    {
        public uint Id { get; set; }
    }
}
