namespace HotelProject.PresentationLayer.Models
{
    public class RoomViewList
    {
        public List<HotelProject.Entitylayer.Concrete.Room> Rooms { get; set; } // Oda listesi
        public int TotalPages { get; set; } // Toplam sayfa sayısı
        public int CurrentPage { get; set; } // Geçerli sayfa numarası
    }
}
