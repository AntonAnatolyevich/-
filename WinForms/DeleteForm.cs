using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SportSchool;


namespace WinForms
{
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
            if (File.Exists(FileWork.PathStudent))
            {
                List<Student> student = new List<Student>();
                student = FileWork.Deserializer<Student>(FileWork.PathStudent);
                listBoxStudents.DataSource = student;
                listBoxStudents.DisplayMember = "ViewInfo";
                listBoxStudents.ValueMember = "IndexInfo";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //List<Dictionary<Student, DateTime>> InfoList = new List<Dictionary<Student, DateTime>>();
            //Dictionary<Student, DateTime> deleteStudent = new Dictionary<Student, DateTime>();

            //List<Student> deleteStudent = new List<Student>();
            //deleteStudent = FileWork.Deserializer<Student>(FileWork.PathDeleteStudent);

            List <Student> student = new List<Student>();
            student = FileWork.Deserializer<Student>(FileWork.PathStudent);
            string id = (string)listBoxStudents.SelectedValue;
            Student delStudent = student.Find(x => x.IndexInfo == id);
            //deleteStudent.Add(delStudent, DateTime.Now);
            /*InfoList.Add(deleteStudent)*/;
            student.Remove(delStudent);
            //File.WriteAllText(FileWork.PathDeleteStudent, FileWork.Serializer<Dictionary<Student, DateTime>>(InfoList));
            File.WriteAllText(FileWork.PathStudent, FileWork.Serializer<Student>(student));
            listBoxStudents.DataSource = student;
            listBoxStudents.DisplayMember = "ViewInfo";
            listBoxStudents.ValueMember = "IndexInfo";
        }
    }
}
