using WebApp.Interfaces;

namespace WebApp.Classes
{
    public class ShortTimeService : ITimeService
    {
        public string GetUtcTime()
        {
            return DateTime.UtcNow.ToShortTimeString(); // hh:mm
        }
    }
    public class LongTimeService : ITimeService
    {
        public string GetUtcTime()
        {
            return DateTime.UtcNow.ToLongTimeString(); // hh:mm:ss
        }
    }
}
