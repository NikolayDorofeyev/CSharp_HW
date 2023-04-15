using WebApp.Interfaces;

namespace WebApp.Classes
{
    public class RandomCounter : ICounter
    {
        static Random rnd = new Random();

        int value;

        public RandomCounter()
        {
            value = rnd.Next(0, 1000);
        }

        public int Count => value;
    }
}
