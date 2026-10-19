using System;

namespace Cau2_NhaTro.Models
{
    public class KhachThue
    {
        public int MaKhach { get; set; }
        public string HoTen { get; set; } = string.Empty;
        public string GioiTinh { get; set; } = "Nam";
        public DateTime NgaySinh { get; set; }
        public string SoDienThoai { get; set; } = string.Empty;
        public int MaTinh { get; set; }
        public string TenTinh { get; set; } = string.Empty;
        public int MaPhuongXa { get; set; }
        public string TenPhuongXa { get; set; } = string.Empty;
        public bool DaDangKyTamTru { get; set; }
        public int MaPhong { get; set; }

        public virtual PhongTro? PhongTro { get; set; }
    }
}
