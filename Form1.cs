using Nhom14;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Phan1_QuanLyNhanVien
{
    public partial class Form1 : Form
    {
        private List<NhanVien> danhSachNhanVien = new List<NhanVien>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Đọc file dulieu.txt
                string[] lines = File.ReadAllLines("dulieu.txt");
                foreach (string line in lines)
                {
                    string[] parts = line.Split(';');
                    if (parts.Length == 4)
                    {
                        NhanVien nv = new NhanVien(parts[0], parts[1], parts[2], parts[3]);
                        danhSachNhanVien.Add(nv);
                    }
                }

                // Hiển thị lên DataGridView
                dataGridViewNhanVien.DataSource = danhSachNhanVien;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đọc file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewNhanVien.SelectedRows.Count > 0)
            {
                NhanVien nv = dataGridViewNhanVien.SelectedRows[0].DataBoundItem as NhanVien;
                txtMaSo.Text = nv.MaSo;
                txtHoTen.Text = nv.HoTen;
                txtNgaySinh.Text = nv.NgaySinh;
                txtEmail.Text = nv.Email;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Text = "Hủy";
            btnLuu.Enabled = true;
            // Xóa nội dung TextBox để nhập mới
            txtMaSo.Clear();
            txtHoTen.Clear();
            txtNgaySinh.Clear();
            txtEmail.Clear();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập
            if (string.IsNullOrWhiteSpace(txtMaSo.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text) ||
                string.IsNullOrWhiteSpace(txtNgaySinh.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Thêm nhân viên mới
            NhanVien nv = new NhanVien(txtMaSo.Text, txtHoTen.Text, txtNgaySinh.Text, txtEmail.Text);
            danhSachNhanVien.Add(nv);

            // Làm mới DataGridView
            dataGridViewNhanVien.DataSource = null;
            dataGridViewNhanVien.DataSource = danhSachNhanVien;

            // Quay lại trạng thái ban đầu
            btnThem.Text = "Thêm";
            btnLuu.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                List<string> lines = new List<string>();
                foreach (NhanVien nv in danhSachNhanVien)
                {
                    lines.Add($"{nv.MaSo};{nv.HoTen};{nv.NgaySinh};{nv.Email}");
                }
                File.WriteAllLines("dulieu.txt", lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}