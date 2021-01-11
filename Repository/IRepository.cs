using Korelskiy.BlazorTrainingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Korelskiy.BlazorTrainingApp.Repository
{
    public interface IRepository
    {
        List<Game> GetAllGames();
    }
}
