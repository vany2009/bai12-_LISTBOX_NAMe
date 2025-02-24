using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai12__LISTBOX_NAMe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            lstNames.Items.Add(txtName.Text);
            txtName.Text = "";
            txtName.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstNames.SelectedIndex < 0)
            {
                MessageBox.Show(" Hãy Chọn Tên Trong Danh Sách", " Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lstNames.Items[lstNames.SelectedIndex] = txtName.Text;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstNames.Items.Add(" Ấn Vào Đây ");
            lstNames.Items.Add(" Ấn Vào Đây ");
            lstNames.Items.Add(" Ấn Vào Đây ");

        }

        private void lstName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstNames.SelectedIndex < 0)
            {
                return;
            }
            txtName.Text = lstNames.Items[lstNames.SelectedIndex].ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstNames.SelectedIndex < 0) ;
            {
                lstNames.Items.RemoveAt(lstNames.SelectedIndex);
            }
        }

        private void btnInSert_Click(object sender, EventArgs e)
        {
            lstNames.Items.Insert(Convert.ToInt32(btninsert.Text), txtName.Text);
        }
    }
}
        
    

