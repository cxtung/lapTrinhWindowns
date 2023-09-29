using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai04_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listviewDSDuocChon.Items.Add("cao tung");
            listviewDSDuocChon.Items.Add("cao tung A");
            listviewDSDuocChon.Items.Add("cao tung B");
            listviewDSDuocChon.Items.Add("cao tung C");
            cbKhoa.SelectedIndex = 0;
        }
        private void BtnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtHoTen.Text.Equals(0))
                {
                    throw new Exception("Họ tên chưa nhập.");
                }
                string hoten =txtHoTen.Text;
                listThongTIn.Items.Add(hoten);
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void themAll_Click(object sender, EventArgs e)
        {
            int count = listThongTIn.Items.Count;
            for (int vt=0;vt<count;vt++)
            {
                string khoa = cbKhoa.SelectedItem.ToString();
                string hoten= listThongTIn.Items[vt].ToString();
                ListViewItem item=new ListViewItem(hoten);
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = khoa });
                listviewDSDuocChon.Items.Add(item);
            }
            listThongTIn.Items.Clear();
        }

        private void Them1_Click(object sender, EventArgs e)
        {

                string hoten = listThongTIn.SelectedItem.ToString();
                string khoa=cbKhoa.SelectedItem.ToString();
                ListViewItem item = new ListViewItem(hoten);
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = khoa });
                listviewDSDuocChon.Items.Add(item);
                listThongTIn.Items.RemoveAt(listThongTIn.SelectedIndex);
                
            
        }

        private void delete1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listviewDSDuocChon.Items)
            {
                if (item.Selected)
                {
                    listviewDSDuocChon.Items.Remove(item);
                    listThongTIn.Items.Add(item.Text);
                }
            }
        }

        private void deleteAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listviewDSDuocChon.Items)
            {
                    listviewDSDuocChon.Items.Remove(item);
                    listThongTIn.Items.Add(item.Text);
                
            }
        }
    }
}
