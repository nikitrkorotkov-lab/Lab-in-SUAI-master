using System;
using System.Windows.Forms;
using lab1forms.Services.Lab1;
using lab1forms.Services.Lab2;
using lab1forms.Services.Lab3;
using lab1forms.Services.Lab4;
using lab1forms.Services.Lab5;

namespace lab1forms
{
    public partial class Form1 : Form
    {
        private BitwiseStringAdditionService bitwiseService;
        private DivisorCountService divisorService;
        private PythagoreanTriplesService pythagoreanService;

        public Form1()
        {
            InitializeComponent();
            InitializeServices();
            InitializeExceptionLogging();
            InitializeStatusBar();
            InitializeMainMenu();
        }

        private void InitializeServices()
        {
            bitwiseService     = new BitwiseStringAdditionService();
            divisorService     = new DivisorCountService();
            pythagoreanService = new PythagoreanTriplesService();

            tabLab2.Controls.Add(new Lab2Panel());
            tabLab3.Controls.Add(new Lab3Panel());
            tabLab4.Controls.Add(new Lab4Panel());
            tabLab5.Controls.Add(new Lab5Panel());
        }

        /// <summary>Требование п.1: обработанные исключения фиксируются на главной
        /// форме в TextBox и в текстовом файле с датой/временем, сообщением и стеком.</summary>
        private void InitializeExceptionLogging()
        {
            ExceptionLogger.Initialize(txtGlobalExceptions, "exceptions_log.txt");
        }

        /// <summary>Требование п.3: строка статуса с индикатором процесса,
        /// его наименованием и текущими системными датой/временем.</summary>
        private void InitializeStatusBar()
        {
            AppStatus.Changed += OnAppStatusChanged;

            timerClock.Interval = 1000;
            timerClock.Tick += (s, e) =>
                statusDateTime.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
            timerClock.Start();
            statusDateTime.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");

            statusProcessName.Text = "Ожидание";
            statusProgress.Style = ProgressBarStyle.Continuous;
            statusProgress.Value = 0;
        }

        private void OnAppStatusChanged(string processName, int percent)
        {
            void Update()
            {
                statusProcessName.Text = processName;
                if (percent < 0)
                {
                    statusProgress.Style = ProgressBarStyle.Marquee;
                }
                else
                {
                    statusProgress.Style = ProgressBarStyle.Continuous;
                    statusProgress.Value = Math.Max(0, Math.Min(100, percent));
                }
            }

            if (IsDisposed) return;
            if (InvokeRequired) BeginInvoke((Action)Update);
            else Update();
        }

        /// <summary>Требование п.3: навигация по формам лабораторных работ
        /// выполняется через главное меню (MenuStrip), а не только через вкладки.</summary>
        private void InitializeMainMenu()
        {
            menuLab1.Click += (s, e) => tabControl.SelectedTab = tabLab1;
            menuLab2.Click += (s, e) => tabControl.SelectedTab = tabLab2;
            menuLab3.Click += (s, e) => tabControl.SelectedTab = tabLab3;
            menuLab4.Click += (s, e) => tabControl.SelectedTab = tabLab4;
            menuLab5.Click += (s, e) => tabControl.SelectedTab = tabLab5;

            menuExit.Click += (s, e) => Close();

            // Подключение консольной версии ЛР1 (ConsoleApp.cs) к работающему приложению
            menuConsoleVersion.Click += (s, e) =>
            {
                try
                {
                    AppStatus.Report("Консольная версия ЛР1", -1);
                    Hide();
                    ConsoleApp.Run();
                }
                catch (Exception ex)
                {
                    ExceptionLogger.LogException(ex);
                }
                finally
                {
                    AppStatus.Idle();
                    Show();
                }
            };
        }

        private void btnBitwiseAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSurname.Text) || string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Пожалуйста, введите фамилию и имя!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                AppStatus.Report("Лаб.1: поразрядное сложение строк", -1);
                string result = bitwiseService.Execute(txtSurname.Text, txtName.Text);
                txtOutput.Text = result;
            }
            catch (Exception ex)
            {
                ExceptionLogger.LogException(ex);
            }
            finally
            {
                AppStatus.Idle();
            }
        }

        private void btnTask1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtN.Text))
                {
                    MessageBox.Show("Пожалуйста, введите количество делителей N!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                AppStatus.Report("Лаб.1: поиск чисел с N делителями", -1);
                string result = divisorService.Execute(txtN.Text);
                txtOutput.Text = result;
            }
            catch (Exception ex)
            {
                ExceptionLogger.LogException(ex);
            }
            finally
            {
                AppStatus.Idle();
            }
        }

        private void btnTask2_Click(object sender, EventArgs e)
        {
            try
            {
                AppStatus.Report("Лаб.1: поиск троек A + B² = C²", -1);
                string result = pythagoreanService.Execute();
                txtOutput.Text = result;
            }
            catch (Exception ex)
            {
                ExceptionLogger.LogException(ex);
            }
            finally
            {
                AppStatus.Idle();
            }
        }
    }
}
