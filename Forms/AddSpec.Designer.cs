namespace StudentStatistic.Forms
{
    partial class AddSpec
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
            this.txAbbr = new System.Windows.Forms.TextBox();
            this.txName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.txCode = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbLevel = new System.Windows.Forms.ComboBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.bt_add_level = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbBase = new System.Windows.Forms.ComboBox();
            this.bt_add_base = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txAbbr
            // 
            this.txAbbr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txAbbr.Location = new System.Drawing.Point(144, 78);
            this.txAbbr.Name = "txAbbr";
            this.txAbbr.Size = new System.Drawing.Size(528, 26);
            this.txAbbr.TabIndex = 3;
            // 
            // txName
            // 
            this.txName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txName.Location = new System.Drawing.Point(144, 45);
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(528, 26);
            this.txName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(34, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Сокращение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Наименование *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(89, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Код *";
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btAdd.Location = new System.Drawing.Point(372, 191);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(146, 36);
            this.btAdd.TabIndex = 6;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // txCode
            // 
            this.txCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txCode.Location = new System.Drawing.Point(144, 12);
            this.txCode.Mask = "00/00/00";
            this.txCode.Name = "txCode";
            this.txCode.Size = new System.Drawing.Size(173, 26);
            this.txCode.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(20, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Уровень обр. *";
            // 
            // cbLevel
            // 
            this.cbLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbLevel.FormattingEnabled = true;
            this.cbLevel.Location = new System.Drawing.Point(144, 113);
            this.cbLevel.Name = "cbLevel";
            this.cbLevel.Size = new System.Drawing.Size(428, 28);
            this.cbLevel.TabIndex = 4;
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCancel.Location = new System.Drawing.Point(525, 191);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(146, 36);
            this.btCancel.TabIndex = 7;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // bt_add_level
            // 
            this.bt_add_level.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_add_level.Location = new System.Drawing.Point(578, 113);
            this.bt_add_level.Name = "bt_add_level";
            this.bt_add_level.Size = new System.Drawing.Size(94, 28);
            this.bt_add_level.TabIndex = 8;
            this.bt_add_level.Text = "Добавить";
            this.bt_add_level.UseVisualStyleBackColor = true;
            this.bt_add_level.Click += new System.EventHandler(this.bt_add_level_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(55, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "На базе: *";
            // 
            // cbBase
            // 
            this.cbBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbBase.FormattingEnabled = true;
            this.cbBase.Location = new System.Drawing.Point(144, 147);
            this.cbBase.Name = "cbBase";
            this.cbBase.Size = new System.Drawing.Size(428, 28);
            this.cbBase.TabIndex = 5;
            // 
            // bt_add_base
            // 
            this.bt_add_base.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_add_base.Location = new System.Drawing.Point(578, 147);
            this.bt_add_base.Name = "bt_add_base";
            this.bt_add_base.Size = new System.Drawing.Size(94, 28);
            this.bt_add_base.TabIndex = 9;
            this.bt_add_base.Text = "Добавить";
            this.bt_add_base.UseVisualStyleBackColor = true;
            this.bt_add_base.Click += new System.EventHandler(this.bt_add_base_Click);
            // 
            // AddSpec
            // 
            this.AcceptButton = this.btAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 235);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bt_add_base);
            this.Controls.Add(this.bt_add_level);
            this.Controls.Add(this.cbBase);
            this.Controls.Add(this.cbLevel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txCode);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.txAbbr);
            this.Controls.Add(this.txName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddSpec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Специальность: ";
            this.Activated += new System.EventHandler(this.AddSpec_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddSpec_FormClosing);
            this.Load += new System.EventHandler(this.AddSpec_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddSpec_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txAbbr;
        private System.Windows.Forms.TextBox txName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.MaskedTextBox txCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbLevel;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button bt_add_level;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbBase;
        private System.Windows.Forms.Button bt_add_base;
    }
}