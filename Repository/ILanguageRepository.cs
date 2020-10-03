using BuildWebAPPFromConsole.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BuildWebAPPFromConsole.Repository
{
    public interface ILanguageRepository
    {
        Task<List<LanguageModel>> GetLanguages();
    }
}