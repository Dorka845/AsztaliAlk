namespace WebshopRefactoring;

// Egy vevő adatai: elérhetőség, szállítási cím és hűségadatok.
public class Customer
{
    public string Name { get; set; }
    public string Email { get; set; }

    public string Street { get; set; }
    public string City { get; set; }
    public string ZipCode { get; set; }
    public string Country { get; set; }

    public bool IsVip { get; set; }
    public int LoyaltyPoints { get; set; }

    // 7. feladat (Move Method, példánymetódus)
    // Ez a metódus csak a vevő adatait használja (IsVip, LoyaltyPoints), a rendelésről semmit sem tud,
    // ezért a Customer osztályba tartozik. Költöztesd át a Customer.cs fájlba:
    //  - vágd ki a metódust, és illeszd be a Customer osztályba,
    //  - a törzsében töröld a "Customer." előtagot (a Customer osztályon belül a tagok közvetlenül elérhetők),
    //  - javítsd a hívásokat (Order.cs, InvoicePrinter.cs), hogy a vevő metódusát hívják.
    // A fordító hibaüzenetei végigvezetnek a javítandó helyeken.
    // Megjegyzés: a Visual Studióban a példánymetódusok áthelyezésére nincs beépített refaktorálás,
    // ezért kell kézzel dolgozni. A JetBrains Rider és a ReSharper ezt automatikusan elvégzi
    // (Move Instance Method). Diákként ingyenes hozzáférést kaphatsz hozzájuk, érdemes kipróbálni!
    public decimal GetDiscountPercent()
    {
        if (IsVip)
        {
            return 10;
        }

        if (LoyaltyPoints >= 100)
        {
            return 5;
        }

        return 0;
    }
}
