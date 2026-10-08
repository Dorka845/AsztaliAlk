using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebshopRefactoring
{
    internal class BankTransferPayment : IPaymentMethod
    {
        private readonly string cardNumber;

        public BankTransferPayment(string cardNumber)
        {
            this.cardNumber = cardNumber;
        }

        public string Name => "Credit card";

        public bool Pay(decimal amount)
        {
            string lastFourDigits = cardNumber.Substring(cardNumber.Length - 4);
            Console.WriteLine("Charging " + amount.ToString("0") + " HUF to card ending " + lastFourDigits);
            return true;
        }
    }
}
