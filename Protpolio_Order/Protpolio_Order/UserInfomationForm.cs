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

namespace Protpolio_Order
{
    public partial class UserInfomationForm : Form
    {
        public UserInfomationForm(string id,string pw)
        {
            InitializeComponent();
            loadid = id;
            loadpw = pw;
        }
        string loadid;
        string loadpw;
        string connStr;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;
        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserInfomationForm_Load(object sender, EventArgs e)
        {
            connStr = "Server = localhost\\SQLEXPRESS;Database = PostManagement;Trusted_Connection = True;";
            using (conn = new SqlConnection(connStr))
            {
                conn.Open();

                cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "SELECT * FROM 사용자 WHERE 이름 = @LoadID";
                cmd.Parameters.AddWithValue("@LoadID", loadid);
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string data1, data2, data3, data4;
                    data1 = reader.GetString(0).Trim();
                    data2 = reader.GetString(1).Trim();
                    data3 = reader.GetString(2).Trim();
                    data4 = reader.GetString(3).Trim();

                    id_tb.Text = data1;
                    pw_tb.Text = data2;
                    num_tb.Text = data3;
                    add_tb.Text = data4;
                }

                reader.Close();
            }
        }

        private void change_btn_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connStr))
            {
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;

                string data1, data2, data3, data4, sql;

                data1 = id_tb.Text;
                data2 = pw_tb.Text;
                data3 = num_tb.Text;
                data4 = add_tb.Text;

                sql = "UPDATE 사용자 SET 비밀번호 = @Data2, 전화번호 = @Data3, 거주지 = @Data4 WHERE 이름 = @Data1";
                cmd.CommandText = sql;
                cmd.Parameters.Clear();
                if (string.IsNullOrEmpty(data4))
                {
                    cmd.Parameters.AddWithValue("@Data4", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Data4", data4);
                }
                cmd.Parameters.AddWithValue("@Data1", data1);
                cmd.Parameters.AddWithValue("@Data2", data2);
                cmd.Parameters.AddWithValue("@Data3", data3);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("변경되었습니다", "POST");
            this.Close();
        }
    }
}
