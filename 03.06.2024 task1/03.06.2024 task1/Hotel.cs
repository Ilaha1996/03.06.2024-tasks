namespace _03._06._2024_task1
{
    public class Hotel
    {
        private string _hotelName;
        private Room[] Rooms;
        private int Count;
        public Hotel(string hotelName)
        {
            HotelName = hotelName;
            Rooms = new Room[0];
            Count = 0;
        }

        public string HotelName
        {
            get { return _hotelName; }
            set { _hotelName = value; }            
        }
                     
        public void AddRoom(Room room)
        {      
                Array.Resize(ref Rooms, Rooms.Length + 1);
                Rooms[Rooms.Length - 1] = room;
                Count++;           
        }

        public void MakeReservation(int? roomID)
        {
            if (roomID == null)
            {
                throw new NullReferenceException("Room ID cannot be null.");
            }
            Room room = null;
            for (int i = 0; i < Count; i++)
            {
                if (Rooms[i].RoomID == roomID)
                {
                    room = Rooms[i];
                    break;
                }
            }
            if (room == null)
            {
                throw new ArgumentException($"Room with ID {roomID} does not exist.");
            }
            if (!room.IsAvailable)
            {
                throw new NotAvailableException($"Room with ID {roomID} is not available.");
            }

            room.IsAvailable = false;
        }

    }

}
        



