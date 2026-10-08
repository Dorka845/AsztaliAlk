namespace WebshopRefactoring
{
    public interface INotifier
    {
        void SendOrderConfirmation(Order order);
        void SendShippingNotice(Order order);
    }
}