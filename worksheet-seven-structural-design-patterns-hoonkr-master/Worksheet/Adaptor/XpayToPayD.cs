namespace Adapter
{
    public class XpayToPayD : IPayD
    {
        public string CustCardNo { get; set; }
        public string CardOwnerName { get; set; }
        public string CardExpMonthDate { get; set; }
        public int CvvNo { get; set; }
        public decimal TotalAmount { get; set; }

        public static IPayD XpayToPayDAdapter(IXPay ixp)
        {
            IPayD ip = new PayDImpl();
            ip.CustCardNo = ixp.CreditCardNo;
            ip.CvvNo = ixp.CardCvvNo;
            ip.CardOwnerName = ixp.CustomerName;
            ip.CardExpMonthDate = ixp.CardExpMonth;
            ip.TotalAmount = (decimal) ixp.Amount;
            return ip;
        }

        private class PayDImpl : IPayD
        {
            public string CustCardNo { get; set; }
            public string CardOwnerName { get; set; }
            public string CardExpMonthDate { get; set; }
            public int CvvNo { get; set; }
            public decimal TotalAmount { get; set; }
        }
    }
}