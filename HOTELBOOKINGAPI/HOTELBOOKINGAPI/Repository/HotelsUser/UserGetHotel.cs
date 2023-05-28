using HOTELBOOKINGAPI.Models;
using HOTELBOOKINGAPI.Repository.HotelsUser;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

//counts performances
namespace Kanini_Assessment.Repository.HotelsUser
{
    public class UserGetHotel : IHotelUsere
    {
        private readonly HotelContext context;

        public UserGetHotel(HotelContext hotelContext)
        {
            this.context = hotelContext;
        }

        //getting rooms available hotels
        public async Task<IEnumerable<HotelUser>> GetAvailableHotels()
        {
            var ans = (from h in context.hotels
                       join r in context.rooms on h.HotelId equals r.HotelId
                       where r.RoomStatus == "Available"
                       select new HotelUser()
                       {
                           HotelName = h.HotelName,
                           Phone = h.Phone,
                           TotalRoomCount = context.rooms.Count(s => s.RoomStatus == "Available")
                       }).ToListAsync();
            if (ans == null)
            {
                throw new Exception("hotel does not have available rooms");
            }
            return await ans;
        }


        //getting rooms available hotels
        public async Task<IEnumerable<HotelUser>> GetAvailablePlaceHotels()
        {
            var place = (from h in context.hotels
                         join r in context.rooms on h.HotelId equals r.HotelId
                         where h.Place == "chennai"
                         select new HotelUser()
                         {
                             Place = h.Place,
                             HotelName = h.HotelName,
                             Phone = h.Phone,
                             TotalRoomCount = context.rooms.Count(s => s.RoomStatus == "Available")
                         }).ToListAsync();
            if (place == null)
            {
                throw new Exception("Hotel does not in this place for booking");
            }
            return await place;
        }

        public async Task<IEnumerable<HotelUser>> GetAvailablePriceHotels()
        {
            var price = (from h in context.hotels
                         join r in context.rooms on h.HotelId equals r.HotelId
                         where r.RoomPricePerNight == "200"
                         select new HotelUser()
                         {
                             Place = h.Place,
                             HotelName = h.HotelName,
                             Phone = h.Phone,
                             TotalRoomCount = context.rooms.Count(s => s.RoomStatus == "Available"),
                             RoomPricePerNight = r.RoomPricePerNight,
                             RoomType = r.RoomType,
                         }).ToListAsync();
            if (price == null)
            {
                throw new Exception("Price range hotel not available");
            }
            return await price;
        }

    }
}
