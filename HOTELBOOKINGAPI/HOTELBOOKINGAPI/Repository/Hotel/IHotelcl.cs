using Microsoft.AspNetCore.Mvc;
using Kanini_Assessment.Models;
using System.Threading.Tasks;
using HOTELBOOKINGAPI.Models;

namespace HOTELBOOKINGAPI.Repository
{
    public interface IHotel
    {
        Task<Hotels> PostHotel(Hotels hotel);
        Task<IEnumerable<Hotels>> GetHotels();
        Task<Hotels> GetHotel(int id);
        Task<Hotels> PutHotel(int id, Hotels hotel);
        Task<string> DeleteHotel(int id);
    }
}