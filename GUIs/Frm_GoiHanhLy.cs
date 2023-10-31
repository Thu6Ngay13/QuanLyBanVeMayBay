using QuanLyBanVeMayBay.BLL;
using QuanLyBanVeMayBay.UC;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyBanVeMayBay.GUI
{
    public partial class Frm_GoiHanhLy : Form
    {
        BLL_GoiHanhLy GoiHanhLy = new BLL_GoiHanhLy();
        string error = "";
        public Frm_GoiHanhLy()
        {
            InitializeComponent();
        }

        private void Frm_GoiHanhLy_Load(object sender, System.EventArgs e)
        {
            Pnl_GoiHanhLy.Controls.Clear();
            DataSet ds = GoiHanhLy.LayGoiHanhLy();
            DataTable dt = ds.Tables[0];

            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                UC_GoiHanhLy goihanhly = new UC_GoiHanhLy();
                goihanhly.Lbl_MaGoiHanhLy.Text = dt.Rows[i]["MaGoi"].ToString();
                goihanhly.Lbl_KhoiLuongMuaThem.Text = dt.Rows[i]["KhoiLuongMuaThem"].ToString();
                goihanhly.Lbl_Gia.Text = dt.Rows[i]["GiaTien"].ToString();

                goihanhly.Location = new System.Drawing.Point(10, 40 * i + 3);

                this.Pnl_GoiHanhLy.Controls.Add(goihanhly);
            }

        }

        private void Btn_XoaGoiHanhLy_Click(object sender, System.EventArgs e)
        {
            try
            {
                DialogResult xacnhanmua = MessageBox.Show("Xác nhận xóa gói hành lý?", "Xóa gói hành lý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (xacnhanmua == DialogResult.Yes)
                {
                    GoiHanhLy.them_GoiHanhLy("NULL", "6");
                    MessageBox.Show("Xóa thành công");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi xóa gói hành lý");
            }
        }
    }
}
