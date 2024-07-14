using SMA.API.Entities;

namespace SMA.API.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser appUser);
    }
}
