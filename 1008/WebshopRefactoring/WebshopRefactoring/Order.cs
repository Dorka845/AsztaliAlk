namespace WebshopRefactoring;

public class Order
{
    public Customer Customer { get; }

    private readonly List<OrderLine> lines = new List<OrderLine>();
    public IReadOnlyList<OrderLine> Lines => lines;

    public Order(Customer customer)
    {
        Customer = customer;
    }

    // 1. feladat (Rename), második rész
    // A p és q paraméternevek semmit sem mondanak. Nevezd át őket product és quantity nevekre
    // (állj a névre, F2 vagy Ctrl+R, Ctrl+R).
    public void AddLine(Product product, int quantity)
    {
        lines.Add(new OrderLine(product, quantity));
    }

    // 8. feladat (Inline Method)
    // Ez a metódus semmi mást nem csinál, csak továbbadja a vevő nevét, tehát felesleges közvetítő.
    // Állj a metódus egyik hívására (például az InvoicePrinter.cs fájlban), nyomj Ctrl+.-ot,
    // és válaszd az Inline lehetőséget. Ha kétféle változatot látsz (a metódus megtartása vagy
    // törlése), próbáld ki mindkettőt.
    // A végén a hívások helyén az order.Customer.Name kifejezésnek kell szerepelnie.
    public string GetCustomerName()
    {
        return Customer.Name;
    }

    // 1. feladat (Rename), első rész
    // A Calc név nem árulja el, mit számol a metódus (a rendelés végösszegét, kedvezménnyel és áfával).
    // Nevezd át CalculateTotal-ra: állj a névre, majd F2 (vagy Ctrl+R, Ctrl+R).
    // Figyeld meg, hogy a hívások az InvoicePrinter.cs és az OrderProcessor.cs fájlban is átíródnak.
    public decimal CalculateTotal()
    {
        decimal net = 0;
        foreach (var line in lines)
        {
            net += line.Product.Price * line.Quantity;
        }

        decimal discount = net * Customer.GetDiscountPercent() / 100;
        decimal afterDiscount = net - discount;
        return afterDiscount + PriceCalculator.CalculateVat(afterDiscount);
    }

    
}
