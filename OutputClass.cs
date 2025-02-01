namespace lab9
{
    internal class OutputClass
    {
        /// <summary>
        /// вывод свойств объекта
        /// </summary>
        /// <param name="temperature">температура воздуха, в градусах Цельсия</param>
        /// <param name="humidity">влажность воздуха, в %</param>
        /// <param name="pressure">атмосферное давление, в мм рт.ст.</param>
        public static void PrintObjectProperties(double temperature, int humidity, double pressure)
        {
            Console.WriteLine($"Температура воздуха {temperature}°C; влажность {humidity}%; давление {pressure} мм рт. ст.");
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
