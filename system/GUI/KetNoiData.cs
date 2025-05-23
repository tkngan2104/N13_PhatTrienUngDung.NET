using System;
using DAL;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using BUS;

namespace GUI
{
    public partial class KetNoiData: Form
    {
        public KetNoiData()
        {
            InitializeComponent();
        }

        Connection_BUS busData = new Connection_BUS();

        private void LoadConnectionInfo()
        {
            // Đọc thông tin từ app.config
            var settings = ConfigurationManager.AppSettings;

            if (settings["ServerName"] != null)
            {
                txtName.Text = settings["ServerName"];
            }

            if (settings["DatabaseName"] != null)
            {
                cboDatabase.Text = settings["DatabaseName"];
            }
        }

        private void SaveConnectionInfo(string serverName, string databaseName)
        {
            // Lưu thông tin kết nối vào app.config
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = config.AppSettings.Settings;

            if (settings["ServerName"] == null)
            {
                settings.Add("ServerName", serverName);
            }
            else
            {
                settings["ServerName"].Value = serverName;
            }

            if (settings["DatabaseName"] == null)
            {
                settings.Add("DatabaseName", databaseName);
            }
            else
            {
                settings["DatabaseName"].Value = databaseName;
            }

            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sql = "Data Source=" + txtName.Text + ";Initial Catalog=" + cboDatabase.Text + ";Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            if (cboDatabase.Text != "" && txtName.Text != "")
            {
                try
                {
                    var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                    connectionStringsSection.ConnectionStrings["GUI.Properties.Settings.DbQuanLyResortConnectionString"].ConnectionString = sql;
                    config.Save();
                    ConfigurationManager.RefreshSection("connectionStrings");
                    using (SqlConnection conn = new SqlConnection(sql))
                    {
                        try
                        {
                            conn.Open();


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Có lỗi xảy ra khi cố gắng mở kết nối: " + ex.Message);
                        }
                    }
                    SaveConnectionInfo(txtName.Text, cboDatabase.Text);
                    busData.setSeverName(txtName.Text);
                    busData.setdataName(cboDatabase.Text);
                    if (busData.ktDuongDan(txtName.Text, cboDatabase.Text))
                    {
                        busData.setDataBase();
                        Login menu = new Login();
                        MessageBox.Show("Kết nối thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        menu.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Tên sever không đúng hoặc database không tồn tại!");
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Xảy ra lỗi: " + ex.Message + "Lỗi kết nối database!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void KetNoiData_Load(object sender, EventArgs e)
        {
            LoadConnectionInfo();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            // Xác định chuỗi kết nối đến máy chủ
            string serverName = txtName.Text; // Lấy tên máy chủ từ textbox
            string connectionString = $"Data Source={serverName};Integrated Security=True;";

            // Tạo kết nối tới máy chủ
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Mở kết nối
                    connection.Open();

                    // Tạo và thực thi truy vấn để lấy danh sách cơ sở dữ liệu
                    string query = "SELECT name FROM sys.databases WHERE database_id > 4"; // Lấy danh sách cơ sở dữ liệu không phải là các hệ thống
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    // Tạo danh sách để lưu trữ tên cơ sở dữ liệu
                    List<string> databases = new List<string>();

                    // Đọc từng dòng dữ liệu và thêm tên cơ sở dữ liệu vào danh sách
                    while (reader.Read())
                    {
                        string dbName = reader["name"].ToString();
                        databases.Add(dbName);
                    }

                    // Gán danh sách cơ sở dữ liệu vào combobox
                    cboDatabase.DataSource = databases;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi lấy danh sách cơ sở dữ liệu: " + ex.Message);
                }
            }
        }
    }
}
