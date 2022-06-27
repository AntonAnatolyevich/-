using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SportSchool;

namespace WinForms
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddForm newForm = new AddForm();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteForm newForm = new DeleteForm();
            newForm.Show();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileWork.DeleteFile(FileWork.PathStudent);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StatCoach newForm = new StatCoach();
            newForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StatStudent newForm = new StatStudent();
            newForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StatOfice newForm = new StatOfice();
            newForm.Show();
        }
    }
}
