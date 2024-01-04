using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Protpolio_Order
{
    public partial class UserForm : Form
    {
        public UserForm(string id, string pw)
        {
            InitializeComponent();
            loadid = id;
            loadpw = pw;
        }

        string loadid;
        string loadpw;
        string connStr = "Server = localhost\\SQLEXPRESS;Database = PostManagement;Trusted_Connection = True;";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;

        private void UserForm_Load(object sender, EventArgs e)
        {
            id_lb.Text = loadid;
            id_lb.FlatStyle = FlatStyle.System;

            conn = new SqlConnection(connStr);
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "SELECT * FROM 사용자 WHERE 이름 = @LoadID";
                cmd.Parameters.AddWithValue("@LoadID", loadid);
                reader = cmd.ExecuteReader();
                reader.Close();
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void apple_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                // 거주지 정보 확인 쿼리
                cmd.CommandText = "SELECT COUNT(*) FROM 사용자 WHERE 거주지 IS NOT NULL AND 이름 = @LoadID";
                cmd.Parameters.AddWithValue("@LoadID", loadid);
                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    // 사용자 정보 가져오기
                    cmd.CommandText = "SELECT * FROM 사용자 WHERE 이름 = @LoadID";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@LoadID", loadid);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string userName = reader["이름"].ToString();
                        string userPass = reader["비밀번호"].ToString();
                        string userAddress = reader["거주지"].ToString();


                        reader.Close();
                        cmd.Parameters.AddWithValue("@ProductNum", 180041);
                        cmd.CommandText = "SELECT 남은갯수 FROM 상품 WHERE 상품번호 = @ProductNum";
                        int remainingQuantity = (int)cmd.ExecuteScalar();

                        if (remainingQuantity <= 0)
                        {
                            MessageBox.Show("재고가 없습니다.", "POST");
                            return;
                        }

                        // INSERT 문 완성
                        cmd.CommandText = "INSERT INTO 주문내역 (주문자이름, 주문자비밀번호, 상품명, 상품번호, 거주지) VALUES (@UserName, @UserPW, @ProductName, @ProductNum, @Address)";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@UserName", loadid);
                        cmd.Parameters.AddWithValue("@UserPW", loadpw);
                        cmd.Parameters.AddWithValue("@ProductName", "사과");
                        cmd.Parameters.AddWithValue("@ProductNum", 180041);
                        cmd.Parameters.AddWithValue("@Address", userAddress);
                        cmd.ExecuteNonQuery();

                    }
                    
                }
                else
                {
                    // 거주지 정보가 없는 경우 회원 정보 수정 폼 열기
                    MessageBox.Show("거주지를 입력해주세요.", "POST");
                    UserInfomationForm Subfrom = new UserInfomationForm(loadid, loadpw);
                    Subfrom.ShowDialog();
                    return;
                }
                // 거주지 정보가 있는 경우 주문 완료
                MessageBox.Show("주문이 완료되었습니다.", "POST");
            }
        }
        private void id_lb_Click(object sender, EventArgs e)
        {
            try
            {
                UserInfomationForm subFrom = new UserInfomationForm(loadid, loadpw);
                subFrom.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void banana_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                // 거주지 정보 확인 쿼리
                cmd.CommandText = "SELECT COUNT(*) FROM 사용자 WHERE 거주지 IS NOT NULL AND 이름 = @LoadID";
                cmd.Parameters.AddWithValue("@LoadID", loadid);
                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {


                    // 사용자 정보 가져오기
                    cmd.CommandText = "SELECT * FROM 사용자 WHERE 이름 = @LoadID";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@LoadID", loadid);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string userName = reader["이름"].ToString();
                        string userPass = reader["비밀번호"].ToString();
                        string userAddress = reader["거주지"].ToString();


                        reader.Close();

                        cmd.Parameters.AddWithValue("@ProductNum", 180042);
                        cmd.CommandText = "SELECT 남은갯수 FROM 상품 WHERE 상품번호 = @ProductNum";
                        int remainingQuantity = (int)cmd.ExecuteScalar();
                        if (remainingQuantity <= 0)
                        {
                            MessageBox.Show("재고가 없습니다.", "POST");
                            return;
                        }

                        // INSERT 문 완성
                        cmd.CommandText = "INSERT INTO 주문내역 (주문자이름, 주문자비밀번호, 상품명, 상품번호, 거주지) VALUES (@UserName, @UserPW, @ProductName, @ProductNum, @Address)";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@UserName", loadid);
                        cmd.Parameters.AddWithValue("@UserPW", loadpw);
                        cmd.Parameters.AddWithValue("@ProductName", "바나나");
                        cmd.Parameters.AddWithValue("@ProductNum", 180042);
                        cmd.Parameters.AddWithValue("@Address", userAddress);
                        cmd.ExecuteNonQuery();



                    }
                    else
                    {
                        reader.Close();
                        // 사용자 정보를 찾을 수 없는 경우에 대한 처리
                        MessageBox.Show("사용자 정보를 찾을 수 없습니다.", "POST");
                    }
                }
                else
                {
                    // 거주지 정보가 없는 경우 회원 정보 수정 폼 열기
                    MessageBox.Show("거주지를 입력해주세요.", "POST");
                    UserInfomationForm Subfrom = new UserInfomationForm(loadid, loadpw);
                    Subfrom.ShowDialog();
                }
                // 거주지 정보가 있는 경우 주문 완료
                MessageBox.Show("주문이 완료되었습니다.", "POST");
            }
        }

        private void kiwi_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                // 거주지 정보 확인 쿼리
                cmd.CommandText = "SELECT COUNT(*) FROM 사용자 WHERE 거주지 IS NOT NULL AND 이름 = @LoadID";
                cmd.Parameters.AddWithValue("@LoadID", loadid);
                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {


                    // 사용자 정보 가져오기
                    cmd.CommandText = "SELECT * FROM 사용자 WHERE 이름 = @LoadID";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@LoadID", loadid);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string userName = reader["이름"].ToString();
                        string userPass = reader["비밀번호"].ToString();
                        string userAddress = reader["거주지"].ToString();


                        reader.Close();

                        cmd.Parameters.AddWithValue("@ProductNum", 180043);
                        cmd.CommandText = "SELECT 남은갯수 FROM 상품 WHERE 상품번호 = @ProductNum";
                        int remainingQuantity = (int)cmd.ExecuteScalar();

                        if (remainingQuantity <= 0)
                        {
                            MessageBox.Show("재고가 없습니다.", "POST");
                            return;
                        }

                        // INSERT 문 완성
                        cmd.CommandText = "INSERT INTO 주문내역 (주문자이름, 주문자비밀번호, 상품명, 상품번호, 거주지) VALUES (@UserName, @UserPW, @ProductName, @ProductNum, @Address)";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@UserName", loadid);
                        cmd.Parameters.AddWithValue("@UserPW", loadpw);
                        cmd.Parameters.AddWithValue("@ProductName", "키위");
                        cmd.Parameters.AddWithValue("@ProductNum", 180043);
                        cmd.Parameters.AddWithValue("@Address", userAddress);
                        cmd.ExecuteNonQuery();

                    }
                    else
                    {
                        reader.Close();
                        // 사용자 정보를 찾을 수 없는 경우에 대한 처리
                        MessageBox.Show("사용자 정보를 찾을 수 없습니다.", "POST");
                    }
                }
                else
                {
                    // 거주지 정보가 없는 경우 회원 정보 수정 폼 열기
                    MessageBox.Show("거주지를 입력해주세요.", "POST");
                    UserInfomationForm Subfrom = new UserInfomationForm(loadid, loadpw);
                    Subfrom.ShowDialog();
                }
                // 거주지 정보가 있는 경우 주문 완료
                MessageBox.Show("주문이 완료되었습니다.", "POST");
            }
        }

        private void ap_lb_Click(object sender, EventArgs e)
        {

        }
    }
}
