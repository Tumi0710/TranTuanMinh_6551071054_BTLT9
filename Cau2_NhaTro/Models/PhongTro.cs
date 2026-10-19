using System.Collections.Generic;

namespace Cau2_NhaTro.Models
{
    public class PhongTro
    {
        public int MaPhong { get; set; }
        public string TenPhong { get; set; } = string.Empty;
        public decimal GiaThue { get; set; }
        public string TinhTrang { get; set; } = "Trống";

        public virtual ICollection<KhachThue> KhachThues { get; set; } = new List<KhachThue>();
    }
}
