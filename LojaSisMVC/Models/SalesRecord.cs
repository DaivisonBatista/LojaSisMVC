using LojaSisMVC.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace LojaSisMVC.Models.enums
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        [Precision(18, 2)]
        public decimal Amount { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Seller { get; set; } = null!;

        public SalesRecord() 
        { 
        }

        public SalesRecord(int id, DateTime date, decimal amount, SaleStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
