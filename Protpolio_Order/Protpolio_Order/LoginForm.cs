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
    public partial class LoginForm : Form
    {
        string connStr;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("프로그램을 종료합니다","POST");
            this.Close();
        }

        private void ua_btn_Click(object sender, EventArgs e)
        {
            UserAddForm subfrom = new UserAddForm();//버튼을 클릭하면 회원추가 폼과 연결후 실행
            subfrom.ShowDialog();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string inputId = tb_id.Text;//이건 그냥 inputId를 문자열로 만들고 tb_id의 값을 넘긴것
            string inputPw = tb_pw.Text;

            connStr = "Server=localhost\\SQLEXPRESS;Database=PostManagement;Trusted_Connection=True;";//서버연결
            using (SqlConnection conn = new SqlConnection(connStr)) //Sqlconnection은 DB연결을 관리하는 클래스로 conn은 그냥 변수
                                                                    //connStr은위에서 정의한 문자열
                                                                    //using을 사용하는 이유는 conn.open을 할때마다conn.close를 해줘야하기 때문
                                                                    //그리고 리소스 정리가 가능해 코드가독성,자동 정리,예외 처리같은 장점이 있다
            {
                conn.Open();//DB연결 메서드

                string sql = "SELECT COUNT(*) FROM 사용자 WHERE 이름 = @inputId AND 비밀번호 = @inputPw";
                string sql2 = "SELECT 권한 FROM 사용자 WHERE 이름 = @inputId AND 비밀번호 = @inputPw";//root윈폼으로 들어가기 위한 권한을 가진 정보
                //위에는 SQL언어를 C#에서 DB로 전송하는것인데
                //처음엔 아이디 중복인증 기능을 끌고와 내 나름 방식대로 아래에 비밀번호 문장도 추가하고 using안에 using을 써서
                //비밀번호 중복도 해서 로그인 기능을 구현하려 했으나 1번사용자의 ID와 2번사용자의 비밀번호를 입력해도 로그인이 되서 코드를 바꿈
                //이래서 사람은 생각을 오래해야함

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@inputId", inputId);//위에 sql언어를 쓸때 ex)where 이름 = '김상우'
                    cmd.Parameters.AddWithValue("@inputPw", inputPw);//저기에서 김상우에 들어갈 매개변수값을 전달하는 문장
                    int uip = (int)cmd.ExecuteScalar();//오브젝트값을 int로 받고 그 값을 아래 if문으로 활용

                    using (SqlCommand cmd2 = new SqlCommand(sql2, conn))
                    {
                        cmd2.Parameters.AddWithValue("@inputId", inputId);
                        cmd2.Parameters.AddWithValue("@inputPw", inputPw);
                        int mode = (int)cmd2.ExecuteScalar();

                        if (mode > 0)
                        {
                            MessageBox.Show("" + inputId + "님 환영합니다.", "POST");//root윈폼을 처음에 써야 검사하고 아닌것들은 else if로 걸러내는 식
                            RootForm rootform = new RootForm(inputId,inputPw);
                            rootform.ShowDialog();
                        }
                        else if (uip > 0)
                        {
                            MessageBox.Show("" + inputId + "님 환영합니다.", "POST");
                            UserForm userform = new UserForm(inputId,inputPw);//버튼을 클릭하면 회원 폼과 연결후 실행
                            userform.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("아이디나 비밀번호가 일치하지 않습니다.", "POST");
                            return;
                        }
                    } 
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
