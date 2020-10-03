using BuildWebAPPFromConsole.Model;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace BuildWebAPPFromConsole.Repository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> CreateUserAsync(SignUpUserModel userModel);
    }
}