using Microsoft.AspNetCore.Mvc;
using HOTELBOOKINGAPI.Models;
using System.Threading.Tasks;

namespace HOTELBOOKINGAPI.Repository.Room
{
    public interface IRoom
    {
        Task<Rooms> PostRoom(Rooms room);
        Task<IEnumerable<Rooms>> GetRooms();
        Task<Rooms> GetRoom(int id);
        Task<Rooms> PutRoom(int id, Rooms room);
        Task<string> DeleteRoom(int id);
    }
}