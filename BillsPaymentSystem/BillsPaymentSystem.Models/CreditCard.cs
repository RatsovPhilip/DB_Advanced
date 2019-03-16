namespace BillsPaymentSystem.Models
{
    using System;

    public class CreditCard
    {
        public int CreditCardId { get; set; }

        public decimal Limit { get; set; }

        public decimal MoneyOwned { get; set; }

        public decimal LimitLeft => this.Limit - this.MoneyOwned;

        public DateTime ExpirationDate { get; set; }

        //One to one relation
        public PaymentMethod PaymentMethod { get; set; }

    }
}
