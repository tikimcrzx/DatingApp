using API.Entities;

namespace API.Interfaces
{
    public interface ITokenService
    {
        string CretateToken(AppUser user);
    }
}