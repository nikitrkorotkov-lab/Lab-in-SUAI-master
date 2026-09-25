using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using lab1forms.Services.Lab2;

namespace lab1forms.Services.Lab2
{
    public class Lab2Panel : UserControl
    {
        private const string LOG_PATH = "exceptions_log_lab2.txt";

        private double[] _D;
        private double[] _A;

        private DataGridView dgvD;
        private DataGridView dgvA;
        private TextBox      txtLog;
        private NumericUpDown nudSize;
        private NumericUpDown nudFreq;
        private NumericUpDown nudDisplayLimit; // требование п.5 — "первые N элементов"
        private Label        lblTimeNoThread;
        private Label        lblTimeThread;
        private Label        lblDisplayInfoD;
        private Label        lblDisplayInfoA;

        public Lab2Panel()
        {
            Dock = DockStyle.Fill;
            BuildUI();
        }

        private void BuildUI()
        {
            var grpFill = new GroupBox
            {
                Text    = "Шаг 1 — Заполнение массива D",
                Dock    = DockStyle.Top,
                Height  = 132,
                Padding = new Padding(10, 4, 10, 4)
            };

            var lblSize = new Label { Text = "Размер n:", Left = 8,   Top = 28, AutoSize = true };
            nudSize = new NumericUpDown { Left = 80, Top = 24, Width = 65,
                                          Minimum = 2, Maximum = 100000, Value = 10 };

            var lblFreq = new Label { Text = "Частота k:", Left = 162, Top = 28, AutoSize = true };
            nudFreq = new NumericUpDown { Left = 240, Top = 24, Width = 60,
                                          Minimum = 1, Maximum = 50, Value = 5 };

            var lblLimit = new Label { Text = "Показывать первых N элементов:", Left = 310, Top = 28, AutoSize = true };
            nudDisplayLimit = new NumericUpDown { Left = 555, Top = 24, Width = 80,
                                          Minimum = 1, Maximum = 100000, Value = 50 };
            nudDisplayLimit.ValueChanged += (s, e) => RefreshGridDisplays();

            var btnRandom     = MakeBtn("Случайно",          8,   60, 128);
            var btnFreqFill   = MakeBtn("По частоте k",      144, 60, 128);
            var btnReadManual = MakeBtn("✔ Принять вручную", 280, 60, 160);

            btnRandom.Click     += BtnRandom_Click;
            btnFreqFill.Click   += BtnFreqFill_Click;
            btnReadManual.Click += BtnReadManual_Click;

            lblDisplayInfoD = new Label { Left = 8, Top = 98, AutoSize = true, ForeColor = Color.DimGray,
                                          Text = "Массив D не сформирован." };

            grpFill.Controls.AddRange(new Control[]
                { lblSize, nudSize, lblFreq, nudFreq, lblLimit, nudDisplayLimit,
                  btnRandom, btnFreqFill, btnReadManual, lblDisplayInfoD });

            var grpProcess = new GroupBox
            {
                Text    = "Шаг 2 — Обработка",
                Dock    = DockStyle.Bottom,
                Height  = 100,
                Padding = new Padding(10, 4, 10, 4)
            };

            var btnNoThread = MakeBtn("▶ Без потоков",  8,   22, 138, Color.FromArgb(0, 90, 180));
            var btnThread   = MakeBtn("▶▶ С потоками", 155, 22, 138, Color.FromArgb(0, 130, 80));

            lblTimeNoThread = new Label { Text = "Без потоков: —",
                Left = 8,   Top = 58, AutoSize = true, ForeColor = Color.DarkBlue };
            lblTimeThread = new Label { Text = "С потоками:  —",
                Left = 320, Top = 58, AutoSize = true, ForeColor = Color.DarkGreen };
            lblDisplayInfoA = new Label { Left = 8, Top = 78, AutoSize = true, ForeColor = Color.DimGray,
                                          Text = "Массив A не сформирован." };

            btnNoThread.Click += BtnNoThread_Click;
            btnThread.Click   += BtnThread_Click;

            grpProcess.Controls.AddRange(new Control[]
                { btnNoThread, btnThread, lblTimeNoThread, lblTimeThread, lblDisplayInfoA });

            var grpLog = new GroupBox
            {
                Text    = string.Format("Журнал исключений  (файл: {0})", LOG_PATH),
                Dock    = DockStyle.Bottom,
                Height  = 135,
                Padding = new Padding(4)
            };

            txtLog = new TextBox
            {
                Multiline  = true,
                ScrollBars = ScrollBars.Vertical,
                ReadOnly   = true,
                Dock       = DockStyle.Fill,
                BackColor  = Color.FromArgb(24, 24, 28),
                ForeColor  = Color.LimeGreen,
                Font       = new Font("Consolas", 8.5f)
            };

            var btnClear = new Button { Text = "✕ Очистить", Dock = DockStyle.Bottom, Height = 24 };
            btnClear.Click += (s, e) => txtLog.Clear();

            grpLog.Controls.Add(txtLog);
            grpLog.Controls.Add(btnClear);

            dgvD = MakeGrid("D[i]", editable: true);
            dgvA = MakeGrid("A[i]", editable: false);

            var lblD = MakeGridHeader("Массив D (исходный):");
            var lblA = MakeGridHeader("Массив A (результат):");

            var split = new SplitContainer
            {
                Dock             = DockStyle.Fill,
                Orientation      = Orientation.Vertical,
                SplitterDistance = 460
            };
            split.Panel1.Controls.Add(dgvD);
            split.Panel1.Controls.Add(lblD);
            split.Panel2.Controls.Add(dgvA);
            split.Panel2.Controls.Add(lblA);

            var pnlCenter = new Panel { Dock = DockStyle.Fill };
            pnlCenter.Controls.Add(split);
            pnlCenter.Controls.Add(grpFill);

            Controls.Add(pnlCenter);
            Controls.Add(grpProcess);
            Controls.Add(grpLog);
        }

        private static Button MakeBtn(string text, int x, int y, int w, Color? bg = null)
        {
            var btn = new Button
            {
                Text      = text,
                Left      = x,
                Top       = y,
                Width     = w,
                Height    = 28,
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White
            };
            btn.BackColor = bg.HasValue ? bg.Value : Color.FromArgb(70, 70, 90);
            btn.FlatAppearance.BorderSize = 0;
            return btn;
        }

        private static DataGridView MakeGrid(string header, bool editable)
        {
            var dgv = new DataGridView
            {
                Dock                  = DockStyle.Fill,
                ColumnCount           = 1,
                RowHeadersWidth       = 46,
                AllowUserToAddRows    = editable,
                AllowUserToDeleteRows = editable,
                ReadOnly              = !editable,
                AutoSizeColumnsMode   = DataGridViewAutoSizeColumnsMode.Fill,
                SelectionMode         = DataGridViewSelectionMode.CellSelect,
                BorderStyle           = BorderStyle.None
            };
            dgv.Columns[0].HeaderText = header;
            dgv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            return dgv;
        }

        private static Label MakeGridHeader(string text)
        {
            return new Label
            {
                Text      = text,
                Dock      = DockStyle.Top,
                Height    = 22,
                TextAlign = ContentAlignment.MiddleLeft,
                Font      = new Font("Segoe UI", 9f, FontStyle.Bold),
                ForeColor = Color.FromArgb(50, 50, 100)
            };
        }

        private void BtnRandom_Click(object sender, EventArgs e)
        {
            try
            {
                AppStatus.Report("Лаб.2: случайное заполнение массива D", -1);
                int n = (int)nudSize.Value;
                var rnd = new Random();
                _D = new double[n];
                for (int i = 0; i < n; i++)
                    _D[i] = rnd.Next(-50, 51);
                FillGridLimited(dgvD, _D, lblDisplayInfoD, "D");
            }
            catch (Exception ex) { LogException(ex); }
            finally { AppStatus.Idle(); }
        }

        private void BtnFreqFill_Click(object sender, EventArgs e)
        {
            try
            {
                AppStatus.Report("Лаб.2: заполнение массива D по частоте", -1);
                int n    = (int)nudSize.Value;
                int freq = (int)nudFreq.Value;
                var rnd  = new Random();
                _D = new double[n];
                for (int i = 0; i < n; i++)
                    _D[i] = rnd.Next(-50 / freq, 51 / freq) * (double)freq;
                FillGridLimited(dgvD, _D, lblDisplayInfoD, "D");
            }
            catch (Exception ex) { LogException(ex); }
            finally { AppStatus.Idle(); }
        }

        private void BtnReadManual_Click(object sender, EventArgs e)
        {
            try
            {
                _D = ReadGrid(dgvD);
                lblDisplayInfoD.Text = string.Format("Массив D принят вручную: {0} элементов.", _D.Length);
                MessageBox.Show(string.Format("Принято {0} элементов.", _D.Length), "Готово",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { LogException(ex); }
        }

        private void BtnNoThread_Click(object sender, EventArgs e)
        {
            try
            {
                RequireD();
                AppStatus.Report("Лаб.2: обработка массива (без потоков)", -1);
                var sw = Stopwatch.StartNew();
                _A = Lab2Service.ProcessSequential(_D);
                sw.Stop();
                lblTimeNoThread.Text = string.Format(
                    "Без потоков: {0} тик.  /  {1:F4} мс",
                    sw.ElapsedTicks, sw.Elapsed.TotalMilliseconds);
                FillGridLimited(dgvA, _A, lblDisplayInfoA, "A");
            }
            catch (Exception ex) { LogException(ex); }
            finally { AppStatus.Idle(); }
        }

        private void BtnThread_Click(object sender, EventArgs e)
        {
            try
            {
                RequireD();
                AppStatus.Report("Лаб.2: обработка массива (с потоками)", -1);
                var sw = Stopwatch.StartNew();
                _A = Lab2Service.ProcessThreaded(_D);
                sw.Stop();
                lblTimeThread.Text = string.Format(
                    "С потоками:  {0} тик.  /  {1:F4} мс",
                    sw.ElapsedTicks, sw.Elapsed.TotalMilliseconds);
                FillGridLimited(dgvA, _A, lblDisplayInfoA, "A");
            }
            catch (Exception ex) { LogException(ex); }
            finally { AppStatus.Idle(); }
        }

        private void RequireD()
        {
            if (_D == null || _D.Length == 0)
                throw new InvalidOperationException(
                    "Массив D не задан. Сначала заполните его одним из трёх способов.");
        }

        private void RefreshGridDisplays()
        {
            if (_D != null) FillGridLimited(dgvD, _D, lblDisplayInfoD, "D");
            if (_A != null) FillGridLimited(dgvA, _A, lblDisplayInfoA, "A");
        }

        private void FillGridLimited(DataGridView dgv, double[] arr, Label infoLabel, string arrayName)
        {
            int limit = (int)nudDisplayLimit.Value;
            int shown = Math.Min(arr.Length, limit);

            dgv.Rows.Clear();
            for (int i = 0; i < shown; i++)
            {
                dgv.Rows.Add(arr[i].ToString("F4", CultureInfo.InvariantCulture));
                dgv.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }

            infoLabel.Text = arr.Length > limit
                ? string.Format("Массив {0}: показано первых {1} из {2} элементов (измените N выше, чтобы показать больше).", arrayName, shown, arr.Length)
                : string.Format("Массив {0}: показаны все {1} элементов.", arrayName, arr.Length);
        }

        private static double[] ReadGrid(DataGridView dgv)
        {
            int n = dgv.Rows.Count - 1;
            if (n <= 0)
                throw new InvalidOperationException(
                    "Таблица D пуста. Введите значения вручную и нажмите «Принять».");

            var arr = new double[n];
            for (int i = 0; i < n; i++)
            {
                string raw = dgv.Rows[i].Cells[0].Value != null
                    ? dgv.Rows[i].Cells[0].Value.ToString()
                    : string.Empty;
                if (!double.TryParse(raw, NumberStyles.Any,
                                     CultureInfo.InvariantCulture, out arr[i]))
                    throw new FormatException(
                        string.Format("Строка {0}: «{1}» — некорректное число.", i + 1, raw));
            }
            return arr;
        }

        private void LogException(Exception ex)
        {
            string entry =
                string.Format("[{0:dd.MM.yyyy HH:mm:ss}]  {1}: {2}\nStack:\n{3}\n{4}\n",
                    DateTime.Now, ex.GetType().Name, ex.Message, ex.StackTrace,
                    new string('─', 64));

            void Append() => txtLog.AppendText(entry + Environment.NewLine);

            if (txtLog.InvokeRequired) txtLog.Invoke((Action)Append);
            else Append();

            try { File.AppendAllText(LOG_PATH, entry); }
            catch { }

            ExceptionLogger.LogException(ex);
        }
    }
}
