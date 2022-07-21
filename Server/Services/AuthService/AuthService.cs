using EcommerceWebAsmb.Server.Data;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace EcommerceWebAsmb.Server.Services.AuthService
{
    public class AuthService : IAuthService
    {
        private readonly DataContext _context;

        public AuthService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<int>> Register(User user, string password)
        {
            if(user is null)
            {
                return new ServiceResponse<int>
                {
                    status = false,
                    message = "Please provide email & password"
                };
            }
            if(await UserExits(user.Email))
            {
                return new ServiceResponse<int>
                {
                    status = false,
                    message = "User already exists"
                };
            }
            CreatePasswordHash(password, out byte[] passwordHash, out byte[] passwordSalt);
            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            _context.User.Add(user);
            await _context.SaveChangesAsync();

            return new ServiceResponse<int> { Data = user.Id };
        }

        public async Task<bool> UserExits(string Email)
        {
           if(await _context.User.AnyAsync(user => user.Email.ToLower().Equals(Email.ToLower()))){
                return true;
            }
           else
                return false;
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt )
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
    }
}
