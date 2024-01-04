using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Protpolio_Order
{
    public partial class RootForm : Form
    {
        public RootForm(string id, string pw)
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

        private void RootForm_Load(object sender, EventArgs e)
        {
            connStr = "Server=localhost\\SQLEXPRESS;Database=PostManagement;Trusted_Connection=True;";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "SELECT * FROM 주문내역";
                SqlDataReader reader = cmd.ExecuteReader();

                order_list.Items.Clear();
                while (reader.Read())
                {
                    string data1 = reader["주문자이름"].ToString();
                    string data2 = reader["주문자비밀번호"].ToString();
                    string data3 = reader["상품명"].ToString();
                    string data4 = reader["거주지"].ToString();

                    ListViewItem item = new ListViewItem(data1);
                    item.SubItems.Add(data2);
                    item.SubItems.Add(data3);
                    item.SubItems.Add(data4);

                    order_list.Items.Add(item);
                }
                reader.Close();
            }

            order_list.View = View.Details;
            order_list.GridLines = true;
            int listwidth = order_list.Width;

            order_list.Columns.Clear();
            order_list.Columns.Add("주문자이름", (int)(listwidth * 0.2));
            order_list.Columns.Add("주문자비밀번호", (int)(listwidth * 0.3));
            order_list.Columns.Add("상품명", (int)(listwidth * 0.2));
            order_list.Columns.Add("거주지", (int)(listwidth * 0.3));
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (order_list.SelectedItems.Count == 0)
            {
                MessageBox.Show("발주할 상품을 선택해주세요.", "POST");
                return;
            }

            // 선택된 항목을 삭제합니다.
            foreach (ListViewItem selectedItem in order_list.SelectedItems)
            {
                string 주문자이름 = selectedItem.SubItems[0].Text;
                string 주문자비밀번호 = selectedItem.SubItems[1].Text;
                string 상품명 = selectedItem.SubItems[2].Text;

                // SQL 삭제문
                string deleteQuery = "DELETE FROM 주문내역 WHERE 주문자이름 = @주문자이름 AND 주문자비밀번호 = @주문자비밀번호 and 상품명 = @상품명";

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                    {
                        // 매개변수 추가
                        cmd.Parameters.AddWithValue("@주문자이름", 주문자이름);
                        cmd.Parameters.AddWithValue("@주문자비밀번호", 주문자비밀번호);
                        cmd.Parameters.AddWithValue("@상품명", 상품명);

                        // 삭제 명령을 실행합니다.
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // 삭제 성공
                            MessageBox.Show("발주가 완료되었습니다.", "POST");
                        }
                        else
                        {
                            // 영향을 받은 행이 없으면 삭제 실패
                            MessageBox.Show("발주 실패.", "POST");
                        }
                    }
                }
            }
        }
    }
}
