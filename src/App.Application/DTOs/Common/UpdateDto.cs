using System;

namespace App.Application.DTOs.Common
{
    public class UpdateDto<TKey>
    {
        public TKey Id { get; set; }
    }
}
