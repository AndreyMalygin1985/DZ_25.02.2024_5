// Пользователь вводит с клавиатуры дату. Приложение должно отобразить
// название сезона и дня недели. Например, если введено 22.12.2021,
// приложение должно отобразить Winter Wednesday.
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите дату в формате ДД.ММ.ГГГГ:");
        string input = Console.ReadLine();

        if (DateTime.TryParseExact(input, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime date))
        {
            string season = GetSeason(date.Month);
            string dayOfWeek = date.ToString("dddd");

            Console.WriteLine($"{season} {dayOfWeek}");
        }
        else
        {
            Console.WriteLine("Некорректный формат даты.");
        }
    }

    static string GetSeason(int month)
    {
        if (month == 12 || month <= 2)
        {
            return "Зима";
        }
        else if (month >= 3 && month <= 5)
        {
            return "Весна";
        }
        else if (month >= 6 && month <= 8)
        {
            return "Лето";
        }
        else
        {
            return "Осень";
        }
    }
}