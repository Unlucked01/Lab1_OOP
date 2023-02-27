using Lab1;
using System.Text;

/*
Реализовать класс, содержащий не менее 7 полей с различными типами данных:
    1)cтрока;
    2)целое;
    3)вещественное.
Класс должен быть оформлен в виде отдельного файла.
Создать на основе класса объект. Класс должен содержать конструктор без параметров, с одним параметром, с двумя параметрами, с количеством параметров, равным количеству полей класса.
Вывести cодержимое его полей:
    1)с использование переопределенного метода ToString() для класса в целом;
    2)непосредственно обращаясь к полю;
    3)реализовав метод, выводящий на экран значение определенного поля;
    4)одно из числовых полей вывести в шестнадцатеричном представлении.
 */
internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        UI.PrintHeader();
        List<TrainStation> stations = new();
        TrainStation station = new("Москва", 500, 200, "Центральный район", 10, 1500m, true);
        TrainStation station2 = new("Сочи", 200, 500, "Приморский район", 100, 15000m, false);
        stations.Add(station);
        stations.Add(station2);
        UI.PrintInfo(station);
        UI.PrintInfo(station2);
        UI.PrintIntToHex(station2.GetIntField("seatsNumber"));
        UI.Start(stations);
    }
    
}