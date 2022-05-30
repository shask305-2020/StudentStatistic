namespace StudentStatistic.Forms
{
    partial class AddBase
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
            this.btDelete = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.listBase = new System.Windows.Forms.ListBox();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btDelete
            // 
            this.btDelete.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Location = new System.Drawing.Point(14, 184);
            this.btDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(237, 28);
            this.btDelete.TabIndex = 9;
            this.btDelete.Text = "Удалить выделенный пункт";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Location = new System.Drawing.Point(613, 4);
            this.btAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(110, 26);
            this.btAdd.TabIndex = 8;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // listBase
            // 
            this.listBase.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBase.FormattingEnabled = true;
            this.listBase.ItemHeight = 17;
            this.listBase.Location = new System.Drawing.Point(15, 38);
            this.listBase.Margin = new System.Windows.Forms.Padding(2);
            this.listBase.Name = "listBase";
            this.listBase.Size = new System.Drawing.Size(711, 140);
            this.listBase.TabIndex = 7;
            // 
            // txtBase
            // 
            this.txtBase.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBase.Location = new System.Drawing.Point(206, 6);
            this.txtBase.Margin = new System.Windows.Forms.Padding(2);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(405, 24);
            this.txtBase.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "База образования: на базе";
            // 
            // AddBase
            // 
            this.AcceptButton = this.btAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 215);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.listBase);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.AddBase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.ListBox listBase;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.Label label1;
    }
}