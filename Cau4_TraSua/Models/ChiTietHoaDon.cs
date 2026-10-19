namespace Cau4_TraSua.Models
{
    public class ChiTietHoaDon
    {
        public int MaHD { get; set; }
        public int MaMon { get; set; }
        public int SoLy { get; set; }
        public decimal DonGia { get; set; }

        public virtual HoaDon? HoaDon { get; set; }
        public virtual MonUong? MonUong { get; set; }
    }
}
