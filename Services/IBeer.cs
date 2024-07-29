using ASPTesting.Models;

namespace ASPTesting.Services
{
    public interface IBeer
    {
        public IEnumerable<Beer> Get();
        public Beer? Get(int id);

    }
}
