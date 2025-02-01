namespace lab9
{
    internal class Program
    {
        static void Main()
        {
            // Part 1
            Weather weatherMonday = new Weather();
            weatherMonday.ShowWeatherConditions();

            Weather weatherTuesday = new Weather(30, 5, 800);
            weatherTuesday.ShowWeatherConditions();

            Weather weatherWednesday = new Weather(weatherTuesday);
            weatherWednesday.ShowWeatherConditions();

            Weather weatherThursday = new Weather(25.5);
            weatherThursday.ShowWeatherConditions();
            weatherThursday.ShowDewPoint();

            Weather.ShowDewPoint(20.5, 27);

            Weather.ShowObjectsQuantity();


        }
    }
}
