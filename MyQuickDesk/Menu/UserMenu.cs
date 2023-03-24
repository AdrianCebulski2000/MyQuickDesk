﻿using System;

public class UserMenu
{
    public static void Show(string Id, string Login)
    {
        string[] options = { "1. Dostępne pokoje ", "2. Moje rezerwacje ", "3. Modyfikuj rezerwację ", "4. Usuń rezerwacje", "5. Wyloguj" };

        int selectedIndex = 0;

        Console.CursorVisible = false;

        while (true)
        {
            Console.Clear();
            Styles.WidgetBar(Id, Login);
            Console.SetCursorPosition(0, 8);

            Menu.Move(options, selectedIndex, Id, Login);

            ConsoleKeyInfo keyInfo = Console.ReadKey();

            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    selectedIndex--;
                    if (selectedIndex < 0)
                    {
                        selectedIndex = options.Length - 1;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    selectedIndex++;
                    if (selectedIndex == options.Length)
                    {
                        selectedIndex = 0;
                    }
                    break;
                case ConsoleKey.Enter:
                    if (selectedIndex == options.Length - 1)
                    {
                        Console.Clear();
                        Styles.MainLogo();
                        Console.SetCursorPosition(0, 15);
                        Styles.CenterTextYellow("Zostałeś wylogowany. Zapraszamy ponownie\n\n");
                        Thread.Sleep(1000);
                        return;
                    }

                    if (selectedIndex == 0)
                    {
                        Console.Clear();
                        FreeRooms(Id);
                        //dostępne pokoje
                        break;

                    }

                    else if (selectedIndex == 1)
                    {
                        Console.Clear();
                        //moje rezerwacje 
                        break;
                    }
                    else if (selectedIndex == 2)
                    {
                        Console.Clear();
                        //modyfikuj rezerwacje
                    }

                    else if (selectedIndex == 3)
                    {
                        Console.Clear();
                        //usuń rezerwację
                    }
                    Console.ReadKey();
                    break;
            }
        }
    }

    ///Metoda którą napisałem do wyświetlania pokoi z pliku
    public static void FreeRooms(string Id)
    {
        Console.SetCursorPosition(0, 2);

        string filePath = Path.Combine(Environment.CurrentDirectory, "..\\..\\..\\AppData\\rooms.csv");
        string[] lines = File.ReadAllLines(filePath);

        // wyświetlenie nagłówka tabeli

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("{0,-4} | {1,-20} | {2,-6} | {3,-14} | {4,-50} | {5,-5}", "Nr", "Nazwa", "Typ", "Max ilość osób", "Wyposażenie", "Cena [PLN]");
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
        Console.ResetColor();


        // iteracja po wierszach, zaczynając od drugiego indeksu

        for (int i = 1; i < lines.Length; i++)
        {
            // rozdzielenie wiersza na kolumny
            string[] columns = lines[i].Split('/');

            Console.WriteLine("{0,-4} | {1,-20} | {2,-6} | {3,-14} | {4,-50} | {5,-5}", i, columns[2], columns[3], columns[4], columns[5], columns[6]);
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
        }

        Console.WriteLine("\n\n");

        int roomNumber;

        while (true)
        {
            Styles.Cyan("Którą salkę / biurko chcesz zarezerwować (Wpisz numer znajdujący się w pierwszej kolumnie)?\n");
            Styles.Yellow("Aby wyjść wpisz 0.\n");

            string userChoice = Console.ReadLine();

            if (int.TryParse(userChoice, out roomNumber))
            {
                int.Parse(userChoice);
                if (int.Parse(userChoice) == 0)
                {
                    break;
                }
                else
                {
                    //Nie dokończona rezerwacja po nr 
                    //string[] col = lines[int.Parse(userChoice)].Split(',');
                    //Console.WriteLine(col[0]);



                }
            }
            else
            {
                Styles.Red("Musisz wpisać Nr salki / biurka który chcesz wynająć.\n\n");
            }

        }


        Styles.CenterTextYellow("Aby wrócić do poprzedniego menu wciśnij dowolny przycisk");
        Console.ReadLine();
    }

}