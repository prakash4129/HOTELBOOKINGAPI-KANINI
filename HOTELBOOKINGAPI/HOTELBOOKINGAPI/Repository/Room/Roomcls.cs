using HOTELBOOKINGAPI.Models;
namespace HOTELBOOKINGAPI.Repository.Room
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

namespace HOTELBOOKINGAPI.Repository.Room
{
    public class Roomcls : IRoom
    {

        private readonly HotelContext _context;

        public Roomcls(HotelContext context)
        {
            _context = context;
        }

        //---------------------------------------------
        //posting hotels 
        public async Task<Rooms> PostRoom(Rooms room)
        {
            var itm = await _context.rooms.AddAsync(room);
            if (itm == null)
            {
                throw new Exception("error");
            }
            _context.SaveChanges();
            return room;
        }

        //----------------------------------------------
        //getting hotel details 
        public async Task<IEnumerable<Rooms>> GetRooms()
        {
            var ht = await _context.rooms.ToListAsync();
            if (ht == null)
            {
                throw new Exception("error");
            }
            return ht;
        }

        //-------------------------------------------------------------
        //getting specific hotel by calling its id
        public async Task<Rooms> GetRoom(int id)
        {
            Rooms dp = await _context.rooms.FirstOrDefaultAsync(x => x.RoomId == id);
            if (dp == null)
            {
                throw new Exception("Invalid hotel id");
            }
            return dp;
        }

        //--------------------------------------------------------------------
        public async Task<Rooms> PutRoom(int id, Rooms room)
        {
            Rooms dp = await _context.rooms.FirstOrDefaultAsync(x => x.RoomId == id);
            dp.RoomType = room.RoomType;
            if (dp.RoomType == null)
            {
                throw new Exception("Invalid User");
            }
            return dp;
        }

        //----------------------------------------------------------------------
        public async Task<string> DeleteRoom(int id)
        {
            Rooms dp = await _context.rooms.FirstOrDefaultAsync(x => x.RoomId == id);
            if (dp == null)
            {
                throw new Exception("Invalid Hotel");
            }
            _context.Remove(dp);
            _context.SaveChanges();
            return "deleted Successfully";
        }
    }
}

