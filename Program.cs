using UoWRepository.Models;
using UoWRepository.UoW;

namespace UoWRepository
{
    public class Program
    {
        static void Main()
        {
            using (var unitOf = new UnitOfWork(new GameContext()))
            {

                var country = new Country { CountryName = "Ukraine" };
                var country1 = new Country { CountryName = "Poland" };

                var countries = new List<Country> { country, country1 };
                unitOf.Country.AddRange(countries);
                unitOf.Save();

                var city = new City { CityName = "Lviv", Country = country };
                var city1 = new City { CityName = "Poznan", Country = country1 };

                var cities = new List<City> { city, city1 };
                unitOf.City.AddRange(cities);
                unitOf.Save();

                var studio = new Studio { StudioName = "UPA", City = city };
                var studio1 = new Studio { StudioName = "Polska", City = city1 };

                var studios = new List<Studio> { studio, studio1 };
                unitOf.Studio.AddRange(studios);
                unitOf.Save();

                var game1 = new Game
                {
                    Name = "Game 1",
                    Studio = studio,
                    Genre = "Action",
                    ReleaseDate = "20.10.2002",
                    GetMode = (GameMode)0,
                    SoldCopies = 100000
                };

                var game2 = new Game
                {
                    Name = "Game 2",
                    Studio = studio1,
                    Genre = "RPG",
                    ReleaseDate = "2.11.2005",
                    GetMode = (GameMode)1,
                    SoldCopies = 50000
                };

                var games = new List<Game> { game1, game2 };
                unitOf.Game.AddRange(games);
                unitOf.Save();

                var game = unitOf.Game.GetAll();

                foreach (var item in game)
                {
                    Console.WriteLine($"{item.Name} + {item.Genre} + {item.GetMode} + {item.ReleaseDate}");
                }
            }
        }
    }
}