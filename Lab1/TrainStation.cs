using System;
using System.Reflection.Metadata.Ecma335;

class TrainStation
{
    public string stationName { get; set; } // Наименование станции
    public int seatsNumber { get; set; } // Число мест
    public int ticketsSold { get; set; } // Число проданных билетов
    public string location { get; set; } // Местоположение
    public int trainsPerDay { get; set; } // Количество поездов в день
    public decimal averageTicketPrice { get; set; } // Средняя стоимость билета
    public bool hasWiFi { get; set; } // Наличие Wi-Fi на станции

    /// <summary>
    /// Конструктор по умолчанию
    /// </summary>
    public TrainStation(){}

    /// <summary>
    /// Конструктор с параметром
    /// </summary>
    /// <param name="stationName">Название станции</param>
    public TrainStation(string stationName)
    {
        this.stationName = stationName;
    }
    /// <summary>
    /// Конструктор с параметрами
    /// </summary>
    /// <param name="stationName">Название станции</param>
    /// <param name="seatsNumber">Колличество мест</param>
    public TrainStation(string stationName, int seatsNumber)
    {
        this.stationName = stationName;
        this.seatsNumber = seatsNumber;
    }
    /// <summary>
    /// Конструктор со всеми параметрами
    /// </summary>
    /// <param name="stationName">Название станции</param>
    /// <param name="seatsNumber">Количество мест</param>
    /// <param name="ticketsSold">Количество проданых билетов</param>
    /// <param name="location">Местоположение</param>
    /// <param name="trainsPerDay">Количество поездов</param>
    /// <param name="averageTicketPrice">Средняя стоимость билета</param>
    /// <param name="hasWiFi">Наличие WiFi</param>
    public TrainStation(string stationName, int seatsNumber, int ticketsSold, string location, int trainsPerDay, decimal averageTicketPrice, bool hasWiFi)
    {
        this.stationName = stationName;
        this.seatsNumber = seatsNumber;
        this.ticketsSold = ticketsSold;
        this.location = location;
        this.trainsPerDay = trainsPerDay;
        this.averageTicketPrice = averageTicketPrice;
        this.hasWiFi = hasWiFi;
    }
    /// <summary>
    /// Переопределённый метод .ToString()
    /// </summary>
    /// <returns>
    /// Строку, содержащую все поля класса
    /// </returns>
    public override string ToString()
    {
        return $"Наименование станции: {stationName}\n" +
            $"Местоположение: {location}\n" +
            $"Количество мест:  {seatsNumber} \n" +
            $"Продано билетов:  {ticketsSold} \n" +
            $"Количество поездов в день:  {trainsPerDay} \n" +
            $"Средняя стоимость билета:  {averageTicketPrice} \n" +
            $"Наличие Wi-Fi на станции:  {(hasWiFi ? "Да" : "Нет")}";
    }
    /// <summary>
    /// Метод, возвращающий числовые значения полей
    /// </summary>
    /// <param name="fieldName">Название поля</param>
    /// <returns>
    /// Значение поля приведённое в int 
    /// </returns>
    public int GetIntField(string fieldName)
    {
        return fieldName switch
        {
            "seatsNumber" => seatsNumber,
            "ticketsSold" => (int)ticketsSold,
            "trainsPerDay" => trainsPerDay,
            "averageTicketPrice" => (int)averageTicketPrice,
            _ => 0, //default
        };
    }
}