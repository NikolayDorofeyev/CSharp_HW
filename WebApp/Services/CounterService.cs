using WebApp.Interfaces;

namespace WebApp.Services
{
    public class CounterService
    {
        public ICounter Counter { get; }

        public CounterService(ICounter counter)
        {
            Counter = counter;
        }
    }
}
