using Korelskiy.BlazorTrainingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Korelskiy.BlazorTrainingApp.Repository
{
    public class MockGamesRepository : IRepository
    {
        private List<Game> _games;
        public MockGamesRepository()
        {
            _games = new List<Game>()
            {
                new Game()
                {
                    Name = "The Elder Scrolls 5: Skyrim",
                    Genre = "Action/RPG",
                    ReleaseDate = new DateTime(2011, 11, 11)
                },
                new Game()
                {
                    Name = "Grand Theft Auto 5",
                    Genre = "Action/Adventure",
                    ReleaseDate = new DateTime(2013, 09, 17)
                },
                new Game()
                {
                    Name = "Grand Theft Auto 4",
                    Genre = "Action/Adventure",
                    ReleaseDate = new DateTime(2008, 04, 29)
                }
            };
        }
        public List<Game> GetAllGames()
        {
            return _games;
        }
    }
}
