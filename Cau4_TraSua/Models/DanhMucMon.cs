using System.Collections.Generic;

namespace Cau4_TraSua.Models
{
    public class DanhMucMon
    {
        public int MaDM { get; set; }
        public string TenDM { get; set; } = string.Empty;

        public virtual ICollection<MonUong> MonUongs { get; set; } = new List<MonUong>();

        public override string ToString() => TenDM;
    }
}
