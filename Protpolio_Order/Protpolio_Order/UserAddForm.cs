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
using System.Windows.Forms.Design;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Protpolio_Order
{
    public partial class UserAddForm : Form
    {

        string connStr;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;

        public UserAddForm()
        {
            InitializeComponent();
        }

        private void useradd_btn_Click(object sender, EventArgs e)
        {
            connStr = "Server = localhost\\SQLEXPRESS;database = PostManagement;Trusted_Connection = True;";
            conn = new SqlConnection(connStr);
            conn.Open();

            cmd = new SqlCommand();
            cmd.Connection = conn;

            string data1, data2, data3, sql;
            int? data5 = null;

            data1 = tb_id.Text.Trim();//양쪽 공백 제거
            data2 = tb_pw.Text.Trim();
            data3 = tb_num.Text;
            
            


            
            if(string.IsNullOrWhiteSpace(data1) || data1.Contains(" "))//아이디에 조건을 걸때는 and보단 or가 유용하다
                                                                       //예를들어 if(data1 = "") && (data1 = " ") return;
                                                                       //이렇게 하면 빈문자열 이면서 공백이 있는 이상한 아이디만 return된다
            {
                MessageBox.Show("아이디에 공백을 제거해주세요.", "POST");
                return;
            }
            else if(string.IsNullOrWhiteSpace(data2) || data2.Contains(" "))
            {
                MessageBox.Show("비밀번호에 공백을 제거해주세요.", "POST");
                return;
            }
            else
            {
                string checksql = "SELECT COUNT(*) FROM 사용자 WHERE 이름 = @inputId";
                using (SqlCommand cmd = new SqlCommand(checksql, conn))
                {
                    cmd.Parameters.AddWithValue("@inputId", data1);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("이미 사용중인 ID입니다.", "POST");
                        return;
                    }
                    
                }

                sql = "INSERT INTO 사용자 VALUES('" + data1 + "','" + data2 + "','" + data3 + "',null,'"+ data5 +"')";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                MessageBox.Show("회원가입이 완료되었습니다.", "POST");
                this.Close();
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sameid_btn_Click(object sender, EventArgs e)
        {
            string inputId = tb_id.Text;

            connStr = "Server=localhost\\SQLEXPRESS;Database=PostManagement;Trusted_Connection=True;";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string sql = "SELECT COUNT(*) FROM 사용자 WHERE 이름 = @inputId";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@inputId", inputId);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("중복된 ID가 존재합니다.", "POST");
                    }
                    else
                    {
                        MessageBox.Show("사용가능한 ID 입니다.", "POST");
                    }
                }
            }

        }

        private int currentImageIndex = 1;

        private void hidepw_pb_Click(object sender, EventArgs e)
        {
            List<string> imageNames = new List<string>()
            {
                "hide2",
                "hide"
            };

            if (imageNames.Count > 0)
            {
                string imageName = imageNames[currentImageIndex];
                hidepw_pb.Image = (Image)Properties.Resources.ResourceManager.GetObject(imageName);

                currentImageIndex = (currentImageIndex + 1) % imageNames.Count; // 다음 이미지 인덱스 계산
                tb_pw.PasswordChar = (currentImageIndex % 2 == 0) ? '\0' : '*';
            }
            else
            {
                MessageBox.Show("이미지 파일을 찾을 수 없습니다.", "POST");
            }
        }

        private void p_ua_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
