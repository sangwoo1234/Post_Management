namespace Protpolio_Order
{
    partial class UserInfomationForm
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
            this.name_lb = new System.Windows.Forms.Label();
            this.id_lb = new System.Windows.Forms.Label();
            this.pw_lb = new System.Windows.Forms.Label();
            this.num_lb = new System.Windows.Forms.Label();
            this.add_lb = new System.Windows.Forms.Label();
            this.id_tb = new System.Windows.Forms.TextBox();
            this.pw_tb = new System.Windows.Forms.TextBox();
            this.num_tb = new System.Windows.Forms.TextBox();
            this.add_tb = new System.Windows.Forms.TextBox();
            this.change_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.SystemColors.Control;
            this.exit_btn.FlatAppearance.BorderSize = 0;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.exit_btn.Location = new System.Drawing.Point(669, -1);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(30, 30);
            this.exit_btn.TabIndex = 17;
            this.exit_btn.Text = "X";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // name_lb
            // 
            this.name_lb.AutoSize = true;
            this.name_lb.Font = new System.Drawing.Font("한컴산뜻돋움", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.name_lb.Location = new System.Drawing.Point(263, 20);
            this.name_lb.Name = "name_lb";
            this.name_lb.Size = new System.Drawing.Size(179, 35);
            this.name_lb.TabIndex = 18;
            this.name_lb.Text = "개인 정보 변경";
            // 
            // id_lb
            // 
            this.id_lb.AutoSize = true;
            this.id_lb.Font = new System.Drawing.Font("한컴산뜻돋움", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.id_lb.Location = new System.Drawing.Point(198, 115);
            this.id_lb.Name = "id_lb";
            this.id_lb.Size = new System.Drawing.Size(51, 19);
            this.id_lb.TabIndex = 19;
            this.id_lb.Text = "아이디";
            // 
            // pw_lb
            // 
            this.pw_lb.AutoSize = true;
            this.pw_lb.Font = new System.Drawing.Font("한컴산뜻돋움", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pw_lb.Location = new System.Drawing.Point(184, 165);
            this.pw_lb.Name = "pw_lb";
            this.pw_lb.Size = new System.Drawing.Size(65, 19);
            this.pw_lb.TabIndex = 19;
            this.pw_lb.Text = "비밀번호";
            // 
            // num_lb
            // 
            this.num_lb.AutoSize = true;
            this.num_lb.Font = new System.Drawing.Font("한컴산뜻돋움", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.num_lb.Location = new System.Drawing.Point(184, 215);
            this.num_lb.Name = "num_lb";
            this.num_lb.Size = new System.Drawing.Size(65, 19);
            this.num_lb.TabIndex = 19;
            this.num_lb.Text = "전화번호";
            // 
            // add_lb
            // 
            this.add_lb.AutoSize = true;
            this.add_lb.Font = new System.Drawing.Font("한컴산뜻돋움", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.add_lb.Location = new System.Drawing.Point(198, 265);
            this.add_lb.Name = "add_lb";
            this.add_lb.Size = new System.Drawing.Size(51, 19);
            this.add_lb.TabIndex = 19;
            this.add_lb.Text = "거주지";
            // 
            // id_tb
            // 
            this.id_tb.Location = new System.Drawing.Point(272, 117);
            this.id_tb.Name = "id_tb";
            this.id_tb.Size = new System.Drawing.Size(230, 21);
            this.id_tb.TabIndex = 0;
            // 
            // pw_tb
            // 
            this.pw_tb.Location = new System.Drawing.Point(272, 167);
            this.pw_tb.Name = "pw_tb";
            this.pw_tb.Size = new System.Drawing.Size(230, 21);
            this.pw_tb.TabIndex = 1;
            // 
            // num_tb
            // 
            this.num_tb.Location = new System.Drawing.Point(272, 217);
            this.num_tb.Name = "num_tb";
            this.num_tb.Size = new System.Drawing.Size(230, 21);
            this.num_tb.TabIndex = 2;
            // 
            // add_tb
            // 
            this.add_tb.Location = new System.Drawing.Point(272, 265);
            this.add_tb.Name = "add_tb";
            this.add_tb.Size = new System.Drawing.Size(230, 21);
            this.add_tb.TabIndex = 3;
            // 
            // change_btn
            // 
            this.change_btn.BackColor = System.Drawing.Color.RoyalBlue;
            this.change_btn.FlatAppearance.BorderSize = 0;
            this.change_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.change_btn.Font = new System.Drawing.Font("한컴산뜻돋움", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.change_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.change_btn.Location = new System.Drawing.Point(202, 343);
            this.change_btn.Name = "change_btn";
            this.change_btn.Size = new System.Drawing.Size(302, 119);
            this.change_btn.TabIndex = 20;
            this.change_btn.Text = "변경하기";
            this.change_btn.UseVisualStyleBackColor = false;
            this.change_btn.Click += new System.EventHandler(this.change_btn_Click);
            // 
            // UserInfomationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.change_btn);
            this.Controls.Add(this.add_tb);
            this.Controls.Add(this.num_tb);
            this.Controls.Add(this.pw_tb);
            this.Controls.Add(this.id_tb);
            this.Controls.Add(this.add_lb);
            this.Controls.Add(this.num_lb);
            this.Controls.Add(this.pw_lb);
            this.Controls.Add(this.id_lb);
            this.Controls.Add(this.name_lb);
            this.Controls.Add(this.exit_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserInfomationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.UserInfomationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Label name_lb;
        private System.Windows.Forms.Label id_lb;
        private System.Windows.Forms.Label pw_lb;
        private System.Windows.Forms.Label num_lb;
        private System.Windows.Forms.Label add_lb;
        private System.Windows.Forms.TextBox id_tb;
        private System.Windows.Forms.TextBox pw_tb;
        private System.Windows.Forms.TextBox num_tb;
        private System.Windows.Forms.TextBox add_tb;
        private System.Windows.Forms.Button change_btn;
    }
}