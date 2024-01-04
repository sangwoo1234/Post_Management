namespace Protpolio_Order
{
    partial class LoginForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.l_p = new System.Windows.Forms.Panel();
            this.p_p = new System.Windows.Forms.Panel();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_pw = new System.Windows.Forms.TextBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.lb_pw = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.ua_btn = new System.Windows.Forms.Button();
            this.pb_p = new System.Windows.Forms.Panel();
            this.post_pb = new System.Windows.Forms.PictureBox();
            this.exit_btn = new System.Windows.Forms.Button();
            this.pb_p.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.post_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // l_p
            // 
            this.l_p.BackColor = System.Drawing.SystemColors.ControlText;
            this.l_p.Location = new System.Drawing.Point(67, 223);
            this.l_p.Name = "l_p";
            this.l_p.Size = new System.Drawing.Size(215, 1);
            this.l_p.TabIndex = 0;
            // 
            // p_p
            // 
            this.p_p.BackColor = System.Drawing.SystemColors.ControlText;
            this.p_p.Location = new System.Drawing.Point(67, 305);
            this.p_p.Name = "p_p";
            this.p_p.Size = new System.Drawing.Size(214, 1);
            this.p_p.TabIndex = 1;
            // 
            // tb_id
            // 
            this.tb_id.BackColor = System.Drawing.SystemColors.Control;
            this.tb_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_id.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id.Location = new System.Drawing.Point(69, 200);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(213, 19);
            this.tb_id.TabIndex = 1;
            // 
            // tb_pw
            // 
            this.tb_pw.BackColor = System.Drawing.SystemColors.Control;
            this.tb_pw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_pw.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pw.Location = new System.Drawing.Point(69, 282);
            this.tb_pw.Name = "tb_pw";
            this.tb_pw.Size = new System.Drawing.Size(213, 19);
            this.tb_pw.TabIndex = 2;
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.lb_id.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_id.Location = new System.Drawing.Point(65, 180);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(66, 17);
            this.lb_id.TabIndex = 3;
            this.lb_id.Text = "Username";
            // 
            // lb_pw
            // 
            this.lb_pw.AutoSize = true;
            this.lb_pw.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.lb_pw.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_pw.Location = new System.Drawing.Point(65, 262);
            this.lb_pw.Name = "lb_pw";
            this.lb_pw.Size = new System.Drawing.Size(61, 17);
            this.lb_pw.TabIndex = 3;
            this.lb_pw.Text = "Password";
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.SkyBlue;
            this.login_btn.FlatAppearance.BorderSize = 0;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.login_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.login_btn.Location = new System.Drawing.Point(67, 367);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(104, 33);
            this.login_btn.TabIndex = 3;
            this.login_btn.Text = "로그인";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // ua_btn
            // 
            this.ua_btn.BackColor = System.Drawing.Color.SkyBlue;
            this.ua_btn.FlatAppearance.BorderSize = 0;
            this.ua_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ua_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.ua_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.ua_btn.Location = new System.Drawing.Point(177, 366);
            this.ua_btn.Name = "ua_btn";
            this.ua_btn.Size = new System.Drawing.Size(105, 35);
            this.ua_btn.TabIndex = 4;
            this.ua_btn.Text = "사용자 추가";
            this.ua_btn.UseVisualStyleBackColor = false;
            this.ua_btn.Click += new System.EventHandler(this.ua_btn_Click);
            // 
            // pb_p
            // 
            this.pb_p.BackColor = System.Drawing.SystemColors.Control;
            this.pb_p.BackgroundImage = global::Protpolio_Order.Properties.Resources.그라데이션3;
            this.pb_p.Controls.Add(this.post_pb);
            this.pb_p.Controls.Add(this.exit_btn);
            this.pb_p.Dock = System.Windows.Forms.DockStyle.Top;
            this.pb_p.Location = new System.Drawing.Point(0, 0);
            this.pb_p.Name = "pb_p";
            this.pb_p.Size = new System.Drawing.Size(350, 153);
            this.pb_p.TabIndex = 5;
            // 
            // post_pb
            // 
            this.post_pb.BackColor = System.Drawing.Color.Transparent;
            this.post_pb.BackgroundImage = global::Protpolio_Order.Properties.Resources.그라데이션;
            this.post_pb.Image = global::Protpolio_Order.Properties.Resources.우체국;
            this.post_pb.Location = new System.Drawing.Point(71, 8);
            this.post_pb.Name = "post_pb";
            this.post_pb.Size = new System.Drawing.Size(209, 138);
            this.post_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.post_pb.TabIndex = 0;
            this.post_pb.TabStop = false;
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.SystemColors.Control;
            this.exit_btn.BackgroundImage = global::Protpolio_Order.Properties.Resources.그라데이션3;
            this.exit_btn.FlatAppearance.BorderSize = 0;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.exit_btn.Location = new System.Drawing.Point(320, 0);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(30, 30);
            this.exit_btn.TabIndex = 5;
            this.exit_btn.Text = "X";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 450);
            this.Controls.Add(this.pb_p);
            this.Controls.Add(this.ua_btn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.lb_pw);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.tb_pw);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.p_p);
            this.Controls.Add(this.l_p);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.pb_p.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.post_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel l_p;
        private System.Windows.Forms.Panel p_p;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_pw;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label lb_pw;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Panel pb_p;
        private System.Windows.Forms.PictureBox post_pb;
        private System.Windows.Forms.Button ua_btn;
    }
}

