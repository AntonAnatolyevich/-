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
    public partial class StatOfice : Form
    {
        public StatOfice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.chart1.Series[0].Points.Clear();
            List<Student> students = new List<Student>();
            students = FileWork.Deserializer<Student>(FileWork.PathStudent);
            var groupPatients = students.GroupBy(p => p.Ofice)
                            .Select(g => new { Ofice = g.Key, Count = g.Count() });
            foreach (var group in groupPatients)
            {
                this.chart1.Series[0].Points.AddXY(group.Ofice, group.Count);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.chart2.Series[0].Points.Clear();
            List<Student> patients = new List<Student>();
            patients = FileWork.Deserializer<Student>(FileWork.PathStudent);
            var groupPatients = patients.GroupBy(p => p.DateOfAdd)
                            .Select(g => new { VDate = g.Key, Count = g.Count() });
            foreach (var group in groupPatients)
            {
                this.chart2.Series[0].Points.AddXY(group.VDate, group.Count);
            }
        }
    }
}
