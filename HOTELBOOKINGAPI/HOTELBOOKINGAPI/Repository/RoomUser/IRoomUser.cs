using HOTELBOOKINGAPI.Models;
using HOTELBOOKINGAPI.Repository.HotelsUser;
namespace HOTELBOOKINGAPI.Repository.RoomUser
{
    public interface IRoomUser
    {
        public Task<IEnumerable<RoomUserTable>> GetAvailableRooms();

        public Task<IEnumerable<RoomUserTable>> GetAffordablePriceRooms();

        public Task<IEnumerable<RoomUserTable>> RoomBookingStatus();
    }
}