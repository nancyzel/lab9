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

            Weather weatherThursday = new Weather(25.5);
            OutputData.PrintObjectProperties(weatherThursday);
            weatherThursday.ShowDewPoint();

            Weather.ShowDewPoint(20.5, 27);

            Weather.ShowObjectsQuantity();


        }
    }
}
