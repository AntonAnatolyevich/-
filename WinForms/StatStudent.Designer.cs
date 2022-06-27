
namespace WinForms
{
    partial class StatStudent
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
            this.dataGridViewMedalSort = new System.Windows.Forms.DataGridView();
            this.comboBoxMedalTypes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewCountOfMedal = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedalSort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountOfMedal)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMedalSort
            // 
            this.dataGridViewMedalSort.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMedalSort.Location = new System.Drawing.Point(15, 49);
            this.dataGridViewMedalSort.Name = "dataGridViewMedalSort";
            this.dataGridViewMedalSort.Size = new System.Drawing.Size(860, 700);
            this.dataGridViewMedalSort.TabIndex = 0;
            // 
            // comboBoxMedalTypes
            // 
            this.comboBoxMedalTypes.FormattingEnabled = true;
            this.comboBoxMedalTypes.Location = new System.Drawing.Point(108, 12);
            this.comboBoxMedalTypes.Name = "comboBoxMedalTypes";
            this.comboBoxMedalTypes.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMedalTypes.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Сортировать по ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 21);
            this.button1.TabIndex = 4;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewCountOfMedal
            // 
            this.dataGridViewCountOfMedal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCountOfMedal.Location = new System.Drawing.Point(932, 49);
            this.dataGridViewCountOfMedal.Name = "dataGridViewCountOfMedal";
            this.dataGridViewCountOfMedal.Size = new System.Drawing.Size(660, 700);
            this.dataGridViewCountOfMedal.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(929, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Список медалистов";
            // 
            // StatStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 761);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewCountOfMedal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxMedalTypes);
            this.Controls.Add(this.dataGridViewMedalSort);
            this.Name = "StatStudent";
            this.Text = "StatStudent";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedalSort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountOfMedal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMedalSort;
        private System.Windows.Forms.ComboBox comboBoxMedalTypes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewCountOfMedal;
        private System.Windows.Forms.Label label2;
    }
}