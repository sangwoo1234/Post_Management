namespace Protpolio_Order
{
    partial class UserAddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.exit_btn = new System.Windows.Forms.Button();
            this.lb_id = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.p_id = new System.Windows.Forms.Panel();
            this.lb_pw = new System.Windows.Forms.Label();
            this.tb_pw = new System.Windows.Forms.TextBox();
            this.p_p = new System.Windows.Forms.Panel();
            this.p_ua = new System.Windows.Forms.Panel();
            this.hidepw_pb = new System.Windows.Forms.PictureBox();
            this.sameid_btn = new System.Windows.Forms.Button();
            this.useradd_btn = new System.Windows.Forms.Button();
            this.p_num = new System.Windows.Forms.Panel();
            this.lb_UserAdd = new System.Windows.Forms.Label();
            this.tb_num = new System.Windows.Forms.TextBox();
            this.lb_num = new System.Windows.Forms.Label();
            this.p_ua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hidepw_pb)).BeginInit();
            this.SuspendLayout();
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
            this.exit_btn.TabIndex = 4;
            this.exit_btn.Text = "X";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Font = new System.Drawing.Font("Calibri", 12F);
            this.lb_id.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_id.Location = new System.Drawing.Point(7, 110);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(73, 19);
            this.lb_id.TabIndex = 4;
            this.lb_id.Text = "사용자 이름";
            // 
            // tb_id
            // 
            this.tb_id.BackColor = System.Drawing.SystemColors.Control;
            this.tb_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_id.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id.Location = new System.Drawing.Point(11, 137);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(191, 19);
            this.tb_id.TabIndex = 1;
            // 
            // p_id
            // 
            this.p_id.BackColor = System.Drawing.SystemColors.ControlText;
            this.p_id.Location = new System.Drawing.Point(9, 162);
            this.p_id.Name = "p_id";
            this.p_id.Size = new System.Drawing.Size(215, 1);
            this.p_id.TabIndex = 6;
            // 
            // lb_pw
            // 
            this.lb_pw.AutoSize = true;
            this.lb_pw.Font = new System.Drawing.Font("Calibri", 12F);
            this.lb_pw.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_pw.Location = new System.Drawing.Point(7, 190);
            this.lb_pw.Name = "lb_pw";
            this.lb_pw.Size = new System.Drawing.Size(57, 19);
            this.lb_pw.TabIndex = 4;
            this.lb_pw.Text = "비밀번호";
            // 
            // tb_pw
            // 
            this.tb_pw.BackColor = System.Drawing.SystemColors.Control;
            this.tb_pw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_pw.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pw.Location = new System.Drawing.Point(11, 212);
            this.tb_pw.Name = "tb_pw";
            this.tb_pw.PasswordChar = '*';
            this.tb_pw.Size = new System.Drawing.Size(150, 19);
            this.tb_pw.TabIndex = 2;
            // 
            // p_p
            // 
            this.p_p.BackColor = System.Drawing.SystemColors.ControlText;
            this.p_p.Location = new System.Drawing.Point(9, 237);
            this.p_p.Name = "p_p";
            this.p_p.Size = new System.Drawing.Size(215, 1);
            this.p_p.TabIndex = 7;
            // 
            // p_ua
            // 
            this.p_ua.BackColor = System.Drawing.SystemColors.Control;
            this.p_ua.Controls.Add(this.hidepw_pb);
            this.p_ua.Controls.Add(this.sameid_btn);
            this.p_ua.Controls.Add(this.useradd_btn);
            this.p_ua.Controls.Add(this.p_num);
            this.p_ua.Controls.Add(this.lb_UserAdd);
            this.p_ua.Controls.Add(this.p_p);
            this.p_ua.Controls.Add(this.p_id);
            this.p_ua.Controls.Add(this.tb_num);
            this.p_ua.Controls.Add(this.tb_pw);
            this.p_ua.Controls.Add(this.tb_id);
            this.p_ua.Controls.Add(this.lb_num);
            this.p_ua.Controls.Add(this.lb_pw);
            this.p_ua.Controls.Add(this.lb_id);
            this.p_ua.Location = new System.Drawing.Point(25, 23);
            this.p_ua.Name = "p_ua";
            this.p_ua.Size = new System.Drawing.Size(300, 400);
            this.p_ua.TabIndex = 8;
            this.p_ua.Paint += new System.Windows.Forms.PaintEventHandler(this.p_ua_Paint);
            // 
            // hidepw_pb
            // 
            this.hidepw_pb.BackColor = System.Drawing.Color.Transparent;
            this.hidepw_pb.Image = global::Protpolio_Order.Properties.Resources.hide2;
            this.hidepw_pb.Location = new System.Drawing.Point(186, 200);
            this.hidepw_pb.Name = "hidepw_pb";
            this.hidepw_pb.Size = new System.Drawing.Size(38, 35);
            this.hidepw_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hidepw_pb.TabIndex = 10;
            this.hidepw_pb.TabStop = false;
            this.hidepw_pb.Click += new System.EventHandler(this.hidepw_pb_Click);
            // 
            // sameid_btn
            // 
            this.sameid_btn.BackColor = System.Drawing.Color.SkyBlue;
            this.sameid_btn.FlatAppearance.BorderSize = 0;
            this.sameid_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sameid_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.sameid_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.sameid_btn.Location = new System.Drawing.Point(230, 137);
            this.sameid_btn.Name = "sameid_btn";
            this.sameid_btn.Size = new System.Drawing.Size(59, 22);
            this.sameid_btn.TabIndex = 9;
            this.sameid_btn.Text = "중복체크";
            this.sameid_btn.UseVisualStyleBackColor = false;
            this.sameid_btn.Click += new System.EventHandler(this.sameid_btn_Click);
            // 
            // useradd_btn
            // 
            this.useradd_btn.BackColor = System.Drawing.Color.SkyBlue;
            this.useradd_btn.FlatAppearance.BorderSize = 0;
            this.useradd_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.useradd_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.useradd_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.useradd_btn.Location = new System.Drawing.Point(98, 338);
            this.useradd_btn.Name = "useradd_btn";
            this.useradd_btn.Size = new System.Drawing.Size(104, 33);
            this.useradd_btn.TabIndex = 9;
            this.useradd_btn.Text = "회원가입";
            this.useradd_btn.UseVisualStyleBackColor = false;
            this.useradd_btn.Click += new System.EventHandler(this.useradd_btn_Click);
            // 
            // p_num
            // 
            this.p_num.BackColor = System.Drawing.SystemColors.ControlText;
            this.p_num.Location = new System.Drawing.Point(9, 312);
            this.p_num.Name = "p_num";
            this.p_num.Size = new System.Drawing.Size(215, 1);
            this.p_num.TabIndex = 8;
            // 
            // lb_UserAdd
            // 
            this.lb_UserAdd.AutoSize = true;
            this.lb_UserAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_UserAdd.Font = new System.Drawing.Font("Calibri", 19.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_UserAdd.Location = new System.Drawing.Point(100, 40);
            this.lb_UserAdd.Name = "lb_UserAdd";
            this.lb_UserAdd.Size = new System.Drawing.Size(102, 32);
            this.lb_UserAdd.TabIndex = 8;
            this.lb_UserAdd.Text = "회원가입";
            // 
            // tb_num
            // 
            this.tb_num.BackColor = System.Drawing.SystemColors.Control;
            this.tb_num.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_num.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_num.Location = new System.Drawing.Point(11, 287);
            this.tb_num.Name = "tb_num";
            this.tb_num.Size = new System.Drawing.Size(191, 19);
            this.tb_num.TabIndex = 3;
            // 
            // lb_num
            // 
            this.lb_num.AutoSize = true;
            this.lb_num.Font = new System.Drawing.Font("Calibri", 12F);
            this.lb_num.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_num.Location = new System.Drawing.Point(7, 270);
            this.lb_num.Name = "lb_num";
            this.lb_num.Size = new System.Drawing.Size(57, 19);
            this.lb_num.TabIndex = 4;
            this.lb_num.Text = "전화번호";
            // 
            // UserAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::Protpolio_Order.Properties.Resources.그라데이션3;
            this.ClientSize = new System.Drawing.Size(350, 450);
            this.Controls.Add(this.p_ua);
            this.Controls.Add(this.exit_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserAdd";
            this.p_ua.ResumeLayout(false);
            this.p_ua.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hidepw_pb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Panel p_id;
        private System.Windows.Forms.Label lb_pw;
        private System.Windows.Forms.TextBox tb_pw;
        private System.Windows.Forms.Panel p_p;
        private System.Windows.Forms.Panel p_ua;
        private System.Windows.Forms.Label lb_UserAdd;
        private System.Windows.Forms.Panel p_num;
        private System.Windows.Forms.TextBox tb_num;
        private System.Windows.Forms.Label lb_num;
        private System.Windows.Forms.Button useradd_btn;
        private System.Windows.Forms.Button sameid_btn;
        private System.Windows.Forms.PictureBox hidepw_pb;
    }
}