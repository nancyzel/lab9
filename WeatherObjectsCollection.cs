namespace lab9
{
    internal class WeatherObjectsCollection
    {
        Random randomNumber = new Random();

        Weather[] weatherObjectsArray;

        private int arrayLength;

        public int Length
        {
            get => weatherObjectsArray.Length; 
        }

        public WeatherObjectsCollection()
        {
            weatherObjectsArray = new Weather[100];
            for (int i = 0; i < 100; i++)
            {
                weatherObjectsArray[i] = new Weather();
            }
        }

        public WeatherObjectsCollection(int arrayLength)
        {
            weatherObjectsArray = new Weather[arrayLength];
            for (int i = 0; i < arrayLength;i++)
            {
                weatherObjectsArray[i] = new Weather(randomNumber.Next(-4000, 4000) / (double)100, randomNumber.Next(0, 100), randomNumber.Next(730, 800));
            }
        }

        public void Show()
        {
            for (int i = 0; i < this.Length; i++)
            {
                Console.WriteLine(weatherObjectsArray[i]);
            }
        }

        public Weather this[int index]
        {
            get
            {
                if (index >= 0 && index < weatherObjectsArray.Length)
                {
                    return weatherObjectsArray[index];
                }
                else
                    throw new IndexOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < weatherObjectsArray.Length)
                {
                    weatherObjectsArray[index] = value;
                }
                else
                    throw new IndexOutOfRangeException();
            }
        }
    }
}
