using QuanLyBanVeMayBay.BLL;
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
    }
}
