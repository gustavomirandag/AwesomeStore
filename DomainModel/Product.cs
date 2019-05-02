using System;

namespace DomainModel
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string PhotoUrl { get; set; }
        public Decimal Price { get; set; }
    }
}
