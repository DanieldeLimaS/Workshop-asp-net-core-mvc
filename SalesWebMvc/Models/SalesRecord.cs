using System;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public ESaleStatus status { get; set; }
        public Seller Seller { get; set; }
        public SalesRecord()
        {

        }

        public SalesRecord(int id, DateTime date, double amount, ESaleStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            this.status = status;
            Seller = seller;
        }
    }
    public enum ESaleStatus : int
    {
        Pending=0,
        Billed = 1,
        Canceled = 2,
    }
}
