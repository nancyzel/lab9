namespace lab9
{
    internal class Program
    {
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

            Console.WriteLine();
        }
    }
}
