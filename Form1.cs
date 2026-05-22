using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        private void InitializeServices()
        {
            bitwiseService    = new BitwiseStringAdditionService();
            divisorService    = new DivisorCountService();
            pythagoreanService = new PythagoreanTriplesService();

            tabLab2.Controls.Add(new Lab2Panel());
            tabLab3.Controls.Add(new Lab3Panel());
            tabLab4.Controls.Add(new Lab4Panel());
            tabLab5.Controls.Add(new Lab5Panel());
        }

        private void btnBitwiseAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSurname.Text) || string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Пожалуйста, введите фамилию и имя!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string result = bitwiseService.Execute(txtSurname.Text, txtName.Text);
            txtOutput.Text = result;
        }

        private void btnTask1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtN.Text))
            {
                MessageBox.Show("Пожалуйста, введите количество делителей N!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string result = divisorService.Execute(txtN.Text);
            txtOutput.Text = result;
        }

        private void btnTask2_Click(object sender, EventArgs e)
        {
            string result = pythagoreanService.Execute();
            txtOutput.Text = result;
        }
    }
}
