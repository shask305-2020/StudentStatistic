namespace MySQL_Client
{
    partial class SettingsApp
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
            this.txServerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txDBname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txLogin = new System.Windows.Forms.TextBox();
            this.txPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btApply = new System.Windows.Forms.Button();
            this.chViewPass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название сервера";
            // 
            // txServerName
            // 
            this.txServerName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txServerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txServerName.Location = new System.Drawing.Point(168, 9);
            this.txServerName.Name = "txServerName";
            this.txServerName.Size = new System.Drawing.Size(198, 22);
            this.txServerName.TabIndex = 1;
            this.txServerName.TextChanged += new System.EventHandler(this.txServerName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название базы данных";
            // 
            // txDBname
            // 
            this.txDBname.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txDBname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txDBname.Location = new System.Drawing.Point(168, 44);
            this.txDBname.Name = "txDBname";
            this.txDBname.Size = new System.Drawing.Size(198, 22);
            this.txDBname.TabIndex = 2;
            this.txDBname.TextChanged += new System.EventHandler(this.txDBname_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(116, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Логин";
            // 
            // txLogin
            // 
            this.txLogin.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txLogin.Location = new System.Drawing.Point(168, 79);
            this.txLogin.Name = "txLogin";
            this.txLogin.Size = new System.Drawing.Size(198, 22);
            this.txLogin.TabIndex = 3;
            this.txLogin.TextChanged += new System.EventHandler(this.txLogin_TextChanged);
            // 
            // txPass
            // 
            this.txPass.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txPass.Location = new System.Drawing.Point(168, 114);
            this.txPass.Name = "txPass";
            this.txPass.Size = new System.Drawing.Size(198, 22);
            this.txPass.TabIndex = 4;
            this.txPass.TextChanged += new System.EventHandler(this.txPass_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(106, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Пароль";
            // 
            // btApply
            // 
            this.btApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btApply.Location = new System.Drawing.Point(216, 142);
            this.btApply.Name = "btApply";
            this.btApply.Size = new System.Drawing.Size(150, 25);
            this.btApply.TabIndex = 5;
            this.btApply.Text = "Применить настройки";
            this.btApply.UseVisualStyleBackColor = false;
            this.btApply.Click += new System.EventHandler(this.btApply_Click);
            // 
            // chViewPass
            // 
            this.chViewPass.AutoSize = true;
            this.chViewPass.Location = new System.Drawing.Point(6, 147);
            this.chViewPass.Name = "chViewPass";
            this.chViewPass.Size = new System.Drawing.Size(114, 17);
            this.chViewPass.TabIndex = 6;
            this.chViewPass.Text = "Показать пароль";
            this.chViewPass.UseVisualStyleBackColor = true;
            this.chViewPass.CheckedChanged += new System.EventHandler(this.chViewPass_CheckedChanged);
            // 
            // SettingsApp
            // 
            this.AcceptButton = this.btApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(376, 176);
            this.Controls.Add(this.chViewPass);
            this.Controls.Add(this.txServerName);
            this.Controls.Add(this.txDBname);
            this.Controls.Add(this.txLogin);
            this.Controls.Add(this.txPass);
            this.Controls.Add(this.btApply);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки соединения";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsApp_FormClosing);
            this.Load += new System.EventHandler(this.SettingsApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txServerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txDBname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txLogin;
        private System.Windows.Forms.TextBox txPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btApply;
        private System.Windows.Forms.CheckBox chViewPass;
    }
}