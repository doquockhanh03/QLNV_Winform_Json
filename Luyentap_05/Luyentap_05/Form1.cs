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
    public partial class Form1 : Form
    {
        public List<NhanVien> nhanViens;
        public int index = 0;
        public Form1()
        {
            InitializeComponent();

            string json = File.ReadAllText("nhanvien.json");
            nhanViens = JsonConvert.DeserializeObject<List<NhanVien>>(json);

            dataGridView1.DataSource = nhanViens;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
        public void updateDataGRV()
        {
            if (File.Exists("nhanvien.json"))
            {
                string json = File.ReadAllText("nhanvien.json");
                nhanViens = JsonConvert.DeserializeObject<List<NhanVien>>(json) ?? new List<NhanVien>();
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = nhanViens;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NhanVien select = (NhanVien)dataGridView1.Rows[e.RowIndex].DataBoundItem;
            index = e.RowIndex;
            pictureBox2.Image = null;
            richTextBox1.Clear();
            richTextBox1.AppendText("Mã Nhân viên: " + select.MaNV + Environment.NewLine);
            richTextBox1.AppendText("Tên Nhân Viên: " + select.Ten + Environment.NewLine);
            richTextBox1.AppendText("Năm Sinh: " + select.NamSinh + Environment.NewLine);
            richTextBox1.AppendText("Giới Tính: " + select.GioiTinh + Environment.NewLine);
            richTextBox1.AppendText("Bộ phận: " + select.BoPhan + Environment.NewLine);
            richTextBox1.AppendText("Chức Vụ: " + select.ChucVu + Environment.NewLine);
            richTextBox1.AppendText("Hợp đồng: " + select.HopDong + Environment.NewLine);
            richTextBox1.AppendText("Địa chỉ: " + select.DiaChi + Environment.NewLine);
            richTextBox1.AppendText("Ngày vào: " + select.NgayVao + Environment.NewLine);
            richTextBox1.AppendText("Ngày ra: " + select.NgayRa + Environment.NewLine);
            richTextBox1.AppendText("Dân tộc: " + select.DanToc + Environment.NewLine);
            richTextBox1.AppendText("CCCD: " + select.CCCD + Environment.NewLine);
            richTextBox1.AppendText("SDT: " + select.SDT + Environment.NewLine);
            richTextBox1.AppendText("Email: " + select.Email + Environment.NewLine);

            LoadImage(select.Img);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.SelectedRows[0].Index;

            nhanViens.RemoveAt(index);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = nhanViens;

            string newJson = JsonConvert.SerializeObject(nhanViens, Formatting.Indented);
            File.WriteAllText("nhanvien.json", newJson);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if(index > 0)
            {
                index--;
                dataGridView1.Rows[index].Selected = true;
                NhanVien select = nhanViens[index];
                richTextBox1.Clear();
                pictureBox2.Image = null;

                richTextBox1.AppendText("Mã Nhân viên: " + select.MaNV + Environment.NewLine);
                richTextBox1.AppendText("Tên Nhân Viên: " + select.Ten + Environment.NewLine);
                richTextBox1.AppendText("Năm Sinh: " + select.NamSinh + Environment.NewLine);
                richTextBox1.AppendText("Giới Tính: " + select.GioiTinh + Environment.NewLine);
                richTextBox1.AppendText("Bộ phận: " + select.BoPhan + Environment.NewLine);
                richTextBox1.AppendText("Chức Vụ: " + select.ChucVu + Environment.NewLine);
                richTextBox1.AppendText("Hợp đồng: " + select.HopDong + Environment.NewLine);
                richTextBox1.AppendText("Địa chỉ: " + select.DiaChi + Environment.NewLine);
                richTextBox1.AppendText("Ngày vào: " + select.NgayVao + Environment.NewLine);
                richTextBox1.AppendText("Ngày ra: " + select.NgayRa + Environment.NewLine);
                richTextBox1.AppendText("Dân tộc: " + select.DanToc + Environment.NewLine);
                richTextBox1.AppendText("CCCD: " + select.CCCD + Environment.NewLine);
                richTextBox1.AppendText("SDT: " + select.SDT + Environment.NewLine);
                richTextBox1.AppendText("Email: " + select.Email + Environment.NewLine);
                LoadImage(select.Img);

                dataGridView1.Rows[index + 1].Selected = false;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (index < nhanViens.Count - 1)
            {
                index++; 
                dataGridView1.Rows[index].Selected = true; 
                
                NhanVien select = nhanViens[index];
                richTextBox1.Clear();
                pictureBox2.Image = null;
                richTextBox1.AppendText("Mã Nhân viên: " + select.MaNV + Environment.NewLine);
                richTextBox1.AppendText("Tên Nhân Viên: " + select.Ten + Environment.NewLine);
                richTextBox1.AppendText("Năm Sinh: " + select.NamSinh + Environment.NewLine);
                richTextBox1.AppendText("Giới Tính: " + select.GioiTinh + Environment.NewLine);
                richTextBox1.AppendText("Bộ phận: " + select.BoPhan + Environment.NewLine);
                richTextBox1.AppendText("Chức Vụ: " + select.ChucVu + Environment.NewLine);
                richTextBox1.AppendText("Hợp đồng: " + select.HopDong + Environment.NewLine);
                richTextBox1.AppendText("Địa chỉ: " + select.DiaChi + Environment.NewLine);
                richTextBox1.AppendText("Ngày vào: " + select.NgayVao + Environment.NewLine);
                richTextBox1.AppendText("Ngày ra: " + select.NgayRa + Environment.NewLine);
                richTextBox1.AppendText("Dân tộc: " + select.DanToc + Environment.NewLine);
                richTextBox1.AppendText("CCCD: " + select.CCCD + Environment.NewLine);
                richTextBox1.AppendText("SDT: " + select.SDT + Environment.NewLine);
                richTextBox1.AppendText("Email: " + select.Email + Environment.NewLine);
                LoadImage(select.Img);

                dataGridView1.Rows[index - 1].Selected = false;

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void LoadImage(string imagePath)
        {
            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                try
                {
                    pictureBox2.Image = Image.FromFile(imagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể tải hình ảnh: " + ex.Message);
                    pictureBox2.Image = null; 
                }
            }  
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
