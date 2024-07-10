namespace Tenaka_Core.Interfaces
{
    public interface IAuthService
    {
         public Task<bool> AuthenticateAsync(string username, string password);
    }
}
