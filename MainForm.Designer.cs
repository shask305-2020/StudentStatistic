namespace StudentStatistic
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettingsApp = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSpecGuide = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGroupGuide = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStudentsGuide = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.справочникиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1237, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSettingsApp});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // menuSettingsApp
            // 
            this.menuSettingsApp.Name = "menuSettingsApp";
            this.menuSettingsApp.Size = new System.Drawing.Size(254, 26);
            this.menuSettingsApp.Text = "Настройки программы";
            this.menuSettingsApp.Click += new System.EventHandler(this.menuSettingsApp_Click);
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSpecGuide,
            this.menuGroupGuide,
            this.menuStudentsGuide});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // menuSpecGuide
            // 
            this.menuSpecGuide.Name = "menuSpecGuide";
            this.menuSpecGuide.Size = new System.Drawing.Size(224, 26);
            this.menuSpecGuide.Text = "Специальности";
            this.menuSpecGuide.Click += new System.EventHandler(this.menuSpecGuide_Click);
            // 
            // menuGroupGuide
            // 
            this.menuGroupGuide.Name = "menuGroupGuide";
            this.menuGroupGuide.Size = new System.Drawing.Size(224, 26);
            this.menuGroupGuide.Text = "Учебные группы";
            this.menuGroupGuide.Click += new System.EventHandler(this.menuGroupGuide_Click);
            // 
            // menuStudentsGuide
            // 
            this.menuStudentsGuide.Name = "menuStudentsGuide";
            this.menuStudentsGuide.Size = new System.Drawing.Size(224, 26);
            this.menuStudentsGuide.Text = "Студенты";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 630);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма отчета СПО-1 (раздел 2.10)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuSettingsApp;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuGroupGuide;
        private System.Windows.Forms.ToolStripMenuItem menuSpecGuide;
        private System.Windows.Forms.ToolStripMenuItem menuStudentsGuide;
    }
}

