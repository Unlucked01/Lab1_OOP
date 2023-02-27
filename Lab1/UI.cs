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
        /// <summary>
        ///  Вывод в консоль нормера бригады, фамилии студентов, предметную область.
        /// </summary>
        public static void PrintHeader()
        {
            Console.WriteLine("Бригада №3: Изгарев && Копылов\n" + "Предметная область: Вокзал.");
            delim();
        }
        /// <summary>
        /// Вывод в консоль числа в шестнадцатиричной системе счислениия
        /// </summary>
        /// <param name="intValue">Целочисленное число</param>
        public static void PrintIntToHex(int intValue)
        {
            Console.WriteLine($"Представление чилового значения поля ({intValue}) в HEX-формате: " + intValue.ToString("X")) ;
            delim();
        }
        /// <summary>
        /// Выбор станции пользователем
        /// </summary>
        /// <param name="stations">Список станций для отображения в консоли</param>
        /// <returns>Номер станции, выбранный пользователем</returns>
        public static string? ChooseStations(List<TrainStation> stations)
        {
            Console.WriteLine("Выберите станцию: \nДля выхода введите - 0");
            for (int i = 0; i < stations.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {stations[i].stationName}");
            }
            Console.Write("Введите число - ");
            return Console.ReadLine();
        }
        /// <summary>
        /// Выводит в консоль варианты взаимодействия с объектом
        /// </summary>
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
        /// <summary>
        /// Позволяет взаимодействовать пользователю с консоль
        /// </summary>
        /// <param name="stations">Список существующих объектов</param>
        public static void Start(List<TrainStation> stations)
        {
            foreach(TrainStation station in stations)
            {
                Console.WriteLine(station.ToString());
                delim();
            }
            string? stationOption = ChooseStations(stations);
            while (!validate(stationOption, 0, stations.Count))
            {
                Console.Write("Введите число - ");
                stationOption = Console.ReadLine();
            }
            while (stationOption != "0")
            {
                delim();
                PrintOptions();
                delim();
                Console.Write("Введите число - ");
                string? option = Console.ReadLine();
                delim();

                Regex regexStr = new(@"^\p{IsCyrillic}+\s*\p{IsCyrillic}*$", RegexOptions.IgnorePatternWhitespace);
                Regex regexDecimal = new(@"^\d+,\d+$", RegexOptions.IgnorePatternWhitespace);
                Regex regexBool = new(@"нет|да", RegexOptions.IgnoreCase);

                int stOption = Int32.Parse(stationOption);
                switch (option)
                {
                    case "1":
                        Console.Write("Введите новое название станции: ");
                        string? inputUser = Console.ReadLine();
                        while (!validate(regexStr, inputUser))
                        {
                            Console.Write("Введите корректное название станции(допускаются только символы Кириллицы): ");
                            inputUser = Console.ReadLine();
                        }
                        stations[stOption - 1].stationName = inputUser;
                        break;
                    case "2":
                        Console.Write("Введите новое число сидячих мест: ");
                        inputUser = Console.ReadLine();
                        while (!validate(inputUser,0,int.MaxValue))
                        {
                            Console.Write("Введите корректное чило сидячих мест: ");
                            inputUser = Console.ReadLine();
                        }
                        stations[stOption - 1].seatsNumber = Int32.Parse(inputUser);
                        break;
                    case "3":
                        Console.Write("Введите новое число проданных билетов: ");
                        inputUser = Console.ReadLine();
                        while (!validate(inputUser, 0, int.MaxValue))
                        {
                            Console.Write("Введите корректное число проданных билетов: ");
                            inputUser = Console.ReadLine();
                        }
                        stations[stOption - 1].ticketsSold = Int32.Parse(inputUser);
                        break;
                    case "4":
                        Console.Write("Введите новое местоположение станции: ");
                        inputUser = Console.ReadLine();
                        while (!validate(regexStr, inputUser))
                        {
                            Console.Write("Введите корректное местоположение станции(допускаются только символы Кириллицы): ");
                            inputUser = Console.ReadLine();
                        }
                        stations[stOption - 1].location = inputUser;
                        break;
                    case "5":
                        Console.Write("Введите новое число поездов в день: ");
                        inputUser = Console.ReadLine();
                        while (!validate(inputUser,0,int.MaxValue))
                        {
                            Console.Write("Введите корректное число поездов в день: ");
                            inputUser = Console.ReadLine();
                        }
                        stations[stOption - 1].trainsPerDay = Int32.Parse(inputUser);
                        break;
                    case "6":
                        Console.Write("Введите новые данные о средней стоимости билета: ");
                        inputUser = Console.ReadLine();
                        while (!validate(regexDecimal, inputUser))
                        {
                            Console.Write("Введите корректные данные о средней стоимости билета(неотрицательное вещественное число): ");
                            inputUser = Console.ReadLine();
                        }
                        stations[stOption - 1].averageTicketPrice = Convert.ToDecimal(inputUser);
                        break;
                    case "7":
                        Console.Write("Введите новые данные о наличии WIFI: ");
                        inputUser = Console.ReadLine();
                        while (!validate(regexBool, inputUser))
                        {
                            Console.Write("Введите корректные данные о наличии WIFI(да или нет): ");
                            inputUser = Console.ReadLine();
                        }
                        if (inputUser == "Да" || inputUser == "да" || inputUser == "ДА")
                        {
                            stations[stOption - 1].hasWiFi = true;
                        }
                        else
                        {
                            stations[stOption - 1].hasWiFi = false;
                        }
                        break;
                }
                delim();
                Console.WriteLine(stations[stOption - 1].ToString());
                delim();
                stationOption = ChooseStations(stations);
                while (!validate(stationOption, 0, stations.Count))
                {
                    delim();
                    stationOption = Console.ReadLine();
                    delim();
                }
            }
        }
        /// <summary>
        /// Проверка на корректность введённых данных для строки
        /// </summary>
        /// <param name="reg">Шаблон регулярного выражения</param>
        /// <param name="str">Строка, введённая пользователем</param>
        /// <returns>Bool выражение прошли переданные данные проверку или нет</returns>
        private static bool validate(Regex reg, string? str)
        {
            return reg.IsMatch(str);
        }
        /// <summary>
        /// Проверка на корректность введённых данных для числа
        /// </summary>
        /// <param name="str">Строка, введённая пользователем</param>
        /// <param name="minNumber">Минимальное допустимое число</param>
        /// <param name="maxNumber">Максимальное допустимое число</param>
        /// <returns>Bool выражение прошли переданные данные проверку или нет</returns>
        private static bool validate(string? str, int minNumber, int maxNumber)
        {
            int result;
            if(Int32.TryParse(str, out result))
            {
                if(result >= minNumber && result < maxNumber) { 
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
        /// <summary>
        /// 
        /// </summary>
        private static void delim()
        {
            Console.WriteLine(new string('#', 40));
        }
    }
}
