using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luyentap_05
{
    public partial class Form2 : Form
    {
        public List<NhanVien> nhanViens = new List<NhanVien>();
        
        public Form2()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (File.Exists("nhanvien.json"))
            {
                string json = File.ReadAllText("nhanvien.json");
                nhanViens = JsonConvert.DeserializeObject<List<NhanVien>>(json) ?? new List<NhanVien>();
            }
            string url = pictureBox1.ImageLocation;

            nhanViens.Add(new NhanVien(
                txtMaNV.Text,
                txtHoten.Text,
                dtpNamSinh.Value.Year.ToString(),
                cbbGioitinh.Text,
                txtBoPhan.Text,
                txtChucVu.Text,
                txtHopDong.Text,
                txtDiaChi.Text,
                dtpNgayVao.Value.ToString("yyyy-MM-dd"),
                dtpNgayRa.Value.ToString("yyyy-MM-dd"),
                txtDanToc.Text,
                txtCanCuoc.Text,
                txtSDT.Text,
                txtEmail.Text,
                url
            ));

            string newJson = JsonConvert.SerializeObject(nhanViens, Formatting.Indented);
            File.WriteAllText("nhanvien.json", newJson);
           
            Form1 form1 = new Form1();
            form1.Owner = this;
            form1.updateDataGRV();
            
            this.Close();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            if (File.Exists("nhanvien.json"))
            {
                string json = File.ReadAllText("nhanvien.json");
                nhanViens = JsonConvert.DeserializeObject<List<NhanVien>>(json) ?? new List<NhanVien>();
            }
            string url = pictureBox1.ImageLocation;

            nhanViens.Add(new NhanVien(
                txtMaNV.Text,
                txtHoten.Text,
                dtpNamSinh.Value.Year.ToString(),
                cbbGioitinh.Text,
                txtBoPhan.Text,
                txtChucVu.Text,
                txtHopDong.Text,
                txtDiaChi.Text,
                dtpNgayVao.Value.ToString("yyyy-MM-dd"),
                dtpNgayRa.Value.ToString("yyyy-MM-dd"),
                txtDanToc.Text,
                txtCanCuoc.Text,
                txtSDT.Text,
                txtEmail.Text,
                url
            ));

            string newJson = JsonConvert.SerializeObject(nhanViens, Formatting.Indented);
            File.WriteAllText("nhanvien.json", newJson);

            txtMaNV.Text = "";
            txtHoten.Text = "";
            txtBoPhan.Text = "";
            txtChucVu.Text = "";
            txtHopDong.Text = "";
            txtDiaChi.Text = "";
            txtDanToc.Text = "";
            txtCanCuoc.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            pictureBox1.Image = null;
        }
            private void btnXoa_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = "";
            txtHoten.Text = "";
            txtBoPhan.Text = "";
            txtChucVu.Text = "";
            txtHopDong.Text = "";
            txtDiaChi.Text = "";
            txtDanToc.Text = "";
            txtCanCuoc.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            pictureBox1.Image = null;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog.Title = "Chọn hình ảnh";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                pictureBox1.Image = Image.FromFile(filePath);
                pictureBox1.ImageLocation = filePath;
            }

            openFileDialog.Dispose();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
