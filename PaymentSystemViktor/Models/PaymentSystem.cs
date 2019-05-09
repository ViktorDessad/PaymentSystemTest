using System;


namespace PaymentSystemViktor.Models
{
    public class PaymentSystem
    {
        public long Id { get; set; }
        public string Mode { get; set; }
        public string Method { get; set; }
        public double Ammount { get; set; }
        public CurrencyTypes Currency { get; set; }
        public string Description { get; set; }
        public string OrderId { get; set; }
        public long CardNumber { get; set; }
        public DateTime ExpMounth { get; set; }
        public DateTime ExpYear { get; set; }
        public int CardCVV { get; set; }
        public DateTime Date { get; set; }

        

    }
}
