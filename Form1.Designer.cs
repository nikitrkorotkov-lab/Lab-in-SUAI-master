namespace lab1forms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabLab1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTask2 = new System.Windows.Forms.Button();
            this.btnTask1 = new System.Windows.Forms.Button();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBitwiseAdd = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.tabLab2 = new System.Windows.Forms.TabPage();
            this.tabLab3 = new System.Windows.Forms.TabPage();
            this.tabLab4 = new System.Windows.Forms.TabPage();
            this.tabLab5 = new System.Windows.Forms.TabPage();

            // ── новые компоненты: меню, статус-бар, журнал исключений ──────────
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsoleVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLabs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLab1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLab2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLab3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLab4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLab5 = new System.Windows.Forms.ToolStripMenuItem();

            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusProcessLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusProcessName = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.statusDateTimeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusDateTime = new System.Windows.Forms.ToolStripStatusLabel();

            this.grpGlobalLog = new System.Windows.Forms.GroupBox();
            this.txtGlobalExceptions = new System.Windows.Forms.TextBox();

            this.timerClock = new System.Windows.Forms.Timer(this.components);

            this.tabControl.SuspendLayout();
            this.tabLab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.grpGlobalLog.SuspendLayout();
            this.SuspendLayout();

            //
            // menuStrip1
            //
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuLabs});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2800, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            //
            // menuFile
            //
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuConsoleVersion,
            this.menuFileSeparator,
            this.menuExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Text = "Файл";
            //
            // menuConsoleVersion
            //
            this.menuConsoleVersion.Name = "menuConsoleVersion";
            this.menuConsoleVersion.Text = "Консольная версия (Лаб. 1)";
            //
            // menuFileSeparator
            //
            this.menuFileSeparator.Name = "menuFileSeparator";
            //
            // menuExit
            //
            this.menuExit.Name = "menuExit";
            this.menuExit.Text = "Выход";
            //
            // menuLabs
            //
            this.menuLabs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLab1,
            this.menuLab2,
            this.menuLab3,
            this.menuLab4,
            this.menuLab5});
            this.menuLabs.Name = "menuLabs";
            this.menuLabs.Text = "Лабораторные работы";
            //
            // menuLab1..5
            //
            this.menuLab1.Name = "menuLab1";
            this.menuLab1.Text = "Лабораторная №1";
            this.menuLab2.Name = "menuLab2";
            this.menuLab2.Text = "Лабораторная №2";
            this.menuLab3.Name = "menuLab3";
            this.menuLab3.Text = "Лабораторная №3";
            this.menuLab4.Name = "menuLab4";
            this.menuLab4.Text = "Лабораторная №4";
            this.menuLab5.Name = "menuLab5";
            this.menuLab5.Text = "Лабораторная №5";

            //
            // statusStrip1
            //
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusProcessLabel,
            this.statusProcessName,
            this.statusProgress,
            this.statusDateTimeLabel,
            this.statusDateTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1408);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(2800, 30);
            this.statusStrip1.TabIndex = 11;
            //
            // statusProcessLabel / statusProcessName
            //
            this.statusProcessLabel.Name = "statusProcessLabel";
            this.statusProcessLabel.Text = "Процесс:";
            this.statusProcessName.Name = "statusProcessName";
            this.statusProcessName.Text = "Ожидание";
            this.statusProcessName.Spring = false;
            this.statusProcessName.AutoSize = true;
            //
            // statusProgress
            //
            this.statusProgress.Name = "statusProgress";
            this.statusProgress.Size = new System.Drawing.Size(160, 20);
            //
            // statusDateTimeLabel / statusDateTime
            //
            this.statusDateTimeLabel.Name = "statusDateTimeLabel";
            this.statusDateTimeLabel.Text = "Дата/время:";
            this.statusDateTime.Name = "statusDateTime";
            this.statusDateTime.Text = "—";
            this.statusDateTime.AutoSize = true;

            //
            // grpGlobalLog
            //
            this.grpGlobalLog.Controls.Add(this.txtGlobalExceptions);
            this.grpGlobalLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpGlobalLog.Height = 160;
            this.grpGlobalLog.Name = "grpGlobalLog";
            this.grpGlobalLog.TabStop = false;
            this.grpGlobalLog.Text = "Журнал необработанных исключений (главная форма + exceptions_log.txt)";
            //
            // txtGlobalExceptions
            //
            this.txtGlobalExceptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGlobalExceptions.Multiline = true;
            this.txtGlobalExceptions.ReadOnly = true;
            this.txtGlobalExceptions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGlobalExceptions.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.txtGlobalExceptions.BackColor = System.Drawing.Color.FromArgb(24, 24, 28);
            this.txtGlobalExceptions.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtGlobalExceptions.Name = "txtGlobalExceptions";

            //
            // tabControl
            //
            this.tabControl.Controls.Add(this.tabLab1);
            this.tabControl.Controls.Add(this.tabLab2);
            this.tabControl.Controls.Add(this.tabLab3);
            this.tabControl.Controls.Add(this.tabLab4);
            this.tabControl.Controls.Add(this.tabLab5);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(2800, 1338);
            this.tabControl.TabIndex = 0;
            //
            // tabLab1
            //
            this.tabLab1.Controls.Add(this.splitContainer1);
            this.tabLab1.Location = new System.Drawing.Point(10, 47);
            this.tabLab1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.tabLab1.Name = "tabLab1";
            this.tabLab1.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.tabLab1.Size = new System.Drawing.Size(2780, 1281);
            this.tabLab1.TabIndex = 0;
            this.tabLab1.Text = "Лабораторная №1";
            this.tabLab1.UseVisualStyleBackColor = true;
            //
            // splitContainer1
            //
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(7, 7);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.txtOutput);
            this.splitContainer1.Size = new System.Drawing.Size(2766, 1267);
            this.splitContainer1.SplitterDistance = 932;
            this.splitContainer1.SplitterWidth = 9;
            this.splitContainer1.TabIndex = 0;
            //
            // groupBox1
            //
            this.groupBox1.Controls.Add(this.btnTask2);
            this.groupBox1.Controls.Add(this.btnTask1);
            this.groupBox1.Controls.Add(this.txtN);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnBitwiseAdd);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtSurname);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblSurname);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.groupBox1.Size = new System.Drawing.Size(932, 1267);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Функции";
            //
            // btnTask2
            //
            this.btnTask2.Location = new System.Drawing.Point(47, 781);
            this.btnTask2.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnTask2.Name = "btnTask2";
            this.btnTask2.Size = new System.Drawing.Size(840, 89);
            this.btnTask2.TabIndex = 8;
            this.btnTask2.Text = "Задание 2: Найти A + B² = C² (1-20)";
            this.btnTask2.UseVisualStyleBackColor = true;
            this.btnTask2.Click += new System.EventHandler(this.btnTask2_Click);
            //
            // btnTask1
            //
            this.btnTask1.Location = new System.Drawing.Point(47, 625);
            this.btnTask1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnTask1.Name = "btnTask1";
            this.btnTask1.Size = new System.Drawing.Size(840, 89);
            this.btnTask1.TabIndex = 7;
            this.btnTask1.Text = "Задание 1: Найти числа с N делителями";
            this.btnTask1.UseVisualStyleBackColor = true;
            this.btnTask1.Click += new System.EventHandler(this.btnTask1_Click);
            //
            // txtN
            //
            this.txtN.Location = new System.Drawing.Point(47, 535);
            this.txtN.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(835, 35);
            this.txtN.TabIndex = 6;
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 491);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Количество делителей N (1-200):";
            //
            // btnBitwiseAdd
            //
            this.btnBitwiseAdd.Location = new System.Drawing.Point(47, 312);
            this.btnBitwiseAdd.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnBitwiseAdd.Name = "btnBitwiseAdd";
            this.btnBitwiseAdd.Size = new System.Drawing.Size(840, 89);
            this.btnBitwiseAdd.TabIndex = 4;
            this.btnBitwiseAdd.Text = "Выполнить поразрядное сложение";
            this.btnBitwiseAdd.UseVisualStyleBackColor = true;
            this.btnBitwiseAdd.Click += new System.EventHandler(this.btnBitwiseAdd_Click);
            //
            // txtName
            //
            this.txtName.Location = new System.Drawing.Point(47, 223);
            this.txtName.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(835, 35);
            this.txtName.TabIndex = 3;
            //
            // txtSurname
            //
            this.txtSurname.Location = new System.Drawing.Point(47, 112);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(835, 35);
            this.txtSurname.TabIndex = 2;
            //
            // lblName
            //
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(47, 178);
            this.lblName.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(69, 29);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Имя:";
            //
            // lblSurname
            //
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(47, 67);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(129, 29);
            this.lblSurname.TabIndex = 0;
            this.lblSurname.Text = "Фамилия:";
            //
            // txtOutput
            //
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtOutput.Location = new System.Drawing.Point(0, 0);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(1825, 1267);
            this.txtOutput.TabIndex = 0;
            this.txtOutput.WordWrap = false;
            //
            // tabLab2..5
            //
            this.tabLab2.Location = new System.Drawing.Point(10, 47);
            this.tabLab2.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.tabLab2.Name = "tabLab2";
            this.tabLab2.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.tabLab2.Size = new System.Drawing.Size(2780, 1281);
            this.tabLab2.TabIndex = 1;
            this.tabLab2.Text = "Лабораторная №2";
            this.tabLab2.UseVisualStyleBackColor = true;

            this.tabLab3.Location = new System.Drawing.Point(10, 47);
            this.tabLab3.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.tabLab3.Name = "tabLab3";
            this.tabLab3.Size = new System.Drawing.Size(2780, 1281);
            this.tabLab3.TabIndex = 2;
            this.tabLab3.Text = "Лабораторная №3";
            this.tabLab3.UseVisualStyleBackColor = true;

            this.tabLab4.Location = new System.Drawing.Point(10, 47);
            this.tabLab4.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.tabLab4.Name = "tabLab4";
            this.tabLab4.Size = new System.Drawing.Size(2780, 1281);
            this.tabLab4.TabIndex = 3;
            this.tabLab4.Text = "Лабораторная №4";
            this.tabLab4.UseVisualStyleBackColor = true;

            this.tabLab5.Location = new System.Drawing.Point(10, 47);
            this.tabLab5.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.tabLab5.Name = "tabLab5";
            this.tabLab5.Size = new System.Drawing.Size(2780, 1281);
            this.tabLab5.TabIndex = 4;
            this.tabLab5.Text = "Лабораторная №5";
            this.tabLab5.UseVisualStyleBackColor = true;

            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2800, 1438);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.grpGlobalLog);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Гр. 3437к - Луговской М. С. — Консолидированный проект ЛР";

            this.tabControl.ResumeLayout(false);
            this.tabLab1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grpGlobalLog.ResumeLayout(false);
            this.grpGlobalLog.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabLab1;
        private System.Windows.Forms.TabPage tabLab2;
        private System.Windows.Forms.TabPage tabLab3;
        private System.Windows.Forms.TabPage tabLab4;
        private System.Windows.Forms.TabPage tabLab5;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnBitwiseAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button btnTask1;
        private System.Windows.Forms.Button btnTask2;

        // ── новые поля: меню, статус-бар, журнал исключений ────────────────
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuConsoleVersion;
        private System.Windows.Forms.ToolStripSeparator menuFileSeparator;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuLabs;
        private System.Windows.Forms.ToolStripMenuItem menuLab1;
        private System.Windows.Forms.ToolStripMenuItem menuLab2;
        private System.Windows.Forms.ToolStripMenuItem menuLab3;
        private System.Windows.Forms.ToolStripMenuItem menuLab4;
        private System.Windows.Forms.ToolStripMenuItem menuLab5;

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusProcessLabel;
        private System.Windows.Forms.ToolStripStatusLabel statusProcessName;
        private System.Windows.Forms.ToolStripProgressBar statusProgress;
        private System.Windows.Forms.ToolStripStatusLabel statusDateTimeLabel;
        private System.Windows.Forms.ToolStripStatusLabel statusDateTime;

        private System.Windows.Forms.GroupBox grpGlobalLog;
        private System.Windows.Forms.TextBox txtGlobalExceptions;

        private System.Windows.Forms.Timer timerClock;
    }
}
