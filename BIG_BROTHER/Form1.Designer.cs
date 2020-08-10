namespace BIG_BROTHER
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.host = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Host_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Host_state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Host_ping = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.конфигурацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьHostыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сканироватьСетьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.мониторитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтранутьХостыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разработчикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сборкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byErehonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.host,
            this.Host_name,
            this.Host_state,
            this.Host_ping});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(856, 431);
            this.dataGridView1.TabIndex = 0;
            // 
            // host
            // 
            this.host.Frozen = true;
            this.host.HeaderText = "Хост";
            this.host.Name = "host";
            this.host.ReadOnly = true;
            this.host.Width = 200;
            // 
            // Host_name
            // 
            this.Host_name.Frozen = true;
            this.Host_name.HeaderText = "Название";
            this.Host_name.Name = "Host_name";
            this.Host_name.ReadOnly = true;
            this.Host_name.Width = 280;
            // 
            // Host_state
            // 
            this.Host_state.Frozen = true;
            this.Host_state.HeaderText = "Стостояние";
            this.Host_state.Name = "Host_state";
            this.Host_state.ReadOnly = true;
            this.Host_state.Width = 120;
            // 
            // Host_ping
            // 
            this.Host_ping.Frozen = true;
            this.Host_ping.HeaderText = "Пинг";
            this.Host_ping.Name = "Host_ping";
            this.Host_ping.ReadOnly = true;
            this.Host_ping.Width = 120;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.конфигурацияToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.выходToolStripMenuItem,
            this.byErehonToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(856, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // конфигурацияToolStripMenuItem
            // 
            this.конфигурацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактироватьHostыToolStripMenuItem,
            this.сканироватьСетьToolStripMenuItem,
            this.мониторитьToolStripMenuItem,
            this.фильтранутьХостыToolStripMenuItem});
            this.конфигурацияToolStripMenuItem.Name = "конфигурацияToolStripMenuItem";
            this.конфигурацияToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.конфигурацияToolStripMenuItem.Text = "Конфигурация";
            this.конфигурацияToolStripMenuItem.Click += new System.EventHandler(this.конфигурацияToolStripMenuItem_Click);
            // 
            // редактироватьHostыToolStripMenuItem
            // 
            this.редактироватьHostыToolStripMenuItem.Name = "редактироватьHostыToolStripMenuItem";
            this.редактироватьHostыToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.редактироватьHostыToolStripMenuItem.Text = "Редактировать Hostы";
            this.редактироватьHostыToolStripMenuItem.Click += new System.EventHandler(this.редактироватьHostыToolStripMenuItem_Click);
            // 
            // сканироватьСетьToolStripMenuItem
            // 
            this.сканироватьСетьToolStripMenuItem.Name = "сканироватьСетьToolStripMenuItem";
            this.сканироватьСетьToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.сканироватьСетьToolStripMenuItem.Text = "Сканировать сеть";
            this.сканироватьСетьToolStripMenuItem.Click += new System.EventHandler(this.сканироватьСетьToolStripMenuItem_Click);
            // 
            // мониторитьToolStripMenuItem
            // 
            this.мониторитьToolStripMenuItem.Name = "мониторитьToolStripMenuItem";
            this.мониторитьToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.мониторитьToolStripMenuItem.Text = "Мониторить";
            this.мониторитьToolStripMenuItem.Click += new System.EventHandler(this.мониторитьToolStripMenuItem_Click);
            // 
            // фильтранутьХостыToolStripMenuItem
            // 
            this.фильтранутьХостыToolStripMenuItem.Name = "фильтранутьХостыToolStripMenuItem";
            this.фильтранутьХостыToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.фильтранутьХостыToolStripMenuItem.Text = "Фильтрануть хосты";
            this.фильтранутьХостыToolStripMenuItem.Click += new System.EventHandler(this.фильтранутьХостыToolStripMenuItem_Click_1);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.разработчикToolStripMenuItem,
            this.сборкаToolStripMenuItem});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // разработчикToolStripMenuItem
            // 
            this.разработчикToolStripMenuItem.Name = "разработчикToolStripMenuItem";
            this.разработчикToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.разработчикToolStripMenuItem.Text = "Разработчик";
            this.разработчикToolStripMenuItem.Click += new System.EventHandler(this.разработчикToolStripMenuItem_Click);
            // 
            // сборкаToolStripMenuItem
            // 
            this.сборкаToolStripMenuItem.Name = "сборкаToolStripMenuItem";
            this.сборкаToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.сборкаToolStripMenuItem.Text = "Сборка";
            this.сборкаToolStripMenuItem.Click += new System.EventHandler(this.сборкаToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(53, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // byErehonToolStripMenuItem
            // 
            this.byErehonToolStripMenuItem.Name = "byErehonToolStripMenuItem";
            this.byErehonToolStripMenuItem.Size = new System.Drawing.Size(72, 22);
            this.byErehonToolStripMenuItem.Text = "By Erehon";
            this.byErehonToolStripMenuItem.Click += new System.EventHandler(this.byErehonToolStripMenuItem_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Big Brother";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 433);
            this.progressBar1.Maximum = 256;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(856, 22);
            this.progressBar1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 455);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Big brother is watching you";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem конфигурацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem разработчикToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сборкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьHostыToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem byErehonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сканироватьСетьToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolStripMenuItem мониторитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтранутьХостыToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn host;
        private System.Windows.Forms.DataGridViewTextBoxColumn Host_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Host_state;
        private System.Windows.Forms.DataGridViewTextBoxColumn Host_ping;
    }
}

