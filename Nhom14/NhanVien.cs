namespace Phan1_QuanLyNhanVien
{
    public class NhanVien
    {
        public string MaSo { get; set; }
        public string HoTen { get; set; }
        public string NgaySinh { get; set; }
        public string Email { get; set; }

        public NhanVien(string maSo, string hoTen, string ngaySinh, string email)
        {
            MaSo = maSo;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            Email = email;
        }
    }
}