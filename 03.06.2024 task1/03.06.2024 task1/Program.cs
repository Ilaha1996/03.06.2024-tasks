namespace _03._06._2024_task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Room room = new Room("Lale",250.45,2);
            room.Name = "Lale";
            room.PersonCapacity = 2;
            room.Price = 250.45;

           Room room1 = new Room("Nergiz", 300, 4);
            room1.Name = "Nergiz";
            room1.PersonCapacity = 4;
            room1.Price = 300;

            Hotel hotel = new Hotel("Four Season");
            hotel.HotelName = "Four Season";
            hotel.AddRoom(room);
            hotel.AddRoom(room1);

            
            try
            {
                int roomIdToReserve = 1;
                hotel.MakeReservation(roomIdToReserve);
                Console.WriteLine("Succesfully reserved");
            }                       
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (NotAvailableException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }


        }
    }
}
