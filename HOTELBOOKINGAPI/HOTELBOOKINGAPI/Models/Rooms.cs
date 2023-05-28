using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HOTELBOOKINGAPI.Models
{
    public class Rooms
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RoomId { get; set; }

        [ForeignKey(nameof(Hotels))]
        public int HotelId { get; set; }

        public string? RoomType { get; set; }

        public string? RoomStatus { get; set; }

        public string? RoomPricePerNight { get; set; }

    }
}