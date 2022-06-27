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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxSurname.Text.Length != 0 && textBoxSurname.Text.Length != 0 && comboBoxGender.SelectedItem != null && comboBoxSportType.SelectedItem != null)
            {
                FileWork.WriteFile(FileWork.AddStudent(FileWork.ReadFile<Student>(FileWork.PathStudent), textBoxSurname.Text,
                  textBoxName.Text,
                  textBoxPatronymic.Text,
                  dateTimeBirthDay.Value,
                  comboBoxSportType.Text,
                  comboBoxGender.Text,
                  comboBoxCoach.Text,
                  dateTimeDateOfAdd.Value,
                  comboBoxOfice.Text), FileWork.PathStudent);
                //textBoxSurname.Clear();
                //textBoxName.Clear();
                //textBoxPatronymic.Clear();
                //dateTimeBirthDay.Value = dateTimeDateOfAdd.MinDate;
                //comboBoxSportType.ResetText();
                //comboBoxGender.ResetText();
                //comboBoxCoach.ResetText();
                //comboBoxOfice.ResetText();
                //dateTimeDateOfAdd.Value = dateTimeDateOfAdd.MinDate;

            }

            else { MessageBox.Show("Заполните форму", "Ошибка", MessageBoxButtons.OK); }
        }
    }
}
