//using Microsoft.EntityFrameworkCore;
//using WebAppAuthIdentity.Data;
//using WebAppAuthIdentity.Models;

//namespace WebAppAuthIdentity.Service
//{
//    public class AuthService : IAuthService
//    {
//        private readonly ApplicationDbContext _context;

//        public AuthService(ApplicationDbContext context)
//        {
//            _context = context; 
//        }

//        public async Task<User> ValidateUser(string userName, string password)
//        {
//            try
//            {
//                var dbUser = await _context.Users.FirstOrDefaultAsync(f => f.userName == userName && f.password == password);

//                if (dbUser == null)
//                    throw new Exception(message: "I suppose user not found");
//                else
//                    return dbUser;
//            }
//            catch
//            {
//                throw new Exception(message: "Error");
//            }
//        }
//    }
//}
