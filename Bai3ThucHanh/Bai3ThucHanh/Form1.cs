using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3ThucHanh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void addData()
        {
            DanhSachMatHang.Items.Add("Kỹ thuật lập trình C#");
            DanhSachMatHang.Items.Add("Tự học Visual C# trong 21 ngày");
            DanhSachMatHang.Items.Add("Bài tập C#");
            DanhSachMatHang.Items.Add(".Net Toàn Tập-Tập 1");
            DanhSachMatHang.Items.Add(".Net Toàn Tập-Tập 2");
            DanhSachMatHang.Items.Add(".Net Toàn Tập-Tập 3");
            DanhSachMatHang.Items.Add(".Net Toàn Tập-Tập 4");
            DanhSachMatHang.Items.Add("Tin Học cơ bản");
            DanhSachMatHang.Items.Add("SQL Sever");
            DanhSachMatHang.Items.Add("Cơ bản về XML");
            DanhSachMatHang.Items.Add("Phân tích và thiết kế hệ thống");
            DanhSachMatHang.Items.Add("Sử dụng Word");
            DanhSachMatHang.Items.Add("Đến với Word 2003");
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addData();
            this.KeyPreview = true;
        }

        private void DanhSachMatHang_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string curItem = DanhSachMatHang.SelectedItem.ToString();
            int index = lstHangDatMua.FindString(curItem);
            if(index == -1)
            {
                lstHangDatMua.Items.Add(curItem);
            }
            else
            {
                MessageBox.Show("Hàng đặt mua đã có rồi");
            }

        }

        private void LstHangDatMua_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lstHangDatMua.SelectedIndex;
            if(MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== System.Windows.Forms.DialogResult.Yes)
            {
                lstHangDatMua.Items.RemoveAt(index);
            }
        }

        private string HinhThucLL()
        {
            string a = "";
            if(chbDienThoai.Checked == true)
            {
                a += "   " + chbDienThoai.Text;
            }
            if (chbMail.Checked == true)
            {
                a += "   " + chbMail.Text;
            }
            if (chbFax.Checked == true)
            {
                a += "   " + chbFax.Text;
            }
            return a;
        }
        private string ThanhToan()
        {
            string s = "";
            if(rdbTienMat.Checked == true)
            {
                s += rdbTienMat.Text;
            }
            if (rdbTheTinDung.Checked == true)
            {
                s += rdbTheTinDung.Text;
            }
            if (rdbSec.Checked == true)
            {
                s += rdbSec.Text;
            }
            return s;
        }

        private void BtnDongY_Click(object sender, EventArgs e)
        {
            if(txtHoTen.Text.Equals("") || txtDiaChi.Text.Equals("")||ThanhToan().Equals("")||HinhThucLL().Equals(""))
            {
                MessageBox.Show("Bạn cần nhập đủ thông tin!","Thông báo");
                txtHoTen.Focus();
            }
            else
            {
                string sb = "Họ và tên: ";
                sb += txtHoTen.Text + "\nĐịa chỉ: ";
                sb += txtDiaChi.Text + "\nDanh sách mua:\n\t";
                foreach(object item in lstHangDatMua.Items)
                {
                    sb += item.ToString();
                    sb += "\n\t";
                }
                MessageBox.Show(sb +"\nPhương Thức thanh toán: "+ ThanhToan() + "\nHình thức liên lạc: " + HinhThucLL(), "Thông báo");
            }
        }

        private void TxtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnThoat_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Alt)
            {
                if (e.KeyCode.Equals(Keys.M))
                {
                    BtnThoat_Click(null, null);
                }
            }
        }
    }
}
