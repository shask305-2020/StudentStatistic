namespace StudentStatistic.Forms
{
    partial class AddGroup
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
            this.btAdd = new System.Windows.Forms.Button();
            this.txName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSpec = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numKurs = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numKurs)).BeginInit();
            this.SuspendLayout();
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btAdd.Location = new System.Drawing.Point(526, 47);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(146, 26);
            this.btAdd.TabIndex = 4;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // txName
            // 
            this.txName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txName.Location = new System.Drawing.Point(376, 47);
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(120, 26);
            this.txName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(299, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Группа *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Специальность";
            // 
            // cbSpec
            // 
            this.cbSpec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbSpec.FormattingEnabled = true;
            this.cbSpec.Location = new System.Drawing.Point(157, 12);
            this.cbSpec.Name = "cbSpec";
            this.cbSpec.Size = new System.Drawing.Size(518, 28);
            this.cbSpec.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(97, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Курс";
            // 
            // numKurs
            // 
            this.numKurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numKurs.Location = new System.Drawing.Point(157, 48);
            this.numKurs.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numKurs.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numKurs.Name = "numKurs";
            this.numKurs.Size = new System.Drawing.Size(120, 26);
            this.numKurs.TabIndex = 2;
            this.numKurs.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AddGroup
            // 
            this.AcceptButton = this.btAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 88);
            this.Controls.Add(this.numKurs);
            this.Controls.Add(this.cbSpec);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.txName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Группа: Новая";
            this.Load += new System.EventHandler(this.AddGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numKurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox txName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSpec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numKurs;
    }
}