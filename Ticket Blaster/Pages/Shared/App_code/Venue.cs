namespace Ticket_Blaster.Pages.Shared.App_code
{
    public class Venue 
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Seat> Seats { get; set; }

        public Venue(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Seats = new List<Seat>();
        }

        public void AddSeat(Seat seat)
        {
            Seats.Add(seat);
        }

        public void RemoveSeat(Seat seat)
        {
            Seats.Remove(seat);
        }

        public bool IsFull()
        {
            return Seats.Count == Capacity;
        }
    }
}
