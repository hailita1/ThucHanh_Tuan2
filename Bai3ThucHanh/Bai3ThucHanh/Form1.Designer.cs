namespace Bai3ThucHanh
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DanhSachMatHang = new System.Windows.Forms.ListBox();
            this.lstHangDatMua = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbTheTinDung = new System.Windows.Forms.RadioButton();
            this.rdbSec = new System.Windows.Forms.RadioButton();
            this.rdbTienMat = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chbMail = new System.Windows.Forms.CheckBox();
            this.chbFax = new System.Windows.Forms.CheckBox();
            this.chbDienThoai = new System.Windows.Forms.CheckBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.btnDongY = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Danh sách các mặt hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hàng đặt mua";
            // 
            // DanhSachMatHang
            // 
            this.DanhSachMatHang.FormattingEnabled = true;
            this.DanhSachMatHang.Location = new System.Drawing.Point(15, 77);
            this.DanhSachMatHang.Name = "DanhSachMatHang";
            this.DanhSachMatHang.Size = new System.Drawing.Size(344, 173);
            this.DanhSachMatHang.TabIndex = 4;
            this.DanhSachMatHang.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DanhSachMatHang_MouseDoubleClick);
            // 
            // lstHangDatMua
            // 
            this.lstHangDatMua.FormattingEnabled = true;
            this.lstHangDatMua.Location = new System.Drawing.Point(380, 77);
            this.lstHangDatMua.Name = "lstHangDatMua";
            this.lstHangDatMua.Size = new System.Drawing.Size(349, 173);
            this.lstHangDatMua.TabIndex = 5;
            this.lstHangDatMua.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LstHangDatMua_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbTheTinDung);
            this.groupBox1.Controls.Add(this.rdbSec);
            this.groupBox1.Controls.Add(this.rdbTienMat);
            this.groupBox1.Location = new System.Drawing.Point(85, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phương thức thanh toán";
            // 
            // rdbTheTinDung
            // 
            this.rdbTheTinDung.AutoSize = true;
            this.rdbTheTinDung.Location = new System.Drawing.Point(23, 65);
            this.rdbTheTinDung.Name = "rdbTheTinDung";
            this.rdbTheTinDung.Size = new System.Drawing.Size(87, 17);
            this.rdbTheTinDung.TabIndex = 2;
            this.rdbTheTinDung.TabStop = true;
            this.rdbTheTinDung.Text = "Thẻ tín dụng";
            this.rdbTheTinDung.UseVisualStyleBackColor = true;
            // 
            // rdbSec
            // 
            this.rdbSec.AutoSize = true;
            this.rdbSec.Location = new System.Drawing.Point(23, 42);
            this.rdbSec.Name = "rdbSec";
            this.rdbSec.Size = new System.Drawing.Size(44, 17);
            this.rdbSec.TabIndex = 1;
            this.rdbSec.TabStop = true;
            this.rdbSec.Text = "Séc";
            this.rdbSec.UseVisualStyleBackColor = true;
            // 
            // rdbTienMat
            // 
            this.rdbTienMat.AutoSize = true;
            this.rdbTienMat.Location = new System.Drawing.Point(23, 19);
            this.rdbTienMat.Name = "rdbTienMat";
            this.rdbTienMat.Size = new System.Drawing.Size(67, 17);
            this.rdbTienMat.TabIndex = 0;
            this.rdbTienMat.TabStop = true;
            this.rdbTienMat.Text = "Tiền Mặt";
            this.rdbTienMat.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chbMail);
            this.groupBox2.Controls.Add(this.chbFax);
            this.groupBox2.Controls.Add(this.chbDienThoai);
            this.groupBox2.Location = new System.Drawing.Point(453, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hình thức liên lạc";
            // 
            // chbMail
            // 
            this.chbMail.AutoSize = true;
            this.chbMail.Location = new System.Drawing.Point(27, 65);
            this.chbMail.Name = "chbMail";
            this.chbMail.Size = new System.Drawing.Size(45, 17);
            this.chbMail.TabIndex = 2;
            this.chbMail.Text = "Mail";
            this.chbMail.UseVisualStyleBackColor = true;
            // 
            // chbFax
            // 
            this.chbFax.AutoSize = true;
            this.chbFax.Location = new System.Drawing.Point(27, 42);
            this.chbFax.Name = "chbFax";
            this.chbFax.Size = new System.Drawing.Size(43, 17);
            this.chbFax.TabIndex = 1;
            this.chbFax.Text = "Fax";
            this.chbFax.UseVisualStyleBackColor = true;
            // 
            // chbDienThoai
            // 
            this.chbDienThoai.AutoSize = true;
            this.chbDienThoai.Location = new System.Drawing.Point(27, 19);
            this.chbDienThoai.Name = "chbDienThoai";
            this.chbDienThoai.Size = new System.Drawing.Size(74, 17);
            this.chbDienThoai.TabIndex = 0;
            this.chbDienThoai.Text = "Điện thoại";
            this.chbDienThoai.UseVisualStyleBackColor = true;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(118, 5);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(167, 20);
            this.txtHoTen.TabIndex = 8;
            this.txtHoTen.TextChanged += new System.EventHandler(this.TxtHoTen_TextChanged);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(453, 6);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(200, 20);
            this.txtDiaChi.TabIndex = 9;
            // 
            // btnDongY
            // 
            this.btnDongY.Location = new System.Drawing.Point(284, 362);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(75, 23);
            this.btnDongY.TabIndex = 10;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.BtnDongY_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(380, 362);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            this.btnThoat.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BtnThoat_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 397);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstHangDatMua);
            this.Controls.Add(this.DanhSachMatHang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bán sách qua mạng";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox DanhSachMatHang;
        private System.Windows.Forms.ListBox lstHangDatMua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbTheTinDung;
        private System.Windows.Forms.RadioButton rdbSec;
        private System.Windows.Forms.RadioButton rdbTienMat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chbMail;
        private System.Windows.Forms.CheckBox chbFax;
        private System.Windows.Forms.CheckBox chbDienThoai;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.Button btnThoat;
    }
}

