namespace lab9
{
    internal class Program
    {
        public static double CountArrayTemperatureAmplitude(WeatherObjectsCollection weatherArray)
        {
            double temperatureAmplitude;
            if (weatherArray == null || weatherArray.Length == 0)
                temperatureAmplitude = -1;
            else
            {
                Weather minimumTemperature = weatherArray[0];
                Weather maximumTemperature = weatherArray[0];
                for (int i = 1; i < weatherArray.Length; i++)
                {
                    if (weatherArray[i] < minimumTemperature)
                    {
                        minimumTemperature = weatherArray[i];
                    }
                    else
                    {
                        if (weatherArray[i] > maximumTemperature)
                        {
                            maximumTemperature = weatherArray[i];
                        }
                    }
                }
                temperatureAmplitude = maximumTemperature - minimumTemperature;
            }
            return temperatureAmplitude;
        }

        public static void PrintArrayTemperatureAmplitude(WeatherObjectsCollection weatherArray)
        {
            double temperatureAmplitude = CountArrayTemperatureAmplitude(weatherArray);
            if (temperatureAmplitude < 0)
            {
                Console.WriteLine("Коллекция пустая, поэтому амплитуду температур определить невозможно.");
            }
            else
            {
                Console.WriteLine($"Амплитуда температур в коллекции составляет {temperatureAmplitude}.");
            }
        }

        static void Main()
        {
            // Part 1
            Weather weatherMonday = new Weather();
            OutputData.PrintObjectProperties(weatherMonday);

            Weather weatherTuesday = new Weather(30, 5, 800);
            OutputData.PrintObjectProperties(weatherTuesday);

            Weather weatherWednesday = new Weather(weatherTuesday);
            OutputData.PrintObjectProperties(weatherWednesday);
            OutputData.PrintDewPointValueStaticWay(weatherWednesday);

            Weather weatherThursday = new Weather(25);
            OutputData.PrintObjectProperties(weatherThursday);
            OutputData.PrintDewPointValueClassMethodWay(weatherThursday);

            OutputData.PrintObjectsQuantity();

            Console.WriteLine();

            //Part 2
            Weather weatherDay1 = -weatherMonday;
            OutputData.PrintObjectProperties(weatherDay1);

            Console.WriteLine($"Истинность утверждения, что влажность воздуха выше 80%: {!weatherDay1}");

            double humIndexValue = weatherThursday;
            Console.WriteLine(humIndexValue);

            Console.WriteLine($"Истинность утверждения о том, что атмосферное давление в понедельник выше нормы (760 мм рт. ст.): {(bool)weatherMonday}");
            Console.WriteLine($"Истинность утверждения о том, что атмосферное давление во вторник выше нормы (760 мм рт. ст.): {(bool)weatherTuesday}");

            OutputData.PrintObjectProperties(weatherThursday-5);

            OutputData.PrintObjectProperties(weatherThursday * 1.5);

            Console.WriteLine(weatherDay1.Equals(5));

            Console.WriteLine();

            //Part 3
            WeatherObjectsCollection weatherArray1 = new(5); //создание новой коллекции, содержащей 5 объектов, заполненных случайными числами
            OutputData.PrintWeatherArrayElements(weatherArray1); //вывод объектов коллекции
            Console.WriteLine();

            WeatherObjectsCollection weatherArray2 = OutputData.CreateWeatherCollection(5); //создание новой коллекции, содержащей 5 объектов, заполненных случайными числами
            OutputData.PrintWeatherArrayElements(weatherArray2); //вывод объектов коллекции
            Console.WriteLine();

            WeatherObjectsCollection weatherArray3 = new(weatherArray1); //создание новой коллекции, являющейся копией другой коллекции
            OutputData.PrintWeatherArrayElements(weatherArray3); //вывод созданной коллекции
            Console.WriteLine();

            weatherArray1[0] = new Weather(30, 6, 800); //запись объекта с существующим индексом
            OutputData.PrintWeatherArrayElements(weatherArray1);
            OutputData.PrintWeatherArrayElements(weatherArray2);

            OutputData.PrintObjectProperties(weatherArray1[1]); //получение объекта с существующим индексом

            try
            {
                OutputData.PrintObjectProperties(weatherArray1[5]); //получение объекта с несуществующим индексом
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }

            try
            {
                weatherArray1[-1] = new Weather(); //запись объекта с несуществующим индексом
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            Console.WriteLine();

            PrintArrayTemperatureAmplitude(weatherArray1);
            Console.WriteLine();

            OutputData.PrintObjectsQuantity();
            OutputData.PrintCollectionsQuantity();
        }
    }
}
