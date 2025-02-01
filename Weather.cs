using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    internal class Weather
    {
        /// <summary>
        /// температура воздуха в градусах Цельсия
        /// </summary>
        private double temperature;

        /// <summary>
        /// влажность воздуха в %
        /// </summary>
        private int humidity;

        /// <summary>
        /// атмосферное давление в мм рт. ст.
        /// </summary>
        private int pressure;

        static int objectsQuantity = 0;

        /// <summary>
        /// обработка значения для поля temperature
        /// </summary>
        public double Temperature
        {
            get => temperature;
            set
            {
                temperature = value;
            }
        }

        /// <summary>
        /// обработка значения для поля humidity
        /// </summary>
        public int Humidity
        {
            get => humidity;
            set
            {
                if (value < 0)
                {
                    throw new Exception("Влажность не может быть меньше 0%");
                }
                else
                {
                    if (value > 100)
                    {
                        throw new Exception("Влажность не может превышать 100%");
                    }
                    else
                    {
                        humidity = value;
                    }
                }
            }
        }

        /// <summary>
        /// обработка значения для поля pressure
        /// </summary>
        public int Pressure
        {
            get => pressure;
            set
            {
                if (value < 0)
                {
                    throw new Exception("Атмосферное давление не может быть меньше 0");
                }
                else
                {
                    pressure = value;
                }
            }
        }

        /// <summary>
        /// создание объекта через задание всех атрибутов
        /// </summary>
        /// <param name="currentTemperature">введенная пользователем температура</param>
        /// <param name="currentHumidity">введенная пользователем влажность</param>
        /// <param name="currentPressure">введенное пользователем давление</param>
        public Weather(double currentTemperature, int currentHumidity, int currentPressure)
        {
            this.Temperature = currentTemperature;
            this.Humidity = currentHumidity;
            this.Pressure = currentPressure;
            objectsQuantity++;
        }

        /// <summary>
        /// создание объекта через задание температуры
        /// </summary>
        /// <param name="currentTemperature">введенная пользователем температура</param>
        public Weather(double currentTemperature)
        {
            Temperature = currentTemperature;
            Humidity = 40;
            Pressure = 700;
            objectsQuantity++;
        }

        /// <summary>
        /// создание объекта через указание другого объекта
        /// </summary>
        /// <param name="currentWeather">объект класса Weather</param>
        public Weather(Weather currentWeather)
        {
            this.Temperature = currentWeather.Temperature;
            this.Humidity = currentWeather.Humidity;
            this.Pressure = currentWeather.Pressure;
            objectsQuantity++;
        }

        /// <summary>
        /// создание объекта с атрибутами по умолчанию
        /// </summary>
        public Weather():this(15.5, 50, 760)
        {}

        /// <summary>
        /// вывод атрибутов объекта
        /// </summary>
        public void ShowWeatherConditions()
        {
            OutputClass.PrintObjectProperties(Temperature, Humidity, Pressure);
        }

        /// <summary>
        /// вывод значения точки росы - метод класса
        /// </summary>
        public void ShowDewPoint()
        {
            OutputClass.PrintDewPointValue(Temperature, Humidity, CountDewPoint(Temperature, Humidity));
        }

        /// <summary>
        /// вывод значения точки росы - статическая функция
        /// </summary>
        /// <param name="temperature">температура, в градусах Цельсия</param>
        /// <param name="humidity">влажность, в %</param>
        public static void ShowDewPoint(double temperature, int humidity)
        {
            OutputClass.PrintDewPointValue(temperature, humidity, CountDewPoint(temperature, humidity));
        }

        /// <summary>
        /// вывод числа созданных экземпляров класса
        /// </summary>
        public static void ShowObjectsQuantity()
        {
            Console.WriteLine($"Количество экземпляров класса Weather, созданных в программе на данный момент, равно {objectsQuantity}.");
        }

        /// <summary>
        /// функция для вспомогательных вычислений из формулы точки росы (a*temperature/(b+temperature)+ln(relativeHumidity/100
        /// </summary>
        /// <param name="temperature">температура, в градусах цельсия</param>
        /// <param name="relativeHumidity">влажность, в %</param>
        /// <returns>результат вспомогательных вычислений</returns>
        private static double CountDewPointCoefficient(double temperature, int relativeHumidity)
        {
            const double a = 17.27;
            const double b = 237.7;
            double dewPointCoefficient = (a * temperature) / (b + temperature) + Math.Log(((double)relativeHumidity / 100));
            return dewPointCoefficient;
        }

        /// <summary>
        /// расчет непосредственно точки росы
        /// </summary>
        /// <param name="temperature">температура, в градусах Цельсия</param>
        /// <param name="relativeHumidity">влажность, в %</param>
        /// <returns>точка росы, значение округлено до 4 знаков после запятой</returns>
        private static double CountDewPoint(double temperature, int relativeHumidity)
        {
            const double a = 17.27;
            const double b = 237.7;
            double dewPointCoefficient = CountDewPointCoefficient(temperature, relativeHumidity);
            double dewPoint = (b * dewPointCoefficient) / (a - dewPointCoefficient);
            return Math.Round(dewPoint, 4);
        }
    }
}
