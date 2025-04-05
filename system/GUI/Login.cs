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
            Menu menu = new Menu();
            MessageBox.Show("Đăng nhập thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }
    }
}
