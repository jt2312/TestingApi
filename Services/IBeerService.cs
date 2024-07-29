using ASPTesting.Models;

namespace ASPTesting.Services
{
    public interface IBeerService
    {
        public IEnumerable<Beer> Get();
        public Beer? Get(int id);

    }
}
