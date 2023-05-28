using HOTELBOOKINGAPI.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HOTELBOOKINGAPI.Repository.Hotel
{
    public class Hotelcl : IHotel
    {

        private readonly HotelContext _context;

        public Hotelcl(HotelContext context)
        {
            _context = context;
        }

        //---------------------------------------------
        //posting hotels 
        public async Task<Hotels> PostHotel(Hotels hotel)
        {
            var itm = await _context.hotels.AddAsync(hotel);
            if (itm == null)
            {
                throw new Exception("error");
            }
            _context.SaveChanges();
            return hotel;
        }

        //----------------------------------------------
        //getting hotel details 
        public async Task<IEnumerable<Hotels>> GetHotels()
        {
            var ht = await _context.hotels.ToListAsync();
            if (ht == null)
            {
                throw new Exception("error");
            }
            return ht;
        }

        //-------------------------------------------------------------
        //getting specific hotel by calling its id
        public async Task<Hotels> GetHotel(int id)
        {
            Hotels dp = await _context.hotels.FirstOrDefaultAsync(x => x.HotelId == id);
            if (dp == null)
            {
                throw new Exception("Invalid hotel id");
            }
            return dp;
        }

        //--------------------------------------------------------------------
        public async Task<Hotels> PutHotel(int id, Hotels hotel)
        {
            Hotels dp = await _context.hotels.FirstOrDefaultAsync(x => x.HotelId == id);
            dp.HotelName = hotel.HotelName;
            if (dp.HotelName == null)
            {
                throw new Exception("Invalid User");
            }
            return dp;
        }

        //----------------------------------------------------------------------
        public async Task<string> DeleteHotel(int id)
        {
            Hotels dp = await _context.hotels.FirstOrDefaultAsync(x => x.HotelId == id);
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