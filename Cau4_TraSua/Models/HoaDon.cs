using System;
using System.Collections.Generic;

namespace Cau4_TraSua.Models
{
    public class HoaDon
    {
        public int MaHD { get; set; }
        public DateTime NgayLap { get; set; } = DateTime.Now;
        public decimal TongTien { get; set; }
        public string HinhThucTT { get; set; } = "Tiền mặt";
        public bool DaThanhToan { get; set; } = true;

        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; } = new List<ChiTietHoaDon>();
    }
}
