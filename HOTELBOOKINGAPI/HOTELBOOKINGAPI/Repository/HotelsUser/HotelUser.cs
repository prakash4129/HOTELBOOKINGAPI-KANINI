namespace HOTELBOOKINGAPI.Repository.HotelsUser
{
    public class HotelUser
    {
        public string? Place { get; set; } = string.Empty;
        public string? HotelName { get; set; } = string.Empty;

        public string? Phone { get; set; } = string.Empty;

        public int TotalRoomCount { get; set; }

        public string RoomType { get; set; }

        public string RoomStatus { get; set; }

        public string? RoomPricePerNight { get; set; }

    }
}