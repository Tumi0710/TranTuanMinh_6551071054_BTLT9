using System.Collections.Generic;

namespace Cau4_TraSua.Models
{
    public class MonUong
    {
        public int MaMon { get; set; }
        public string TenMon { get; set; } = string.Empty;
        public decimal GiaBan { get; set; }
        public bool DangBan { get; set; } = true;
        public int MaDM { get; set; }

        public virtual DanhMucMon? DanhMucMon { get; set; }
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; } = new List<ChiTietHoaDon>();

        public override string ToString() => $"{TenMon} - {GiaBan:N0} đ";
    }
}
