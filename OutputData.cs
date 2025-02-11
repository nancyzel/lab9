namespace lab9
{
    internal class OutputData
    {
        /// <summary>
        /// вывод свойств объекта Weather (температура, влажность, давление)
        /// </summary>
        /// <param name="currentWeather">объект класса Weather с набором характеристик: температура, влажность, давление</param>
        public static void PrintObjectProperties(Weather currentWeather)
        {
            currentWeather.ShowWeatherConditions(out double currentTemperature, out int currentHumidity, out int currentPressure);
            Console.WriteLine($"Температура воздуха {currentTemperature}°C; влажность {currentHumidity}%; давление {currentPressure} мм рт. ст.");
        }

        /// <summary>
        /// Вывод значения точки росы
        /// </summary>
        /// <param name="temperature">температура, в градусах Цельсия</param>
        /// <param name="humidity">влажность, в %</param>
        /// <param name="dewPoint">значение точки росы</param>
        public static void PrintDewPointValue(double temperature, int humidity, double dewPoint)
        {
            Console.WriteLine($"Точка росы при температуре {temperature}°C и влажности {humidity}% составляет {dewPoint}.");
        }

        public static void PrintObjectsQuantity (int objectsQuantity)
        {
            Console.WriteLine($"Количество экземпляров класса Weather, созданных в программе на данный момент, равно {objectsQuantity}.");
        }
    }
}
