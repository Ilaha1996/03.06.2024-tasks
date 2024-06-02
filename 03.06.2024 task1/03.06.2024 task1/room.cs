using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _03._06._2024_task1
{
    public class Room
    {
        private static int Count;
        private int _roomID;
        private string _name;
        private double _price;
        private int _personCapacity;
        private bool _isAvailable;



        public Room(string name, double price, int personCapacity)
        {
            Name = name;
            Price = price;
            PersonCapacity = personCapacity;
            Count++;
            _roomID= Count;
            IsAvailable = true;
        }
        public int RoomID
        {
            get { return _roomID; }

        }
               
        public string Name { get; set; }
        public double Price { get; set; }
        public int PersonCapacity { get; set; }
        public bool IsAvailable { get; set; }

        
        public string ShowingInfo()
        {
            return $"ID - {RoomID}, Name - {Name}, Price - {Price}, Person capacity - {PersonCapacity}, Availability - {IsAvailable}";
        }

        public override string ToString()
        {
            return ShowingInfo();
        }

    }
}
