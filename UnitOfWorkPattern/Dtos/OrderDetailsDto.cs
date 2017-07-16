namespace UnitOfWorkPattern.Api.Dtos
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using UnitOfWorkPattern.Api.Entities;

    public class OrderDetailsDto
    {
        public int Id { get; set; }
        [MaxLength(10)]
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
