using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTPM_53_Trieu
{
    public partial class FormUnitTest_53_Trieu : Form
    {
        public FormUnitTest_53_Trieu()
        {
            InitializeComponent();
        }

        private void btnKiemTra_53_Trieu_Click(object sender, EventArgs e)
        {
            string a_53_Trieu, b_53_Trieu, c_53_Trieu, d_53_Trieu, KetQua_53Trieu;
            a_53_Trieu = string.Format(txtTu1_53_Trieu.Text);
            b_53_Trieu = string.Format(txtTu2_53_Trieu.Text);
            c_53_Trieu = string.Format(txtTu3_53_Trieu.Text);
            d_53_Trieu =  string.Format(txtTu4_53_Trieu.Text);
            prefix_53_Trieu pre_53_Trieu = new prefix_53_Trieu(a_53_Trieu, b_53_Trieu, c_53_Trieu, d_53_Trieu);
            KetQua_53Trieu = pre_53_Trieu.LongestCommonPrefix_53_Trieu();
            txtKetQua_53_Trieu.Text = KetQua_53Trieu.ToString();

        }

    }
}
