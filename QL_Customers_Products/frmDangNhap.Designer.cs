﻿namespace QL_Customers_Products
{
    partial class frmDangNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.btnCloseForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
            this.label1.Location = new System.Drawing.Point(493, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng Nhập Hệ Thống";
            // 
            // logo
            // 
            this.logo.Image = global::QL_Customers_Products.Properties.Resources.logo_aeon;
            this.logo.Location = new System.Drawing.Point(12, 144);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(427, 388);
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
            this.label2.Location = new System.Drawing.Point(459, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Đăng Nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
            this.label3.Location = new System.Drawing.Point(542, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật Khẩu";
            // 
            // txt_Username
            // 
            this.txt_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.Location = new System.Drawing.Point(729, 204);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(232, 38);
            this.txt_Username.TabIndex = 1;
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(729, 307);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(232, 38);
            this.txt_Password.TabIndex = 2;
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
            this.btn_DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangNhap.ForeColor = System.Drawing.Color.White;
            this.btn_DangNhap.Location = new System.Drawing.Point(603, 403);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(205, 60);
            this.btn_DangNhap.TabIndex = 3;
            this.btn_DangNhap.Text = "Đăng Nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = false;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.FlatAppearance.BorderSize = 0;
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseForm.ForeColor = System.Drawing.Color.Red;
            this.btnCloseForm.Location = new System.Drawing.Point(943, -1);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(64, 48);
            this.btnCloseForm.TabIndex = 4;
            this.btnCloseForm.Text = "X";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 548);
            this.ControlBox = false;
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.Button btnCloseForm;
    }
}