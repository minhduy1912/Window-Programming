using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThaoTacSo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt_kt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tb_songuyen_TextChanged(object sender, EventArgs e)
        {
            Control ctrSonguyen = (Control)sender;
            if (ctrSonguyen.Text.Length > 0)
                if (!char.IsDigit(ctrSonguyen.Text[ctrSonguyen.Text.Length - 1]))
                    this.erp_songuyen.SetError(ctrSonguyen, "Vui lòng nhập số nguyên");
                else
                    this.erp_songuyen.Clear();
        }

        private void bt_capnhap_Click(object sender, EventArgs e)
        {
            lst_ketqua.Items.Add(tb_songuyen.Text);
            tb_songuyen.Text = "";
            tb_songuyen.Focus();
        }

        private void bt_tpt_Click(object sender, EventArgs e)
        {
            int n = lst_ketqua.Items.Count; //Số mục trong lst
            for (int i = 0; i < n; i++)
            {

                int tam = int.Parse(lst_ketqua.Items[i].ToString()) + 2; lst_ketqua.Items.RemoveAt(i); lst_ketqua.Items.Insert(i, tam.ToString());
            }
        }

        private void bt_csdc_Click(object sender, EventArgs e)
        {
            int n = lst_ketqua.Items.Count; //Số mục trong lst
            for (int i = 0; i < n - 1; i++)
            {
                if (int.Parse(lst_ketqua.Items[i].ToString()) % 2 == 0)
                {

                    string s = lst_ketqua.Items[i].ToString();//Lay gia tri muc gia tri chan
                                                              lst_ketqua.SelectedItem = s;//Chon muc co gia tri chan

                    break; //Thuc hien duoc so chn dau thi ket thuc vong lap
                }
            }
        }

        private void bt_cslc_Click(object sender, EventArgs e)
        {
            int n = lst_ketqua.Items.Count; //Số mục trong lst
            for (int i = n - 1; i >= 0; i--)
            {
                if (int.Parse(lst_ketqua.Items[i].ToString()) % 2 == 1)
                {

                    string s = lst_ketqua.Items[i].ToString();//Lay gia tri muc gia tri lẻ lstKetqua.SelectedItem = s;//Chon muc co gia tri le

                    break; //Thuc hien duoc so le dau (tu duoi len) thi ket thuc vong lap
                }
            }
        }

        private void bt_xptdc_Click(object sender, EventArgs e)
        {
            int n = lst_ketqua.SelectedItems.Count; //Số mục dang duoc chon trong lstKetqua
                                                    for (int i = n-1; i >= 0; i--)

            lst_ketqua.Items.Remove(lst_ketqua.SelectedItems[i].ToString());

        }

        private void bt_xptd_Click(object sender, EventArgs e)
        {
            lst_ketqua.Items.Remove(lst_ketqua.Items[0].ToString());
        }

        private void bt_xptc_Click(object sender, EventArgs e)
        {
            int n = lst_ketqua.Items.Count; lst_ketqua.Items.Remove(lst_ketqua.Items[n - 1].ToString());
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
