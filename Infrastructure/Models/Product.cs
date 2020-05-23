using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Models
{
    public class Product
    {
        public long ProductId { get; set; }
        public long CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
    }
}
