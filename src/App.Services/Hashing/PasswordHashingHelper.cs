using Microsoft.AspNetCore.Identity;

namespace App.Services.Hashing
{
    public static class PasswordHashingHelper
    {
        public static string Hash<TUser>(TUser user, string password)
            where TUser : class
        {
            return new PasswordHasher<TUser>().HashPassword(user, password);
        }
    }
}
