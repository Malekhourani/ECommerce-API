using System;

namespace App.Application.DTOs.Product
{
    public class GetGeneralProductInfoDto
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
