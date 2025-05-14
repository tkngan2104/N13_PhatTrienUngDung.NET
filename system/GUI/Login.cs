using BUS;
using ET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class Login: Form
    {
        public Login()
        {
            InitializeComponent();
            pnlLogin.BackColor = Color.FromArgb(90, pnlLogin.BackColor);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            lblUser.Parent = pnlLogin;
            lblUser.BackColor = Color.Transparent;
            lblPassword.Parent = pnlLogin;
            lblPassword.BackColor = Color.Transparent;
        }

        /// <summary>
        /// Btn thoát chương trình.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Hãy chắc chắn rằng bạn muốn thoát ứng dụng !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Btn đăng nhập chương trình.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn thực hiện đăng nhập không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                if (BUS_TaiKhoan.Instance.KiemTraNhanVienCoThongTinKhong(txtUser.Text.ToUpper()) == false)
                {
                    MessageBox.Show("Nhân viên không có trong danh sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (BUS_TaiKhoan.Instance.KiemTraNhapMKDungSai(txtUser.Text.ToUpper(), txtPass.Text.ToUpper()) == false)
                    {
                        MessageBox.Show("Bạn đã nhập sai mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string tenTaiKhoan = txtUser.Text.ToUpper();
                        CurrentUser.EmployeeId = txtUser.Text.ToUpper();
                        CurrentUser.UserName = BUS_TaiKhoan.Instance.LayTenNVNhoTK(txtUser.Text.ToUpper());
                        MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Menu formMenu = new Menu(tenTaiKhoan);
                        this.Hide();
                        formMenu.ShowDialog();
                        this.Close();
                    }
                }
            }

            //Menu menu = new Menu();
            //MessageBox.Show("Đăng nhập thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //this.Hide();
            //menu.ShowDialog();
            //this.Close();
        }
    }
}
