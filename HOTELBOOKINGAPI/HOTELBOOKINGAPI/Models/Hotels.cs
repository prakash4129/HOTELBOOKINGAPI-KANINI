using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HOTELBOOKINGAPI.Models
{
    public class Hotels
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int HotelId { get; set; }

        public string? HotelName { get; set; } = string.Empty;

        public string? Place { get; set; } = string.Empty;

        public string? Phone { get; set; } = string.Empty;

        public ICollection<Rooms> rooms { get; set; } = new List<Rooms>();

    }
}