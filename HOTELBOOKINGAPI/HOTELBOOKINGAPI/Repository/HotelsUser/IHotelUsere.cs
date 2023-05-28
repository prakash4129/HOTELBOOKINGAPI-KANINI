using HOTELBOOKINGAPI.Models;

namespace HOTELBOOKINGAPI.Repository.HotelsUser
{
    public interface IHotelUsere
    {
        public Task<IEnumerable<HotelUser>> GetAvailableHotels();

        public Task<IEnumerable<HotelUser>> GetAvailablePlaceHotels();

        public Task<IEnumerable<HotelUser>> GetAvailablePriceHotels();
    }
}