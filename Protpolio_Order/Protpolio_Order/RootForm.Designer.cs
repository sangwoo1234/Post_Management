namespace Protpolio_Order
{
    partial class RootForm
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
            this.root_lb = new System.Windows.Forms.Label();
            this.order_list = new System.Windows.Forms.ListView();
            this.btn = new System.Windows.Forms.Button();
            this.lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.SystemColors.Control;
            this.exit_btn.FlatAppearance.BorderSize = 0;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.exit_btn.Location = new System.Drawing.Point(1170, -1);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(30, 30);
            this.exit_btn.TabIndex = 6;
            this.exit_btn.Text = "X";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // root_lb
            // 
            this.root_lb.AutoSize = true;
            this.root_lb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.root_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.root_lb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.root_lb.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.root_lb.Location = new System.Drawing.Point(983, 32);
            this.root_lb.Name = "root_lb";
            this.root_lb.Size = new System.Drawing.Size(217, 24);
            this.root_lb.TabIndex = 16;
            this.root_lb.Text = "루트 계정으로 접속하셨습니다";
            this.root_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // order_list
            // 
            this.order_list.HideSelection = false;
            this.order_list.Location = new System.Drawing.Point(3, 162);
            this.order_list.Name = "order_list";
            this.order_list.Size = new System.Drawing.Size(1195, 342);
            this.order_list.TabIndex = 17;
            this.order_list.UseCompatibleStateImageBehavior = false;
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn.FlatAppearance.BorderSize = 0;
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn.Font = new System.Drawing.Font("한컴산뜻돋움", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn.Location = new System.Drawing.Point(446, 539);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(302, 119);
            this.btn.TabIndex = 21;
            this.btn.Text = "발주";
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("한컴산뜻돋움", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb.Location = new System.Drawing.Point(522, 57);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(122, 35);
            this.lb.TabIndex = 22;
            this.lb.Text = "발주 관리";
            // 
            // RootForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.order_list);
            this.Controls.Add(this.root_lb);
            this.Controls.Add(this.exit_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RootForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RootForm";
            this.Load += new System.EventHandler(this.RootForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Label root_lb;
        private System.Windows.Forms.ListView order_list;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label lb;
    }
}