using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            try {
                if(txtHoTen.Text.Length.Equals(0))
                {
                    throw new Exception("Họ tên không được để rỗng");
                }
                string hoten=txtHoTen.Text;
                string masv=mtxtMaSV.Text;
                string ngaysinh=mtxtNgaySinh.Text;
                string gioitinh = (rbNam.Checked) ? "Nam" : "Nữ";
                string sothich = null;
                if (chBoxDuLich.Checked)
                {
                    sothich += "Du lịch,";
                }
                if (chBoxThethao.Checked)
                {
                    sothich += "Thể thao,";
                }
                if (chBoxMuaSam.Checked)
                {
                    sothich += "Mua sắm ";
                }
                txtKetQua.Text += masv + ", Họ tên:" + hoten + ", Ngày sinh: " + ngaysinh + ", giới tinh: " + gioitinh +" "+ sothich + "\r\n";
                _=masv+1;
            }
            catch(Exception ex)
            {
                txtKetQua.Text = ex.Message;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtKetQua.Text = "";

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
