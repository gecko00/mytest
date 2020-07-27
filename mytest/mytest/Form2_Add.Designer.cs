namespace mytest
{
    partial class Form2_Add
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
            this.components = new System.ComponentModel.Container();
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.listBox_voprosy = new System.Windows.Forms.ListBox();
            this.button_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_ocenka_5 = new System.Windows.Forms.TextBox();
            this.textBox_ocenka_4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_ocenka_3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox_addque = new System.Windows.Forms.GroupBox();
            this.button_vopros_add = new System.Windows.Forms.Button();
            this.radioButton_well4 = new System.Windows.Forms.RadioButton();
            this.radioButton_well3 = new System.Windows.Forms.RadioButton();
            this.radioButton_well2 = new System.Windows.Forms.RadioButton();
            this.radioButton_well1 = new System.Windows.Forms.RadioButton();
            this.textBox_otv4 = new System.Windows.Forms.TextBox();
            this.textBox_otv3 = new System.Windows.Forms.TextBox();
            this.textBox_otv2 = new System.Windows.Forms.TextBox();
            this.textBox_otv1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_add_text = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label_error = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_remove_vop = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_time = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox_addque.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(13, 13);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(91, 13);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Название теста:";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(16, 30);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(201, 20);
            this.textBox_name.TabIndex = 1;
            // 
            // listBox_voprosy
            // 
            this.listBox_voprosy.FormattingEnabled = true;
            this.listBox_voprosy.Location = new System.Drawing.Point(313, 34);
            this.listBox_voprosy.Name = "listBox_voprosy";
            this.listBox_voprosy.Size = new System.Drawing.Size(282, 108);
            this.listBox_voprosy.TabIndex = 2;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(472, 375);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(123, 36);
            this.button_save.TabIndex = 4;
            this.button_save.Text = "Сохранить";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Список вопросов:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Оценка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Правильных ответов";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "5";
            // 
            // textBox_ocenka_5
            // 
            this.textBox_ocenka_5.Location = new System.Drawing.Point(94, 86);
            this.textBox_ocenka_5.Name = "textBox_ocenka_5";
            this.textBox_ocenka_5.Size = new System.Drawing.Size(54, 20);
            this.textBox_ocenka_5.TabIndex = 9;
            // 
            // textBox_ocenka_4
            // 
            this.textBox_ocenka_4.Location = new System.Drawing.Point(94, 112);
            this.textBox_ocenka_4.Name = "textBox_ocenka_4";
            this.textBox_ocenka_4.Size = new System.Drawing.Size(54, 20);
            this.textBox_ocenka_4.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "4";
            // 
            // textBox_ocenka_3
            // 
            this.textBox_ocenka_3.Location = new System.Drawing.Point(94, 138);
            this.textBox_ocenka_3.Name = "textBox_ocenka_3";
            this.textBox_ocenka_3.Size = new System.Drawing.Size(54, 20);
            this.textBox_ocenka_3.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "3";
            // 
            // groupBox_addque
            // 
            this.groupBox_addque.Controls.Add(this.button_vopros_add);
            this.groupBox_addque.Controls.Add(this.radioButton_well4);
            this.groupBox_addque.Controls.Add(this.radioButton_well3);
            this.groupBox_addque.Controls.Add(this.radioButton_well2);
            this.groupBox_addque.Controls.Add(this.radioButton_well1);
            this.groupBox_addque.Controls.Add(this.textBox_otv4);
            this.groupBox_addque.Controls.Add(this.textBox_otv3);
            this.groupBox_addque.Controls.Add(this.textBox_otv2);
            this.groupBox_addque.Controls.Add(this.textBox_otv1);
            this.groupBox_addque.Controls.Add(this.label11);
            this.groupBox_addque.Controls.Add(this.label10);
            this.groupBox_addque.Controls.Add(this.label9);
            this.groupBox_addque.Controls.Add(this.label8);
            this.groupBox_addque.Controls.Add(this.textBox_add_text);
            this.groupBox_addque.Controls.Add(this.label7);
            this.groupBox_addque.Location = new System.Drawing.Point(16, 232);
            this.groupBox_addque.Name = "groupBox_addque";
            this.groupBox_addque.Size = new System.Drawing.Size(579, 137);
            this.groupBox_addque.TabIndex = 14;
            this.groupBox_addque.TabStop = false;
            this.groupBox_addque.Text = "Добавить вопрос";
            // 
            // button_vopros_add
            // 
            this.button_vopros_add.Location = new System.Drawing.Point(489, 99);
            this.button_vopros_add.Name = "button_vopros_add";
            this.button_vopros_add.Size = new System.Drawing.Size(75, 23);
            this.button_vopros_add.TabIndex = 16;
            this.button_vopros_add.Text = "Добавить";
            this.button_vopros_add.UseVisualStyleBackColor = true;
            this.button_vopros_add.Click += new System.EventHandler(this.button_vopros_add_Click);
            // 
            // radioButton_well4
            // 
            this.radioButton_well4.AutoSize = true;
            this.radioButton_well4.Location = new System.Drawing.Point(444, 104);
            this.radioButton_well4.Name = "radioButton_well4";
            this.radioButton_well4.Size = new System.Drawing.Size(14, 13);
            this.radioButton_well4.TabIndex = 26;
            this.radioButton_well4.TabStop = true;
            this.radioButton_well4.UseVisualStyleBackColor = true;
            // 
            // radioButton_well3
            // 
            this.radioButton_well3.AutoSize = true;
            this.radioButton_well3.Location = new System.Drawing.Point(444, 78);
            this.radioButton_well3.Name = "radioButton_well3";
            this.radioButton_well3.Size = new System.Drawing.Size(14, 13);
            this.radioButton_well3.TabIndex = 25;
            this.radioButton_well3.TabStop = true;
            this.radioButton_well3.UseVisualStyleBackColor = true;
            // 
            // radioButton_well2
            // 
            this.radioButton_well2.AutoSize = true;
            this.radioButton_well2.Location = new System.Drawing.Point(444, 52);
            this.radioButton_well2.Name = "radioButton_well2";
            this.radioButton_well2.Size = new System.Drawing.Size(14, 13);
            this.radioButton_well2.TabIndex = 24;
            this.radioButton_well2.TabStop = true;
            this.radioButton_well2.UseVisualStyleBackColor = true;
            // 
            // radioButton_well1
            // 
            this.radioButton_well1.AutoSize = true;
            this.radioButton_well1.Location = new System.Drawing.Point(444, 24);
            this.radioButton_well1.Name = "radioButton_well1";
            this.radioButton_well1.Size = new System.Drawing.Size(120, 17);
            this.radioButton_well1.TabIndex = 23;
            this.radioButton_well1.TabStop = true;
            this.radioButton_well1.Text = "Правильный ответ";
            this.radioButton_well1.UseVisualStyleBackColor = true;
            // 
            // textBox_otv4
            // 
            this.textBox_otv4.Location = new System.Drawing.Point(268, 101);
            this.textBox_otv4.Name = "textBox_otv4";
            this.textBox_otv4.Size = new System.Drawing.Size(170, 20);
            this.textBox_otv4.TabIndex = 22;
            // 
            // textBox_otv3
            // 
            this.textBox_otv3.Location = new System.Drawing.Point(268, 75);
            this.textBox_otv3.Name = "textBox_otv3";
            this.textBox_otv3.Size = new System.Drawing.Size(170, 20);
            this.textBox_otv3.TabIndex = 21;
            // 
            // textBox_otv2
            // 
            this.textBox_otv2.Location = new System.Drawing.Point(268, 49);
            this.textBox_otv2.Name = "textBox_otv2";
            this.textBox_otv2.Size = new System.Drawing.Size(170, 20);
            this.textBox_otv2.TabIndex = 20;
            // 
            // textBox_otv1
            // 
            this.textBox_otv1.Location = new System.Drawing.Point(268, 23);
            this.textBox_otv1.Name = "textBox_otv1";
            this.textBox_otv1.Size = new System.Drawing.Size(170, 20);
            this.textBox_otv1.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(213, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Ответ 4:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(213, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Ответ 3:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(213, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Ответ 2:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(213, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Ответ 1:";
            // 
            // textBox_add_text
            // 
            this.textBox_add_text.Location = new System.Drawing.Point(21, 41);
            this.textBox_add_text.Multiline = true;
            this.textBox_add_text.Name = "textBox_add_text";
            this.textBox_add_text.Size = new System.Drawing.Size(180, 61);
            this.textBox_add_text.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Вопрос:";
            // 
            // label_error
            // 
            this.label_error.AutoSize = true;
            this.label_error.ForeColor = System.Drawing.Color.Red;
            this.label_error.Location = new System.Drawing.Point(34, 387);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(56, 13);
            this.label_error.TabIndex = 15;
            this.label_error.Text = "label_error";
            this.label_error.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_remove_vop
            // 
            this.button_remove_vop.Location = new System.Drawing.Point(520, 151);
            this.button_remove_vop.Name = "button_remove_vop";
            this.button_remove_vop.Size = new System.Drawing.Size(75, 23);
            this.button_remove_vop.TabIndex = 3;
            this.button_remove_vop.Text = "Удалить";
            this.button_remove_vop.UseVisualStyleBackColor = true;
            this.button_remove_vop.Click += new System.EventHandler(this.button_remove_vop_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 171);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Время на прохождение:";
            // 
            // textBox_time
            // 
            this.textBox_time.Location = new System.Drawing.Point(16, 188);
            this.textBox_time.Name = "textBox_time";
            this.textBox_time.Size = new System.Drawing.Size(125, 20);
            this.textBox_time.TabIndex = 17;
            this.textBox_time.Text = "20";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(150, 191);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "мин.";
            // 
            // Form2_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 437);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox_time);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.groupBox_addque);
            this.Controls.Add(this.textBox_ocenka_3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_ocenka_4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_ocenka_5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_remove_vop);
            this.Controls.Add(this.listBox_voprosy);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_name);
            this.Name = "Form2_Add";
            this.Text = "Добавить тест";
            this.groupBox_addque.ResumeLayout(false);
            this.groupBox_addque.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.ListBox listBox_voprosy;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_ocenka_5;
        private System.Windows.Forms.TextBox textBox_ocenka_4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_ocenka_3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox_addque;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_add_text;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButton_well4;
        private System.Windows.Forms.RadioButton radioButton_well3;
        private System.Windows.Forms.RadioButton radioButton_well2;
        private System.Windows.Forms.RadioButton radioButton_well1;
        private System.Windows.Forms.TextBox textBox_otv4;
        private System.Windows.Forms.TextBox textBox_otv3;
        private System.Windows.Forms.TextBox textBox_otv2;
        private System.Windows.Forms.TextBox textBox_otv1;
        private System.Windows.Forms.Label label_error;
        private System.Windows.Forms.Button button_vopros_add;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_remove_vop;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_time;
        private System.Windows.Forms.Label label13;
    }
}