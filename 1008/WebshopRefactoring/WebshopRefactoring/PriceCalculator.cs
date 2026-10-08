namespace WebshopRefactoring;

// A 6. feladathoz: ide költöztesd az áfával kapcsolatos statikus tagokat az Order osztályból.
public static class PriceCalculator
{
    // 6. feladat (Move Field + Move Method, statikus tagok)
    // Az áfakulcs és az áfa kiszámítása nem a rendelés dolga, egy árkalkulátor osztályba tartozik.
    // Költöztesd át a VatRate konstanst és a CalculateVat metódust a PriceCalculator osztályba
    // (PriceCalculator.cs, jelenleg üres): állj a CalculateVat nevére, Ctrl+., majd
    // Move static members to another type. A dialógusban jelöld ki mindkét tagot.
    // Ez a Visual Studio beépített refaktorálása. Utána nézd meg, hogy az InvoicePrinter.cs
    // hivatkozásai is átíródtak-e.
    public const decimal VatRate = 0.27m;

    // (6. feladat, lásd a VatRate konstansnál)
    public static decimal CalculateVat(decimal amount)
    {
        return amount * VatRate;
    }
}
