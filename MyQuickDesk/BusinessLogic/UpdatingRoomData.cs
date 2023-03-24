﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQuickDesk.BusinessLogic
{
    internal class UpdatingRoomData
    {
        //Klasę z metodą do aktualizowania danych pokoi w pliku csv (rooms)
        static public void ReadFile()
        {
            Console.WriteLine("Oczytano plik Rooms");
            string Filepath = "C:\\Users\\dom\\Source\\Repos\\JCSZR9-MyQuickDesk\\MyQuickDesk\\AppData\\rooms.csv";
            using (StreamReader reader = new StreamReader(Filepath))
            {
                // odczytanie każdej linii pliku
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    // podzielenie linii na pola
                    string[] fields = line.Split(',');


                    foreach (string field in fields)
                    {
                        Console.Write(field + " ");
                    }

                    Console.WriteLine();
                }
            }
        }
        static public void ReadAndUpdate()
        {
            ReadFile();
            string path = "C:\\Users\\dom\\Source\\Repos\\JCSZR9-MyQuickDesk\\MyQuickDesk\\AppData\\rooms.csv";
            // Czytanie wszystkich rekordów
            List<string> records = new List<string>();
            using (StreamReader reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    records.Add(line);
                }
            }

            // Nowe dane
            Console.WriteLine("Wprowadź nowe dane pokoi po przecinku (Id,Name,Owner Id,Interactive Board,Max Capacity,Short Description,Price [PLN])");
            string newData = Console.ReadLine();
            records.Add(newData);

            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (string record in records)
                {
                    writer.WriteLine(record);
                }
            }

            Console.WriteLine("Nowe dane pokoi zostały zapisane.");
            ReadFile();
            Console.ReadKey();
        }
    }
}