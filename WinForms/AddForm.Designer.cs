
namespace WinForms
{
    partial class AddForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimeDateOfAdd = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimeBirthDay = new System.Windows.Forms.DateTimePicker();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.comboBoxSportType = new System.Windows.Forms.ComboBox();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxCoach = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxOfice = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Дата добавления";
            // 
            // dateTimeDateOfAdd
            // 
            this.dateTimeDateOfAdd.Location = new System.Drawing.Point(135, 222);
            this.dateTimeDateOfAdd.Name = "dateTimeDateOfAdd";
            this.dateTimeDateOfAdd.Size = new System.Drawing.Size(216, 20);
            this.dateTimeDateOfAdd.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Дата рождения";
            // 
            // dateTimeBirthDay
            // 
            this.dateTimeBirthDay.Location = new System.Drawing.Point(135, 88);
            this.dateTimeBirthDay.Name = "dateTimeBirthDay";
            this.dateTimeBirthDay.Size = new System.Drawing.Size(216, 20);
            this.dateTimeBirthDay.TabIndex = 28;
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Location = new System.Drawing.Point(135, 62);
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(216, 20);
            this.textBoxPatronymic.TabIndex = 27;
            // 
            // comboBoxSportType
            // 
            this.comboBoxSportType.FormattingEnabled = true;
            this.comboBoxSportType.Items.AddRange(new object[] {
            "Плавание",
            "Каратэ",
            "Дзюдо",
            "Самбо",
            "Футбол",
            "Хоккей"});
            this.comboBoxSportType.Location = new System.Drawing.Point(135, 141);
            this.comboBoxSportType.Name = "comboBoxSportType";
            this.comboBoxSportType.Size = new System.Drawing.Size(216, 21);
            this.comboBoxSportType.TabIndex = 26;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.comboBoxGender.Location = new System.Drawing.Point(135, 114);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(216, 21);
            this.comboBoxGender.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Вид спорта";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Пол:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Отчество:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Имя:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Фамилия:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(135, 36);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(216, 20);
            this.textBoxName.TabIndex = 19;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(135, 10);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(216, 20);
            this.textBoxSurname.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(377, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Тренер:";
            // 
            // comboBoxCoach
            // 
            this.comboBoxCoach.FormattingEnabled = true;
            this.comboBoxCoach.Items.AddRange(new object[] {
            "Колесникова Ника Егоровна",
            "Александрова Виктория Кирилловна",
            "Березина Ульяна Данииловна",
            "Ушаков Тимур Сергеевич",
            "Аникин Михаил Владиславович",
            "Рубцов Михаил Львович",
            "Белякова Елизавета Михайловна",
            "Галкина Анастасия Егоровна",
            "Мещеряков Кирилл Владимирович",
            "Глебова Марина Дмитриевна",
            "Новиков Иван Александрович",
            "Макеев Ярослав Даниилович",
            "Винокуров Даниил Михайлович",
            "Симонова Арина Максимовна",
            "Кириллов Максим Даниилович"});
            this.comboBoxCoach.Location = new System.Drawing.Point(135, 168);
            this.comboBoxCoach.Name = "comboBoxCoach";
            this.comboBoxCoach.Size = new System.Drawing.Size(216, 21);
            this.comboBoxCoach.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Филиал обучения";
            // 
            // comboBoxOfice
            // 
            this.comboBoxOfice.FormattingEnabled = true;
            this.comboBoxOfice.Items.AddRange(new object[] {
            "Плавательная секция",
            "Школа единоборств",
            "Секция по футболу и хоккею"});
            this.comboBoxOfice.Location = new System.Drawing.Point(135, 195);
            this.comboBoxOfice.Name = "comboBoxOfice";
            this.comboBoxOfice.Size = new System.Drawing.Size(216, 21);
            this.comboBoxOfice.TabIndex = 36;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 281);
            this.Controls.Add(this.comboBoxOfice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxCoach);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimeDateOfAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimeBirthDay);
            this.Controls.Add(this.textBoxPatronymic);
            this.Controls.Add(this.comboBoxSportType);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxSurname);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimeDateOfAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimeBirthDay;
        private System.Windows.Forms.TextBox textBoxPatronymic;
        private System.Windows.Forms.ComboBox comboBoxSportType;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxCoach;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxOfice;
    }
}