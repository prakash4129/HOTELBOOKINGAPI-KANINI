using HOTELBOOKINGAPI.Models;
using HOTELBOOKINGAPI.Repository.Room;
using HOTELBOOKINGAPI.Repository.users;
namespace HOTELBOOKINGAPI.Repository.users
{
    public class Usercl : IUser
    {
        private readonly HotelContext _context;

        public Usercl(HotelContext context)
        {
            _context = context;
        }

        public async Task<User> PostUser(User users)
        {
            var itm = await _context.users.AddAsync(users);
            if (itm == null)
            {
                throw new Exception("error");
            }
            _context.SaveChanges();
            return users;
        }
    }
}