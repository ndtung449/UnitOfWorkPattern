namespace UnitOfWorkPattern.Api.Entities
{
    using System;
    using System.Collections.Generic;

    public class Order
    {
        public int Id { get; set; }
        public string Sku { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
