using System;

namespace Cau3_DaNgoai.Models
{
    public class ChuyenDi
    {
        public int MaChuyen { get; set; }
        public string TenChuyen { get; set; } = string.Empty;
        public string DiaDiem { get; set; } = string.Empty;
        public DateTime NgayDi { get; set; }
        public int SoNguoi { get; set; }
        public decimal NganSach { get; set; }
        public string PhuongTien { get; set; } = string.Empty;
        public bool DaHoanThanh { get; set; }
        public string? GhiChu { get; set; }
    }
}
