namespace lab9
{
    internal class OutputClass
    {
        

        public static void PrintDewPointValue(double temperature, int humidity, double dewPoint)
        {
            Console.WriteLine($"Точка росы при температуре {temperature}°C и влажности {humidity}% составляет {dewPoint}.");
        }
    }
}
