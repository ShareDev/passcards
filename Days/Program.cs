using System;

namespace Days
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите число, указывающее на порядковый номер дня");

                int validDayNumber = 0;
                string dayString = string.Empty;

                var isValidDayNumber = int.TryParse(Console.ReadLine(), out validDayNumber);

                if (isValidDayNumber)
                {
                    switch (validDayNumber)
                    {
                        case 1:
                            dayString = "Понедельник";
                            break;
                        case 2:
                            dayString = "Вторник";
                            break;
                        case 3:
                            dayString = "Среда";
                            break;
                        case 4:
                            dayString = "Четверг";
                            break;
                        case 5:
                            dayString = "Пятница";
                            break;
                        case 6:
                            dayString = "Суббота";
                            break;
                        case 7:
                            dayString = "Воскресенье";
                            break;
                        default:
                            dayString = "Введено некорректное число";
                            break;
                    }
                }
                else
                {
                    dayString = "Необходимо ввести число";
                }

                Console.WriteLine(dayString);
            }
        }
    }
}
