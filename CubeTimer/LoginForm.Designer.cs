﻿namespace CubeTimer
{
    partial class LoginForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.applyButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(168, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 30);
            this.label5.TabIndex = 17;
            this.label5.Text = "密碼：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(168, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 30);
            this.label4.TabIndex = 16;
            this.label4.Text = "名稱：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(405, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 28);
            this.label3.TabIndex = 15;
            this.label3.Text = "會員登錄";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(501, 532);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "還沒有帳號 ? 來辦一個吧 ! ->";
            // 
            // applyButton
            // 
            this.applyButton.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.applyButton.Location = new System.Drawing.Point(839, 509);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(149, 60);
            this.applyButton.TabIndex = 13;
            this.applyButton.Text = "創辦帳號";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("標楷體", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.loginButton.Location = new System.Drawing.Point(377, 401);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(201, 64);
            this.loginButton.TabIndex = 12;
            this.loginButton.Text = "登入";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.passwordBox.Location = new System.Drawing.Point(290, 311);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(467, 43);
            this.passwordBox.TabIndex = 11;
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nameBox.Location = new System.Drawing.Point(290, 211);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(467, 43);
            this.nameBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(263, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 40);
            this.label1.TabIndex = 9;
            this.label1.Text = "Welcome ro C# timer";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 581);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
    }
}