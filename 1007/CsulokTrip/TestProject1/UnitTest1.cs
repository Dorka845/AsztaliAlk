using CsulokTrip;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        // ============================================================
        // CalculateSubtotal
        // ============================================================

        [Fact]
        public void CalculateSubtotal_Null_ReturnsZero()
        {
            var result = OrderCalculator.CalculateSubtotal(null);

            Assert.Equal(0, result);
        }

        [Fact]
        public void CalculateSubtotal_EmptyList_ReturnsZero()
        {
            var lines = Array.Empty<OrderLine>();

            var result = OrderCalculator.CalculateSubtotal(lines);

            Assert.Equal(0, result);
        }

        [Fact]
        public void CalculateSubtotal_OneLine_ReturnsCorrectAmount()
        {
            var lines = new List<OrderLine>
        {
            new("Csulok", 4500m, 3)
        };

            var result = OrderCalculator.CalculateSubtotal(lines);

            Assert.Equal(13500m, result);
        }

        [Fact]
        public void CalculateSubtotal_MultipleLines_ReturnsSumOfAllLines()
        {
            var lines = new List<OrderLine>
        {
            new("Csulok", 4500m, 3),
            new("Cola", 700m, 2),
            new("Kave", 500m, 1)
        };

            var result = OrderCalculator.CalculateSubtotal(lines);

            Assert.Equal(15400m, result);
        }


        // ============================================================
        // GetGroupDiscountPercent
        // ============================================================

        [Fact]
        public void GetGroupDiscountPercent_OnePerson_ReturnsZero()
        {
            Assert.Equal(
                0m,
                OrderCalculator.GetGroupDiscountPercent(1));
        }

        [Fact]
        public void GetGroupDiscountPercent_NinePeople_ReturnsZero()
        {
            Assert.Equal(
                0m,
                OrderCalculator.GetGroupDiscountPercent(9));
        }

        [Fact]
        public void GetGroupDiscountPercent_TenPeople_ReturnsFive()
        {
            Assert.Equal(
                5m,
                OrderCalculator.GetGroupDiscountPercent(10));
        }

        [Fact]
        public void GetGroupDiscountPercent_NineteenPeople_ReturnsFive()
        {
            Assert.Equal(
                5m,
                OrderCalculator.GetGroupDiscountPercent(19));
        }

        [Fact]
        public void GetGroupDiscountPercent_TwentyPeople_ReturnsTen()
        {
            Assert.Equal(
                10m,
                OrderCalculator.GetGroupDiscountPercent(20));
        }

        [Fact]
        public void GetGroupDiscountPercent_MoreThanTwentyPeople_ReturnsTen()
        {
            Assert.Equal(
                10m,
                OrderCalculator.GetGroupDiscountPercent(21));
        }

        [Fact]
        public void GetGroupDiscountPercent_Zero_Throws()
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => OrderCalculator.GetGroupDiscountPercent(0));
        }

        [Fact]
        public void GetGroupDiscountPercent_Negative_Throws()
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => OrderCalculator.GetGroupDiscountPercent(-1));
        }


        // ============================================================
        // ApplyDiscount
        // ============================================================

        [Fact]
        public void ApplyDiscount_ZeroPercent_ReturnsOriginalAmount()
        {
            var result = OrderCalculator.ApplyDiscount(1000m, 0m);

            Assert.Equal(1000m, result);
        }

        [Fact]
        public void ApplyDiscount_TenPercent_ReturnsCorrectAmount()
        {
            var result = OrderCalculator.ApplyDiscount(1000m, 10m);

            Assert.Equal(900m, result);
        }

        [Fact]
        public void ApplyDiscount_TwentyPercent_ReturnsCorrectAmount()
        {
            var result = OrderCalculator.ApplyDiscount(5000m, 20m);

            Assert.Equal(4000m, result);
        }

        [Fact]
        public void ApplyDiscount_HalfRoundsAwayFromZero()
        {
            var result = OrderCalculator.ApplyDiscount(1005m, 10m);

            Assert.Equal(905m, result);
        }


        // ============================================================
        // AverageSpendPerPerson
        // ============================================================

        [Fact]
        public void AverageSpendPerPerson_ZeroPeople_ReturnsZero()
        {
            var result = OrderCalculator.AverageSpendPerPerson(1000m, 0);

            Assert.Equal(0m, result);
        }

        [Fact]
        public void AverageSpendPerPerson_NegativePeople_ReturnsZero()
        {
            var result = OrderCalculator.AverageSpendPerPerson(1000m, -1);

            Assert.Equal(0m, result);
        }

        [Fact]
        public void AverageSpendPerPerson_DividesCorrectly()
        {
            var result = OrderCalculator.AverageSpendPerPerson(3000m, 3);

            Assert.Equal(1000m, result);
        }

        [Fact]
        public void AverageSpendPerPerson_HalfRoundsAwayFromZero()
        {
            var result = OrderCalculator.AverageSpendPerPerson(1809m, 2);

            Assert.Equal(905m, result);
        }
    }


    public class TableBookingTests
    {
        // ============================================================
        // Constructor
        // ============================================================

        [Fact]
        public void Constructor_ValidCapacity_SetsCapacity()
        {
            var booking = new TableBooking(10);

            Assert.Equal(10, booking.Capacity);
        }

        [Fact]
        public void Constructor_ValidCapacity_StartsWithZeroReserved()
        {
            var booking = new TableBooking(10);

            Assert.Equal(0, booking.Reserved);
        }

        [Fact]
        public void Constructor_ValidCapacity_AllSeatsAreAvailable()
        {
            var booking = new TableBooking(10);

            Assert.Equal(10, booking.Available);
        }

        [Fact]
        public void Constructor_ZeroCapacity_Throws()
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => new TableBooking(0));
        }

        [Fact]
        public void Constructor_NegativeCapacity_Throws()
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => new TableBooking(-1));
        }


        // ============================================================
        // Reserve
        // ============================================================

        [Fact]
        public void Reserve_ValidNumberOfSeats_ReturnsTrue()
        {
            var booking = new TableBooking(10);

            var result = booking.Reserve(3);

            Assert.True(result);
        }

        [Fact]
        public void Reserve_ValidNumberOfSeats_IncreasesReserved()
        {
            var booking = new TableBooking(10);

            booking.Reserve(3);

            Assert.Equal(3, booking.Reserved);
        }

        [Fact]
        public void Reserve_ValidNumberOfSeats_DecreasesAvailable()
        {
            var booking = new TableBooking(10);

            booking.Reserve(3);

            Assert.Equal(7, booking.Available);
        }

        [Fact]
        public void Reserve_ZeroSeats_ReturnsFalseAndChangesNothing()
        {
            var booking = new TableBooking(10);

            var result = booking.Reserve(0);

            Assert.False(result);
            Assert.Equal(0, booking.Reserved);
            Assert.Equal(10, booking.Available);
        }

        [Fact]
        public void Reserve_NegativeSeats_ReturnsFalseAndChangesNothing()
        {
            var booking = new TableBooking(10);

            var result = booking.Reserve(-2);

            Assert.False(result);
            Assert.Equal(0, booking.Reserved);
        }

        [Fact]
        public void Reserve_MoreThanAvailable_ReturnsFalseAndChangesNothing()
        {
            var booking = new TableBooking(10);

            var result = booking.Reserve(11);

            Assert.False(result);
            Assert.Equal(0, booking.Reserved);
        }

        [Fact]
        public void Reserve_ExactlyAllRemainingSeats_IsAllowed()
        {
            var booking = new TableBooking(10);

            var result = booking.Reserve(10);

            Assert.True(result);
            Assert.Equal(10, booking.Reserved);
            Assert.Equal(0, booking.Available);
        }

        [Fact]
        public void Reserve_WhenPartiallyReserved_CanReserveExactlyRemainingSeats()
        {
            var booking = new TableBooking(10);

            booking.Reserve(4);

            var result = booking.Reserve(6);

            Assert.True(result);
            Assert.Equal(10, booking.Reserved);
            Assert.Equal(0, booking.Available);
        }

        [Fact]
        public void Reserve_WhenNoSeatsAvailable_ReturnsFalse()
        {
            var booking = new TableBooking(10);

            booking.Reserve(10);

            var result = booking.Reserve(1);

            Assert.False(result);
            Assert.Equal(10, booking.Reserved);
        }


        // ============================================================
        // Cancel
        // ============================================================

        [Fact]
        public void Cancel_ValidNumberOfSeats_ReturnsTrue()
        {
            var booking = new TableBooking(10);

            booking.Reserve(5);

            var result = booking.Cancel(2);

            Assert.True(result);
        }

        [Fact]
        public void Cancel_ValidNumberOfSeats_DecreasesReserved()
        {
            var booking = new TableBooking(10);

            booking.Reserve(5);
            booking.Cancel(2);

            Assert.Equal(3, booking.Reserved);
        }

        [Fact]
        public void Cancel_ValidNumberOfSeats_IncreasesAvailable()
        {
            var booking = new TableBooking(10);

            booking.Reserve(5);
            booking.Cancel(2);

            Assert.Equal(7, booking.Available);
        }

        [Fact]
        public void Cancel_ZeroSeats_ReturnsFalseAndChangesNothing()
        {
            var booking = new TableBooking(10);

            booking.Reserve(5);

            var result = booking.Cancel(0);

            Assert.False(result);
            Assert.Equal(5, booking.Reserved);
        }

        [Fact]
        public void Cancel_NegativeSeats_ReturnsFalseAndChangesNothing()
        {
            var booking = new TableBooking(10);

            booking.Reserve(5);

            var result = booking.Cancel(-1);

            Assert.False(result);
            Assert.Equal(5, booking.Reserved);
        }

        [Fact]
        public void Cancel_MoreThanReserved_ReturnsFalseAndChangesNothing()
        {
            var booking = new TableBooking(10);

            booking.Reserve(5);

            var result = booking.Cancel(6);

            Assert.False(result);
            Assert.Equal(5, booking.Reserved);
        }

        [Fact]
        public void Cancel_ExactlyAllReservedSeats_IsAllowed()
        {
            var booking = new TableBooking(10);

            booking.Reserve(5);

            var result = booking.Cancel(5);

            Assert.True(result);
            Assert.Equal(0, booking.Reserved);
            Assert.Equal(10, booking.Available);
        }


        // ============================================================
        // PortionsNeeded
        // ============================================================

        [Fact]
        public void PortionsNeeded_ZeroReserved_ReturnsZero()
        {
            var booking = new TableBooking(10);

            Assert.Equal(0, booking.PortionsNeeded());
        }

        [Fact]
        public void PortionsNeeded_TwoPeople_ReturnsOne()
        {
            var booking = new TableBooking(10);

            booking.Reserve(2);

            Assert.Equal(1, booking.PortionsNeeded());
        }

        [Fact]
        public void PortionsNeeded_FourPeople_ReturnsTwo()
        {
            var booking = new TableBooking(10);

            booking.Reserve(4);

            Assert.Equal(2, booking.PortionsNeeded());
        }

        [Fact]
        public void PortionsNeeded_FivePeople_ReturnsThree()
        {
            var booking = new TableBooking(10);

            booking.Reserve(5);

            Assert.Equal(3, booking.PortionsNeeded());
        }

        [Fact]
        public void PortionsNeeded_OnePerson_ReturnsOne()
        {
            var booking = new TableBooking(10);

            booking.Reserve(1);

            Assert.Equal(1, booking.PortionsNeeded());
        }

        [Fact]
        public void PortionsNeeded_SevenPeople_ReturnsFour()
        {
            var booking = new TableBooking(10);

            booking.Reserve(7);

            Assert.Equal(4, booking.PortionsNeeded());
        }
    }
}