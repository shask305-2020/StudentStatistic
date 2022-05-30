namespace StudentStatistic.Forms
{
    partial class AddLevel
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
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.listLevel = new System.Windows.Forms.ListBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Уровень образования";
            // 
            // txtLevel
            // 
            this.txtLevel.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLevel.Location = new System.Drawing.Point(175, 14);
            this.txtLevel.Margin = new System.Windows.Forms.Padding(2);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(441, 24);
            this.txtLevel.TabIndex = 1;
            // 
            // listLevel
            // 
            this.listLevel.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLevel.FormattingEnabled = true;
            this.listLevel.ItemHeight = 17;
            this.listLevel.Location = new System.Drawing.Point(20, 46);
            this.listLevel.Margin = new System.Windows.Forms.Padding(2);
            this.listLevel.Name = "listLevel";
            this.listLevel.Size = new System.Drawing.Size(711, 140);
            this.listLevel.TabIndex = 2;
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Location = new System.Drawing.Point(618, 12);
            this.btAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(110, 26);
            this.btAdd.TabIndex = 3;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btDelete
            // 
            this.btDelete.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Location = new System.Drawing.Point(19, 192);
            this.btDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(237, 28);
            this.btDelete.TabIndex = 4;
            this.btDelete.Text = "Удалить выделенный пункт";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // AddLevel
            // 
            this.AcceptButton = this.btAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 226);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.listLevel);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить уровень образования";
            this.Load += new System.EventHandler(this.AddLevel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.ListBox listLevel;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btDelete;
    }
}