namespace LogParser
{
    partial class MainWindow
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.OpenFile_button = new System.Windows.Forms.Button();
            this.FileName_TextBox = new System.Windows.Forms.TextBox();
            this.Previw_TextBox = new System.Windows.Forms.TextBox();
            this.Preview_button = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.LinesCount_comboBox = new System.Windows.Forms.ComboBox();
            this.OpenFolder_button = new System.Windows.Forms.Button();
            this.LineNum_checkBox = new System.Windows.Forms.CheckBox();
            this.LineTime_checkBox = new System.Windows.Forms.CheckBox();
            this.DoubleCutting_checkBox = new System.Windows.Forms.CheckBox();
            this.TabArrange_checkBox = new System.Windows.Forms.CheckBox();
            this.CsvOut_checkBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LinesNumPre_checkBox = new System.Windows.Forms.CheckBox();
            this.Preview_checkBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PrefixRead_textBox = new System.Windows.Forms.TextBox();
            this.RWtext_checkBox = new System.Windows.Forms.CheckBox();
            this.Postix_textBox = new System.Windows.Forms.TextBox();
            this.PrefixWrite_textBox = new System.Windows.Forms.TextBox();
            this.Prefix_checkBox = new System.Windows.Forms.CheckBox();
            this.CsvOutTab_comboBox = new System.Windows.Forms.ComboBox();
            this.pb1 = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LinesOffCnt_textBox = new System.Windows.Forms.TextBox();
            this.LinesRead_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LinesOutCnt_textBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenFile_button
            // 
            this.OpenFile_button.Location = new System.Drawing.Point(593, 18);
            this.OpenFile_button.Name = "OpenFile_button";
            this.OpenFile_button.Size = new System.Drawing.Size(99, 23);
            this.OpenFile_button.TabIndex = 0;
            this.OpenFile_button.Text = "Файл";
            this.OpenFile_button.UseVisualStyleBackColor = true;
            this.OpenFile_button.Click += new System.EventHandler(this.OpenFile_button_Click);
            // 
            // FileName_TextBox
            // 
            this.FileName_TextBox.Location = new System.Drawing.Point(186, 15);
            this.FileName_TextBox.Name = "FileName_TextBox";
            this.FileName_TextBox.ReadOnly = true;
            this.FileName_TextBox.Size = new System.Drawing.Size(126, 20);
            this.FileName_TextBox.TabIndex = 1;
            // 
            // Previw_TextBox
            // 
            this.Previw_TextBox.Location = new System.Drawing.Point(10, 255);
            this.Previw_TextBox.Multiline = true;
            this.Previw_TextBox.Name = "Previw_TextBox";
            this.Previw_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Previw_TextBox.Size = new System.Drawing.Size(682, 323);
            this.Previw_TextBox.TabIndex = 2;
            this.Previw_TextBox.Text = resources.GetString("Previw_TextBox.Text");
            // 
            // Preview_button
            // 
            this.Preview_button.Enabled = false;
            this.Preview_button.Location = new System.Drawing.Point(593, 90);
            this.Preview_button.Name = "Preview_button";
            this.Preview_button.Size = new System.Drawing.Size(99, 23);
            this.Preview_button.TabIndex = 3;
            this.Preview_button.Text = "Просмотр";
            this.Preview_button.UseVisualStyleBackColor = true;
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(11, 555);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(683, 23);
            this.Save_button.TabIndex = 5;
            this.Save_button.Text = "Сохранить";
            this.Save_button.UseVisualStyleBackColor = true;
            // 
            // LinesCount_comboBox
            // 
            this.LinesCount_comboBox.FormattingEnabled = true;
            this.LinesCount_comboBox.Items.AddRange(new object[] {
            "10",
            "20",
            "50",
            "100",
            "500",
            "1000"});
            this.LinesCount_comboBox.Location = new System.Drawing.Point(191, 40);
            this.LinesCount_comboBox.Name = "LinesCount_comboBox";
            this.LinesCount_comboBox.Size = new System.Drawing.Size(59, 21);
            this.LinesCount_comboBox.TabIndex = 7;
            this.LinesCount_comboBox.Text = "100";
            // 
            // OpenFolder_button
            // 
            this.OpenFolder_button.Enabled = false;
            this.OpenFolder_button.Location = new System.Drawing.Point(593, 48);
            this.OpenFolder_button.Name = "OpenFolder_button";
            this.OpenFolder_button.Size = new System.Drawing.Size(99, 23);
            this.OpenFolder_button.TabIndex = 8;
            this.OpenFolder_button.Text = "Открыть папку";
            this.OpenFolder_button.UseVisualStyleBackColor = true;
            this.OpenFolder_button.Click += new System.EventHandler(this.OpenFolder_button_Click);
            // 
            // LineNum_checkBox
            // 
            this.LineNum_checkBox.AutoSize = true;
            this.LineNum_checkBox.Location = new System.Drawing.Point(141, 36);
            this.LineNum_checkBox.Name = "LineNum_checkBox";
            this.LineNum_checkBox.Size = new System.Drawing.Size(98, 17);
            this.LineNum_checkBox.TabIndex = 9;
            this.LineNum_checkBox.Text = "Номер строки";
            this.LineNum_checkBox.UseVisualStyleBackColor = true;
            // 
            // LineTime_checkBox
            // 
            this.LineTime_checkBox.AutoSize = true;
            this.LineTime_checkBox.Location = new System.Drawing.Point(6, 53);
            this.LineTime_checkBox.Name = "LineTime_checkBox";
            this.LineTime_checkBox.Size = new System.Drawing.Size(59, 17);
            this.LineTime_checkBox.TabIndex = 10;
            this.LineTime_checkBox.Text = "Время";
            this.LineTime_checkBox.UseVisualStyleBackColor = true;
            // 
            // DoubleCutting_checkBox
            // 
            this.DoubleCutting_checkBox.AutoSize = true;
            this.DoubleCutting_checkBox.Checked = true;
            this.DoubleCutting_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DoubleCutting_checkBox.Location = new System.Drawing.Point(6, 19);
            this.DoubleCutting_checkBox.Name = "DoubleCutting_checkBox";
            this.DoubleCutting_checkBox.Size = new System.Drawing.Size(129, 17);
            this.DoubleCutting_checkBox.TabIndex = 11;
            this.DoubleCutting_checkBox.Text = "Сокращать повторы";
            this.DoubleCutting_checkBox.UseVisualStyleBackColor = true;
            // 
            // TabArrange_checkBox
            // 
            this.TabArrange_checkBox.AutoSize = true;
            this.TabArrange_checkBox.Checked = true;
            this.TabArrange_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TabArrange_checkBox.Location = new System.Drawing.Point(6, 36);
            this.TabArrange_checkBox.Name = "TabArrange_checkBox";
            this.TabArrange_checkBox.Size = new System.Drawing.Size(134, 17);
            this.TabArrange_checkBox.TabIndex = 12;
            this.TabArrange_checkBox.Text = "Смещать табуляцией";
            this.TabArrange_checkBox.UseVisualStyleBackColor = true;
            this.TabArrange_checkBox.CheckedChanged += new System.EventHandler(this.TabArrange_checkBox_CheckedChanged);
            // 
            // CsvOut_checkBox
            // 
            this.CsvOut_checkBox.AutoSize = true;
            this.CsvOut_checkBox.Enabled = false;
            this.CsvOut_checkBox.Location = new System.Drawing.Point(141, 53);
            this.CsvOut_checkBox.Name = "CsvOut_checkBox";
            this.CsvOut_checkBox.Size = new System.Drawing.Size(82, 17);
            this.CsvOut_checkBox.TabIndex = 13;
            this.CsvOut_checkBox.Text = "CSV вывод";
            this.CsvOut_checkBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LinesNumPre_checkBox);
            this.groupBox1.Controls.Add(this.Preview_checkBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LinesCount_comboBox);
            this.groupBox1.Location = new System.Drawing.Point(11, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 89);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Предпросмотр";
            // 
            // LinesNumPre_checkBox
            // 
            this.LinesNumPre_checkBox.AutoSize = true;
            this.LinesNumPre_checkBox.Checked = true;
            this.LinesNumPre_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LinesNumPre_checkBox.Location = new System.Drawing.Point(152, 17);
            this.LinesNumPre_checkBox.Name = "LinesNumPre_checkBox";
            this.LinesNumPre_checkBox.Size = new System.Drawing.Size(98, 17);
            this.LinesNumPre_checkBox.TabIndex = 23;
            this.LinesNumPre_checkBox.Text = "Номера строк";
            this.LinesNumPre_checkBox.UseVisualStyleBackColor = true;
            // 
            // Preview_checkBox
            // 
            this.Preview_checkBox.AutoSize = true;
            this.Preview_checkBox.Checked = true;
            this.Preview_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Preview_checkBox.Location = new System.Drawing.Point(8, 19);
            this.Preview_checkBox.Name = "Preview_checkBox";
            this.Preview_checkBox.Size = new System.Drawing.Size(101, 17);
            this.Preview_checkBox.TabIndex = 22;
            this.Preview_checkBox.Text = "Предпросмотр";
            this.Preview_checkBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Количество строк предпросмотра";
            // 
            // PrefixRead_textBox
            // 
            this.PrefixRead_textBox.Location = new System.Drawing.Point(97, 61);
            this.PrefixRead_textBox.Name = "PrefixRead_textBox";
            this.PrefixRead_textBox.Size = new System.Drawing.Size(126, 20);
            this.PrefixRead_textBox.TabIndex = 22;
            this.PrefixRead_textBox.Text = "TC358870_i2c_Read(";
            // 
            // RWtext_checkBox
            // 
            this.RWtext_checkBox.AutoSize = true;
            this.RWtext_checkBox.Location = new System.Drawing.Point(141, 19);
            this.RWtext_checkBox.Name = "RWtext_checkBox";
            this.RWtext_checkBox.Size = new System.Drawing.Size(76, 17);
            this.RWtext_checkBox.TabIndex = 21;
            this.RWtext_checkBox.Text = "RW текст";
            this.RWtext_checkBox.UseVisualStyleBackColor = true;
            // 
            // Postix_textBox
            // 
            this.Postix_textBox.Location = new System.Drawing.Point(97, 85);
            this.Postix_textBox.Name = "Postix_textBox";
            this.Postix_textBox.Size = new System.Drawing.Size(126, 20);
            this.Postix_textBox.TabIndex = 17;
            this.Postix_textBox.Text = ");";
            // 
            // PrefixWrite_textBox
            // 
            this.PrefixWrite_textBox.Location = new System.Drawing.Point(97, 36);
            this.PrefixWrite_textBox.Name = "PrefixWrite_textBox";
            this.PrefixWrite_textBox.Size = new System.Drawing.Size(126, 20);
            this.PrefixWrite_textBox.TabIndex = 15;
            this.PrefixWrite_textBox.Text = "TC358870_i2c_Write(";
            // 
            // Prefix_checkBox
            // 
            this.Prefix_checkBox.AutoSize = true;
            this.Prefix_checkBox.Checked = true;
            this.Prefix_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Prefix_checkBox.Location = new System.Drawing.Point(13, 15);
            this.Prefix_checkBox.Name = "Prefix_checkBox";
            this.Prefix_checkBox.Size = new System.Drawing.Size(72, 17);
            this.Prefix_checkBox.TabIndex = 16;
            this.Prefix_checkBox.Text = "Префикс";
            this.Prefix_checkBox.UseVisualStyleBackColor = true;
            // 
            // CsvOutTab_comboBox
            // 
            this.CsvOutTab_comboBox.Enabled = false;
            this.CsvOutTab_comboBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CsvOutTab_comboBox.FormattingEnabled = true;
            this.CsvOutTab_comboBox.Items.AddRange(new object[] {
            ",",
            ";",
            ":"});
            this.CsvOutTab_comboBox.Location = new System.Drawing.Point(245, 49);
            this.CsvOutTab_comboBox.Name = "CsvOutTab_comboBox";
            this.CsvOutTab_comboBox.Size = new System.Drawing.Size(36, 26);
            this.CsvOutTab_comboBox.TabIndex = 14;
            this.CsvOutTab_comboBox.Text = ";";
            // 
            // pb1
            // 
            this.pb1.ForeColor = System.Drawing.Color.Chartreuse;
            this.pb1.Location = new System.Drawing.Point(11, 226);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(681, 23);
            this.pb1.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.PrefixRead_textBox);
            this.groupBox2.Controls.Add(this.Prefix_checkBox);
            this.groupBox2.Controls.Add(this.Postix_textBox);
            this.groupBox2.Controls.Add(this.PrefixWrite_textBox);
            this.groupBox2.Location = new System.Drawing.Point(335, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 109);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Префиксы";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Окончание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Префикс Write";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Префикс Read";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RWtext_checkBox);
            this.groupBox3.Controls.Add(this.CsvOutTab_comboBox);
            this.groupBox3.Controls.Add(this.DoubleCutting_checkBox);
            this.groupBox3.Controls.Add(this.CsvOut_checkBox);
            this.groupBox3.Controls.Add(this.LineNum_checkBox);
            this.groupBox3.Controls.Add(this.TabArrange_checkBox);
            this.groupBox3.Controls.Add(this.LineTime_checkBox);
            this.groupBox3.Location = new System.Drawing.Point(335, 129);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(357, 80);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Вывод";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.LinesOffCnt_textBox);
            this.groupBox4.Controls.Add(this.FileName_TextBox);
            this.groupBox4.Controls.Add(this.LinesRead_textBox);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.LinesOutCnt_textBox);
            this.groupBox4.Location = new System.Drawing.Point(11, 100);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(318, 109);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Статистика";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Строк прочитано";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Имя файла";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Строк пропущено";
            // 
            // LinesOffCnt_textBox
            // 
            this.LinesOffCnt_textBox.Location = new System.Drawing.Point(186, 83);
            this.LinesOffCnt_textBox.Name = "LinesOffCnt_textBox";
            this.LinesOffCnt_textBox.ReadOnly = true;
            this.LinesOffCnt_textBox.Size = new System.Drawing.Size(126, 20);
            this.LinesOffCnt_textBox.TabIndex = 27;
            // 
            // LinesRead_textBox
            // 
            this.LinesRead_textBox.Location = new System.Drawing.Point(186, 38);
            this.LinesRead_textBox.Name = "LinesRead_textBox";
            this.LinesRead_textBox.ReadOnly = true;
            this.LinesRead_textBox.Size = new System.Drawing.Size(126, 20);
            this.LinesRead_textBox.TabIndex = 29;
            this.LinesRead_textBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Строк сформировано";
            // 
            // LinesOutCnt_textBox
            // 
            this.LinesOutCnt_textBox.Location = new System.Drawing.Point(186, 60);
            this.LinesOutCnt_textBox.Name = "LinesOutCnt_textBox";
            this.LinesOutCnt_textBox.ReadOnly = true;
            this.LinesOutCnt_textBox.Size = new System.Drawing.Size(126, 20);
            this.LinesOutCnt_textBox.TabIndex = 25;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 590);
            this.Controls.Add(this.Previw_TextBox);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OpenFolder_button);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.Preview_button);
            this.Controls.Add(this.OpenFile_button);
            this.Name = "MainWindow";
            this.Text = "Парсер логов  DSview для протокола TC358870XBG";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenFile_button;
        private System.Windows.Forms.TextBox FileName_TextBox;
        private System.Windows.Forms.TextBox Previw_TextBox;
        private System.Windows.Forms.Button Preview_button;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.ComboBox LinesCount_comboBox;
        private System.Windows.Forms.Button OpenFolder_button;
        private System.Windows.Forms.CheckBox LineNum_checkBox;
        private System.Windows.Forms.CheckBox LineTime_checkBox;
        private System.Windows.Forms.CheckBox DoubleCutting_checkBox;
        private System.Windows.Forms.CheckBox TabArrange_checkBox;
        private System.Windows.Forms.CheckBox CsvOut_checkBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CsvOutTab_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Postix_textBox;
        private System.Windows.Forms.TextBox PrefixWrite_textBox;
        private System.Windows.Forms.CheckBox Prefix_checkBox;
        private System.Windows.Forms.CheckBox RWtext_checkBox;
        private System.Windows.Forms.ProgressBar pb1;
        private System.Windows.Forms.TextBox PrefixRead_textBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox Preview_checkBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox LinesRead_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox LinesOffCnt_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LinesOutCnt_textBox;
        private System.Windows.Forms.CheckBox LinesNumPre_checkBox;

    }
}

