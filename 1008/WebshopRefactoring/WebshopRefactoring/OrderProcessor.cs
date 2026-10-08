namespace WebshopRefactoring;

public class OrderProcessor
{
    private readonly EmailNotifier notifier;
    private readonly IPaymentMethod payment;
    private readonly InvoicePrinter invoicePrinter = new InvoicePrinter();
    private readonly ShippingLabelPrinter labelPrinter = new ShippingLabelPrinter();

    public OrderProcessor(EmailNotifier notifier, IPaymentMethod payment)
    {
        this.notifier = notifier;
        this.payment = payment;
    }

    public void Process(Order order)
    {
        Console.WriteLine("Payment method: " + payment.Name);

        // 9. feladat (Inline Variable)
        // A totalToPay változót csak egyszer használjuk fel, a következő sorban, ezért nem kell
        // külön változóba tenni. Állj a változó nevére a deklarációnál, Ctrl+., majd
        // Inline temporary variable. Próbáld ki a success változóval is.
        if (!payment.Pay(order.CalculateTotal()))
        {
            Console.WriteLine("Payment failed, the order was not processed.");
            return;
        }

        Address address = new Address();
        address.Street = order.Customer.Street;
        address.City = order.Customer.City;
        address.ZipCode = order.Customer.ZipCode;
        address.Country = order.Customer.Country;

        invoicePrinter.Print(order);
        labelPrinter.Print(order.GetCustomerName(), address);
        notifier.SendOrderConfirmation(order);
        notifier.SendShippingNotice(order);
    }
}
