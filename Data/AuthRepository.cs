using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using POSApp.API.Models;

namespace POSApp.API.Data
{
    public class AuthRepository : IAuthRepository
    {
        private readonly DataContext _context;
        public AuthRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<user> Login(string username, string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x=>x.username==username);

            if(user == null)
                return null;

            if(!VerifyPasswordHash(password,user.passwordhash,user.psswordsalt))
                return null;

            return user;

        }

        private bool VerifyPasswordHash(string password, byte[] passwordhash, byte[] psswordsalt)
        {
             using(var hmac = new System.Security.Cryptography.HMACSHA512(psswordsalt))
           {
               var ComputedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
               for(int i=0; i<ComputedHash.Length; i++ )
               {
                   if(ComputedHash[i]!=passwordhash[i]) return false;
               }
           }
           return true;
        }

        public async Task<user> Register(user user, string password)
        {
            byte[] passwordHash, passwordSalt;
            CreatePasswordHash(password,out passwordHash,out passwordSalt);  

            user.passwordhash = passwordHash;
            user.psswordsalt = passwordSalt;

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return user;        
            
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
           using(var hmac = new System.Security.Cryptography.HMACSHA512())
           {
               passwordSalt = hmac.Key;
               passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
           }
        }

        public async Task<bool> UserExist(string username)
        {
           if(await _context.Users.AnyAsync(x=>x.username == username))
            return true;

            return false;
        }
    }
}