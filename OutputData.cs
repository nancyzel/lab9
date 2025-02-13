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
        /// Вывод значения точки росы (демонстрация работы метода класса)
        /// </summary>
        /// <param name="currentWeather">объект класса Weather с набором характеристик: температура, влажность, давление</param>
        public static void PrintDewPointValueClassMethodWay(Weather currentWeather)
        {
            double dewPoint = currentWeather.GetDewPointClassMethod(out double temperature, out int humidity);
            Console.WriteLine($"Точка росы при температуре {temperature}°C и влажности {humidity}% составляет {dewPoint}.");
        }

        /// <summary>
        /// Вывод значения точки росы (демонстрация работы статического метода)
        /// </summary>
        /// <param name="currentWeather">объект класса Weather с набором характеристик: температура, влажность, давление</param>
        public static void PrintDewPointValueStaticWay(Weather currentWeather)
        {
            double dewPoint = Weather.GetDewPointStaticMethod(currentWeather, out double temperature, out int humidity);
            Console.WriteLine($"Точка росы при температуре {temperature}°C и влажности {humidity}% составляет {dewPoint}.");
        }

        public static void PrintObjectsQuantity()
        {
            int objectsQuantity = Weather.GetObjectsQuantity();
            Console.WriteLine($"Количество экземпляров класса Weather, созданных в программе на данный момент, равно {objectsQuantity}.");
        }

        public static void PrintWeatherArrayElements(WeatherObjectsCollection weatherArray)
        {
            Console.WriteLine("Состав массива объектов Weather:");
            for (int i = 0; i < weatherArray.Length; i++)
            {
                PrintObjectProperties(weatherArray[i]);
            } 
        }
    }
}
