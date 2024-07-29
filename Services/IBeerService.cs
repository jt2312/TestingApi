using ASPTesting.Models;

namespace ASPTesting.Services
{
    public class IBeerService : IBeer
    {


        public List<Beer> _beers = new List<Beer>()
        {
            new Beer() {Id = 1, Nombre = "Corona", Brand = "Modelo"},

            new Beer() {Id = 2, Nombre = "Quilmes", Brand = "AB InBev"},

            new Beer() {Id = 3, Nombre = "Amstel", Brand = "Heineken industries"}

        };





        public IEnumerable<Beer> Get() => _beers;

        public Beer? Get(int id) => _beers.FirstOrDefault(x => x.Id == id);




    }
}
