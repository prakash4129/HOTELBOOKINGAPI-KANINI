namespace HOTELBOOKINGAPI.Repository.RoomUser
    public class RoomUserTable
    {
        public string? Place { get; set; } = string.Empty;
        public string? HotelName { get; set; } = string.Empty;

        public string? Phone { get; set; } = string.Empty;

        public int AvailableRoomCount { get; set; }

        public string RoomType { get; set; }

        public string RoomStatus { get; set; }

        public string? RoomPricePerNight { get; set; }
    }
}