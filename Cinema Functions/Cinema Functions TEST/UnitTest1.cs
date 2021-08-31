using CinemaApp;
using NUnit.Framework;

namespace Cinema_Functions_TEST
{
    [TestFixture]
    public class TestCase1

    {
      //Adult_Before_5(int quantity, string person, string day, deciaml time, decimal expectedAmount)
      [TestCase(1, "adult", "Monday", 4, 14.50)]
      [TestCase(2, "adult", "Monday", 4, 29.00)]
      [TestCase(0, "adult", "Monday", 4, -1)]
      [TestCase(4, "adult", "Monday", 6, -1)]
      [TestCase(4, "adult", "Monday", 4, 58.00)]


      public void Adult_Before_5(int pr_quantity, string pr_person, string pr_day, decimal pr_time, decimal expectedAmount)
        {
            //arange
            //TicketPriceController TPC = new();
            TicketPriceController TPC = new TicketPriceController();
            //act
            decimal price = TPC.Adult_Before_5(pr_quantity, pr_person, pr_day, pr_time);
            //assert;
            Assert.That(price == expectedAmount);

        }
    }
}