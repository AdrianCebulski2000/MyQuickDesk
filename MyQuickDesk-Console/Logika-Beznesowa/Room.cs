<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logika_Beznesowa
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int OwnerId { get; set; }
        public bool InteractiveBoard { get; set; }
        public int Capacity { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public Room(int id, string name, int ownerId, bool interactiveBoard, int capacity, string description, decimal price)
        {
            Id = id;
            Name = name;
            OwnerId = ownerId;
            InteractiveBoard = interactiveBoard;
            Capacity = capacity;
            Description = description;
            Price = price;
        }

        public static Room Add(int id, string name, int ownerId, bool interactiveBoard, int capacity, string description, decimal price)
        {
            Room newRoom = new Room(id, name, ownerId, interactiveBoard, capacity, description, price);
            return newRoom;
        }

        public static Room Modify(Room room, string name, bool interactiveBoard, int capacity, string description, decimal price)
        {
            room.Name = name;
            room.InteractiveBoard = interactiveBoard;
            room.Capacity = capacity;
            room.Description = description;
            room.Price = price;
            return room;
        }

        public static void Delete(int id)
        {
        }
    }
}
=======
﻿using CsvHelper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;


namespace Logika_Beznesowa
{
    public class Room
    {
    // Biblioteka "CsvHelper.Configuration.Attributes" pozwala z automatu oznaczyć nagłówki kolumn do danego
    // property, za pomocą oznaczeń [Name("Nazwa kolumny")] tuż przed property, którą dotyczy.
        [Name("Id")]
        public int Id { get; set; }

        [Name("Name")]
        public string Name { get; set; }

        [Name("Owner Id")]
        public int OwnerId { get; set; }

        [Name("Interactive Board")]
        public bool InteractiveBoard { get; set; }

        [Name("Max Capacity")]
        public int Capacity { get; set; }

        [Name("Short Description")]
        public string Description { get; set; }

        [Name("Price [PLN]")]
        public decimal Price { get; set; }


        public Room() { }

        //public Room(int id, string name, int ownerId, bool interactiveBoard, int capacity, string description, decimal price)
        //{
        //    Id = id;
        //    Name = name;
        //    OwnerId = ownerId;
        //    InteractiveBoard = interactiveBoard;
        //    Capacity = capacity;
        //    Description = description;
        //    Price = price;
        //}

        //public static Room Add(int id, string name, int ownerId, bool interactiveBoard, int capacity, string description, decimal price)
        //{
        //    Room newRoom = new Room(id, name, ownerId, interactiveBoard, capacity, description, price);
        //    return newRoom;
        //}

        // tymczasowe rozwiązanie. Potencjalnie stworze metode do wysyłania danych.
        public static List<Room> Add(Room room)
        {
            return new List<Room>
            {
                new Room
                {
      
                    Name = room.Name,
                    OwnerId = room.OwnerId,
                    InteractiveBoard = room.InteractiveBoard,
                    Capacity = room.Capacity,
                    Description = room.Description,
                    Price = room.Price
                },

            };

        }

    





        public static Room Modify(Room room, string name, bool interactiveBoard, int capacity, string description, decimal price)
        {
            room.Name = name;
            room.InteractiveBoard = interactiveBoard;
            room.Capacity = capacity;
            room.Description = description;
            room.Price = price;
            return room;
        }



        public static void Delete(int id)
        {
        }

    }
}
>>>>>>> Piotr_Kedzia
