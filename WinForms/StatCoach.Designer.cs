
namespace WinForms
{
    partial class StatCoach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.comboBoxSportType = new System.Windows.Forms.ComboBox();
            this.comboBoxCoaches = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCountOfStudents = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSportType
            // 
            this.comboBoxSportType.FormattingEnabled = true;
            this.comboBoxSportType.Location = new System.Drawing.Point(12, 25);
            this.comboBoxSportType.Name = "comboBoxSportType";
            this.comboBoxSportType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSportType.TabIndex = 0;
            this.comboBoxSportType.SelectedIndexChanged += new System.EventHandler(this.comboBoxSportType_SelectedIndexChanged);
            // 
            // comboBoxCoaches
            // 
            this.comboBoxCoaches.FormattingEnabled = true;
            this.comboBoxCoaches.Location = new System.Drawing.Point(139, 25);
            this.comboBoxCoaches.Name = "comboBoxCoaches";
            this.comboBoxCoaches.Size = new System.Drawing.Size(220, 21);
            this.comboBoxCoaches.TabIndex = 1;
            this.comboBoxCoaches.SelectedIndexChanged += new System.EventHandler(this.comboBoxCoaches_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выбирете вид спорта и тренера для просмотра занимающихся учеников";
            // 
            // textBoxCountOfStudents
            // 
            this.textBoxCountOfStudents.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxCountOfStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCountOfStudents.Location = new System.Drawing.Point(174, 60);
            this.textBoxCountOfStudents.Name = "textBoxCountOfStudents";
            this.textBoxCountOfStudents.Size = new System.Drawing.Size(24, 20);
            this.textBoxCountOfStudents.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Всего у тренера занимается ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "учеников";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(15, 125);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Золотые медалисты";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1460, 630);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Количество золотых медалистов у тренеров\r\n\r\n";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 8;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StatCoach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCountOfStudents);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCoaches);
            this.Controls.Add(this.comboBoxSportType);
            this.Name = "StatCoach";
            this.Text = "StatCoach";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSportType;
        private System.Windows.Forms.ComboBox comboBoxCoaches;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCountOfStudents;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}