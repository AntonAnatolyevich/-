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
    public partial class StatStudent : Form
    {
        public StatStudent()
        {
            InitializeComponent();
            List<string> typemedals = StatOperations.AddMedalTypes();
            comboBoxMedalTypes.DataSource = typemedals;
            dataGridViewMedalSort.DataSource = StatOperations.SortByMedals(comboBoxMedalTypes.Text);           
            dataGridViewMedalSort.Columns["BirthDate"].Visible = false;
            dataGridViewMedalSort.Columns["Coach"].Visible = false;
            dataGridViewMedalSort.Columns["DateOfAdd"].Visible = false;
            dataGridViewMedalSort.Columns["Index"].Visible = false;
            dataGridViewMedalSort.Columns["Ofice"].Visible = false;
            dataGridViewMedalSort.Columns["IndexInfo"].Visible = false;
            dataGridViewMedalSort.Columns["ViewInfo"].Visible = false;
            dataGridViewMedalSort.Columns["MedalsCount"].Visible = false;

            dataGridViewCountOfMedal.DataSource = StatOperations.SortByCountOfMedals();
            dataGridViewCountOfMedal.Columns["BirthDate"].Visible = false;
            dataGridViewCountOfMedal.Columns["Coach"].Visible = false;
            dataGridViewCountOfMedal.Columns["GoldPlaces"].Visible = false;
            dataGridViewCountOfMedal.Columns["SilverPlaces"].Visible = false;
            dataGridViewCountOfMedal.Columns["BronzePlaces"].Visible = false;
            dataGridViewCountOfMedal.Columns["DateOfAdd"].Visible = false;
            dataGridViewCountOfMedal.Columns["Index"].Visible = false;
            dataGridViewCountOfMedal.Columns["Ofice"].Visible = false;
            dataGridViewCountOfMedal.Columns["IndexInfo"].Visible = false;
            dataGridViewCountOfMedal.Columns["ViewInfo"].Visible = false;
            
        }
        private void comboBoxCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewMedalSort.DataSource = StatOperations.SortByMedals(comboBoxMedalTypes.Text);      
            dataGridViewMedalSort.Columns["BirthDate"].Visible = false;
            dataGridViewMedalSort.Columns["Coach"].Visible = false;
            dataGridViewMedalSort.Columns["DateOfAdd"].Visible = false;
            dataGridViewMedalSort.Columns["Index"].Visible = false;
            dataGridViewMedalSort.Columns["Ofice"].Visible = false;
            dataGridViewMedalSort.Columns["IndexInfo"].Visible = false;
            dataGridViewMedalSort.Columns["ViewInfo"].Visible = false;
            dataGridViewMedalSort.Columns["MedalsCount"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewMedalSort.DataSource = null;
            dataGridViewMedalSort.DataSource = StatOperations.SortByMedals(comboBoxMedalTypes.Text);
            dataGridViewMedalSort.Columns["BirthDate"].Visible = false;
            dataGridViewMedalSort.Columns["Coach"].Visible = false;
            dataGridViewMedalSort.Columns["DateOfAdd"].Visible = false;
            dataGridViewMedalSort.Columns["Index"].Visible = false;
            dataGridViewMedalSort.Columns["Ofice"].Visible = false;
            dataGridViewMedalSort.Columns["IndexInfo"].Visible = false;
            dataGridViewMedalSort.Columns["ViewInfo"].Visible = false;
            dataGridViewMedalSort.Columns["MedalsCount"].Visible = false;
        }
    }
}
