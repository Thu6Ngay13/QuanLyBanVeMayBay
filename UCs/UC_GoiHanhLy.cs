﻿using QuanLyBanVeMayBay.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanVeMayBay.UC
{
    public partial class UC_GoiHanhLy : UserControl
    {
        BLL_GoiHanhLy dbGoiHanhLy = new BLL_GoiHanhLy();

        public UC_GoiHanhLy()
        {
            InitializeComponent();
        }

        private void Btn_Chon_Click(object sender, EventArgs e)
        {
            string mave = "6";
            MuaGoiHanhLy(mave);
        }

        private void MuaGoiHanhLy(string mave)
        {
            try
            {
                DialogResult xacnhanmua = MessageBox.Show("Mỗi vé chỉ được mua 01 gói hành lý \n\nXác nhận mua/ thay đổi ?", "Mua gói hành lý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (xacnhanmua == DialogResult.Yes)
                {
                    dbGoiHanhLy.them_GoiHanhLy(Lbl_MaGoiHanhLy.Text, mave);
                    MessageBox.Show("Mua thành công");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi mua gói hành lý");
            }
        }
    }
}
