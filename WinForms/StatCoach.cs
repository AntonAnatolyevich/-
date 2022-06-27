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
    public partial class StatCoach : Form
    {
        public StatCoach()
        {
            InitializeComponent();
            List<string> coaches = StatOperations.AddCoaches();
            comboBoxCoaches.DataSource = coaches;
            List<string> sporttypes = StatOperations.AddSpotTypes();
            comboBoxSportType.DataSource = sporttypes;
            comboBoxCoaches.DataSource = coaches;
            textBoxCountOfStudents.Text = StatOperations.CountStudetnsCoach(comboBoxCoaches.Text, comboBoxSportType.Text);
        }

        private void comboBoxSportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxCountOfStudents.Text = StatOperations.CountStudetnsCoach(comboBoxCoaches.Text, comboBoxSportType.Text);
        }

        private void comboBoxCoaches_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxCountOfStudents.Text = StatOperations.CountStudetnsCoach(comboBoxCoaches.Text, comboBoxSportType.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.chart1.Series[0].Points.Clear();
            //var groupGoldMedals = StatOperations.CountChart();
            //foreach (ValueTuple group in groupGoldMedals)
            //{
            //    this.chart1.Series[0].Points.AddXY(group.Coach, group.Count);
            //}

            this.chart1.Series[0].Points.Clear();
            List<Student> students = new List<Student>();
            students = FileWork.Deserializer<Student>(FileWork.PathStudent);
            var groupGold = students.GroupBy(p => p.Coach)
                                        .Select(g => new { Coach = g.Key, Count = g.Count() });
            foreach (var group in groupGold)
            {
                this.chart1.Series[0].Points.AddXY(group.Coach, group.Count);
            }
        }
    }
}
