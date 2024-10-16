using System;

namespace Luyentap_05
{
    public class NhanVien
    {
        // Các thuộc tính
        public string MaNV { get; set; }
        public string Ten { get; set; }
        public string NamSinh { get; set; }
        public string GioiTinh { get; set; }
        public string BoPhan { get; set; }
        public string ChucVu { get; set; }
        public string HopDong { get; set; }
        public string DiaChi { get; set; }
        public string NgayVao { get; set; }
        public string NgayRa { get; set; }
        public string DanToc { get; set; }
        public string CCCD { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }

        public string Img {  get; set; }
        public NhanVien()
        {
        }
        public NhanVien(string maNV, string ten, string namsinh, string gioiTinh, string boPhan,
                        string chucVu, string hopDong, string diaChi, string ngayVao,
                        string ngayRa, string danToc, string cccd, string sdt, string email, string img)
        {
            MaNV = maNV;
            Ten = ten;
            NamSinh = namsinh;
            GioiTinh = gioiTinh;
            BoPhan = boPhan;
            ChucVu = chucVu;
            HopDong = hopDong;
            DiaChi = diaChi;
            NgayVao = ngayVao;
            NgayRa = ngayRa;
            DanToc = danToc;
            CCCD = cccd;
            SDT = sdt;
            Email = email;
            Img = img;
        }
    }
}