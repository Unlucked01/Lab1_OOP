using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Text.RegularExpressions;

namespace Lab1
{
    internal class UI
    {
        public UI() {}
        public static void PrintHeader()
        {
            Console.WriteLine("Бригада №3: Изгарев && Копылов\n" + "Предметная область: Вокзал.");
            delim();
        }
        public static void PrintInfo(TrainStation printStation)
        {
            Console.WriteLine(printStation.ToString());
            delim();
        }
        public static void PrintIntToHex(int intValue)
        {
            Console.WriteLine("Представление поля в HEX-формате: " + intValue.ToString("X"));
            delim();
        }
        public static string? ChooseStations(List<TrainStation> stations)
        {
            Console.WriteLine("Выберите станцию: \n Для выхода введите - 0");
            for (int i = 0; i < stations.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {stations[i].stationName}");
            }
            return Console.ReadLine();
        }
        public static void PrintOptions()
        {
            Console.WriteLine("Выберете поле для изменения: \n" +
                "1 - Изменить название станции \n" +
                "2 - Изменить число мест \n" +
                "3 - Изменить количество проданных билетов \n" +
                "4 - Изменить местоположение станции \n" +
                "5 - Изменить количество поездов в день \n" +
                "6 - Изменить среднюю стоимость билета \n" +
                "7 - Изменить наличие WiFi на станции \n" +
                "0 - Для выхода");
        }
        public static void Start(List<TrainStation> stations)
        {
            string? stationOption = ChooseStations(stations);
            while(!validate(stationOption, 0, stations.Count))
            {
                stationOption = Console.ReadLine();
            }
            PrintOptions();
            string? option = Console.ReadLine();
            while (validate(option, 0, 7))
            {
                Regex regexStr = new(@"\p{IsCyrillic}", RegexOptions.IgnorePatternWhitespace);
                Regex regexInt = new(@"[0-9]", RegexOptions.IgnorePatternWhitespace);
                Regex regexDecimal = new(@"\d", RegexOptions.IgnorePatternWhitespace);
                Regex regexBool = new(@"[нН]ет|[дД]а", RegexOptions.IgnorePatternWhitespace);
                int stOption = Int32.Parse(stationOption);
                switch (option)
                {
                    case "1":
                        string? inputUser = Console.ReadLine();
                        while (!validate(regexStr, inputUser)){
                            inputUser = Console.ReadLine();
                        }
                        stations[stOption - 1].stationName = inputUser;
                        break;
                    case "2":
                        inputUser = Console.ReadLine();
                        while (!validate(regexInt, inputUser))
                        {
                            inputUser = Console.ReadLine();
                        }
                        stations[stOption - 1].seatsNumber = Int32.Parse(inputUser);
                        break;
                    case "3":
                        inputUser = Console.ReadLine();
                        while (!validate(regexDecimal, inputUser))
                        {
                            inputUser = Console.ReadLine();
                        }
                        stations[stOption - 1].ticketsSold = Convert.ToDouble(inputUser);
                        break;
                    case "4":
                        inputUser = Console.ReadLine();
                        while (!validate(regexStr, inputUser))
                        {
                            inputUser = Console.ReadLine();
                        }
                        stations[stOption - 1].location = inputUser;
                        break;
                    case "5":
                        inputUser = Console.ReadLine();
                        while (!validate(regexInt, inputUser))
                        {
                            inputUser = Console.ReadLine();
                        }
                        stations[stOption - 1].trainsPerDay = Int32.Parse(inputUser);
                        break;
                    case "6":
                        inputUser = Console.ReadLine();
                        while (!validate(regexDecimal, inputUser))
                        {
                            inputUser = Console.ReadLine();
                        }
                        stations[stOption - 1].averageTicketPrice = Convert.ToDecimal(inputUser);
                        break;
                    case "7":
                        inputUser = Console.ReadLine();
                        while (!validate(regexBool, inputUser))
                        {
                            inputUser = Console.ReadLine();
                        }
                        if(inputUser == "Да" || inputUser == "да")
                        {
                            stations[stOption - 1].hasWiFi = true;
                        }
                        else
                        {
                            stations[stOption - 1].hasWiFi = false;
                        }
                        break;
                }
                Console.WriteLine(stations[stOption - 1].ToString());
                delim();
            }
        }

        private static bool validate(Regex reg, string? str)
        {
            return reg.IsMatch(str);
        }

        private static bool validate(string? str, int minNumber, int maxNumber)
        {
            int result;
            if(Int32.TryParse(str, out result))
            {
                if(result > minNumber || result < maxNumber) { 
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        
        private static void delim()
        {
            Console.WriteLine(new string('#', 40));
        }
    }
}
