namespace UnitOfWorkPattern.Api.Dtos
{
    using System;
    using System.Collections.Generic;
    using UnitOfWorkPattern.Api.Entities;

    public class OrderDto
    {
        public int Id { get; set; }
        public string Sku { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
