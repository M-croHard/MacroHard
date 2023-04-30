namespace Ticket_Blaster.Pages.Shared.App_code
{
    public class Seat
    {
        public int Row { get; set; }
        public int Number { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }

        public Seat(int row, int number, decimal price)
        {
            Row = row;
            Number = number;
            Price = price;
            IsAvailable = true;
        }
    }
}
