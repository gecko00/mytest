﻿namespace mytest
{
    partial class Form_go_login
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_group = new System.Windows.Forms.TextBox();
            this.button_go = new System.Windows.Forms.Button();
            this.label_error = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_test_info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя:";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(16, 30);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(108, 20);
            this.textBox_name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Группа:";
            // 
            // textBox_group
            // 
            this.textBox_group.Location = new System.Drawing.Point(141, 29);
            this.textBox_group.Name = "textBox_group";
            this.textBox_group.Size = new System.Drawing.Size(81, 20);
            this.textBox_group.TabIndex = 3;
            // 
            // button_go
            // 
            this.button_go.Location = new System.Drawing.Point(147, 112);
            this.button_go.Name = "button_go";
            this.button_go.Size = new System.Drawing.Size(75, 23);
            this.button_go.TabIndex = 4;
            this.button_go.Text = "Начать тест";
            this.button_go.UseVisualStyleBackColor = true;
            this.button_go.Click += new System.EventHandler(this.button_go_Click);
            // 
            // label_error
            // 
            this.label_error.AutoSize = true;
            this.label_error.Location = new System.Drawing.Point(13, 117);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(0, 13);
            this.label_error.TabIndex = 5;
            this.label_error.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_test_info
            // 
            this.label_test_info.AutoSize = true;
            this.label_test_info.Location = new System.Drawing.Point(16, 66);
            this.label_test_info.Name = "label_test_info";
            this.label_test_info.Size = new System.Drawing.Size(35, 13);
            this.label_test_info.TabIndex = 6;
            this.label_test_info.Text = "label3";
            // 
            // Form_go_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 141);
            this.Controls.Add(this.label_test_info);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.button_go);
            this.Controls.Add(this.textBox_group);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label1);
            this.Name = "Form_go_login";
            this.Text = "Тест";
            this.Load += new System.EventHandler(this.Form_go_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_group;
        private System.Windows.Forms.Button button_go;
        private System.Windows.Forms.Label label_error;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_test_info;
    }
}