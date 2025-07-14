using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace DemoMVC.Models
{
    public class DaiLy
    {
        public string MaDaiLy { get; set; }
        public string TenDaiLy { get; set; }
        public string DiaChi { get; set; }
        public string NguoiDaiDien { get; set; }
        public string DienThoai { get; set; }

        // Liên kết với hệ thống phân phối
        public string MaHTPP { get; set; }
        [ForeignKey("MaHTPP")]
        public HeThongPhanPhoi HeThongPhanPhoi { get; set; }
    }
}