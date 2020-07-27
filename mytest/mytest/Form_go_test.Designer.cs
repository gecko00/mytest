namespace mytest
{
    partial class Form_go_test
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar_timer = new System.Windows.Forms.ProgressBar();
            this.label_time_now = new System.Windows.Forms.Label();
            this.label_time_end = new System.Windows.Forms.Label();
            this.label_about = new System.Windows.Forms.Label();
            this.groupBox_vopros = new System.Windows.Forms.GroupBox();
            this.label_vopros_text = new System.Windows.Forms.Label();
            this.button_next = new System.Windows.Forms.Button();
            this.radioButton_otv1 = new System.Windows.Forms.RadioButton();
            this.radioButton_otv2 = new System.Windows.Forms.RadioButton();
            this.radioButton_otv3 = new System.Windows.Forms.RadioButton();
            this.radioButton_otv4 = new System.Windows.Forms.RadioButton();
            this.groupBox_vopros.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar_timer
            // 
            this.progressBar_timer.Location = new System.Drawing.Point(70, 273);
            this.progressBar_timer.Name = "progressBar_timer";
            this.progressBar_timer.Size = new System.Drawing.Size(558, 23);
            this.progressBar_timer.TabIndex = 0;
            // 
            // label_time_now
            // 
            this.label_time_now.AutoSize = true;
            this.label_time_now.Location = new System.Drawing.Point(12, 279);
            this.label_time_now.Name = "label_time_now";
            this.label_time_now.Size = new System.Drawing.Size(13, 13);
            this.label_time_now.TabIndex = 1;
            this.label_time_now.Text = "0";
            // 
            // label_time_end
            // 
            this.label_time_end.AutoSize = true;
            this.label_time_end.Location = new System.Drawing.Point(634, 279);
            this.label_time_end.Name = "label_time_end";
            this.label_time_end.Size = new System.Drawing.Size(35, 13);
            this.label_time_end.TabIndex = 2;
            this.label_time_end.Text = "label1";
            // 
            // label_about
            // 
            this.label_about.AutoSize = true;
            this.label_about.Location = new System.Drawing.Point(529, 25);
            this.label_about.Name = "label_about";
            this.label_about.Size = new System.Drawing.Size(35, 13);
            this.label_about.TabIndex = 3;
            this.label_about.Text = "label1";
            // 
            // groupBox_vopros
            // 
            this.groupBox_vopros.Controls.Add(this.radioButton_otv4);
            this.groupBox_vopros.Controls.Add(this.radioButton_otv3);
            this.groupBox_vopros.Controls.Add(this.radioButton_otv2);
            this.groupBox_vopros.Controls.Add(this.radioButton_otv1);
            this.groupBox_vopros.Controls.Add(this.label_vopros_text);
            this.groupBox_vopros.Location = new System.Drawing.Point(15, 13);
            this.groupBox_vopros.Name = "groupBox_vopros";
            this.groupBox_vopros.Size = new System.Drawing.Size(499, 243);
            this.groupBox_vopros.TabIndex = 4;
            this.groupBox_vopros.TabStop = false;
            this.groupBox_vopros.Text = "groupBox1";
            // 
            // label_vopros_text
            // 
            this.label_vopros_text.AutoSize = true;
            this.label_vopros_text.Location = new System.Drawing.Point(19, 32);
            this.label_vopros_text.Name = "label_vopros_text";
            this.label_vopros_text.Size = new System.Drawing.Size(35, 13);
            this.label_vopros_text.TabIndex = 0;
            this.label_vopros_text.Text = "label1";
            // 
            // button_next
            // 
            this.button_next.Location = new System.Drawing.Point(532, 220);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(137, 36);
            this.button_next.TabIndex = 5;
            this.button_next.Text = "Дальше";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // radioButton_otv1
            // 
            this.radioButton_otv1.AutoSize = true;
            this.radioButton_otv1.Location = new System.Drawing.Point(22, 108);
            this.radioButton_otv1.Name = "radioButton_otv1";
            this.radioButton_otv1.Size = new System.Drawing.Size(85, 17);
            this.radioButton_otv1.TabIndex = 1;
            this.radioButton_otv1.TabStop = true;
            this.radioButton_otv1.Text = "radioButton1";
            this.radioButton_otv1.UseVisualStyleBackColor = true;
            // 
            // radioButton_otv2
            // 
            this.radioButton_otv2.AutoSize = true;
            this.radioButton_otv2.Location = new System.Drawing.Point(22, 140);
            this.radioButton_otv2.Name = "radioButton_otv2";
            this.radioButton_otv2.Size = new System.Drawing.Size(85, 17);
            this.radioButton_otv2.TabIndex = 2;
            this.radioButton_otv2.TabStop = true;
            this.radioButton_otv2.Text = "radioButton1";
            this.radioButton_otv2.UseVisualStyleBackColor = true;
            // 
            // radioButton_otv3
            // 
            this.radioButton_otv3.AutoSize = true;
            this.radioButton_otv3.Location = new System.Drawing.Point(22, 173);
            this.radioButton_otv3.Name = "radioButton_otv3";
            this.radioButton_otv3.Size = new System.Drawing.Size(85, 17);
            this.radioButton_otv3.TabIndex = 3;
            this.radioButton_otv3.TabStop = true;
            this.radioButton_otv3.Text = "radioButton2";
            this.radioButton_otv3.UseVisualStyleBackColor = true;
            // 
            // radioButton_otv4
            // 
            this.radioButton_otv4.AutoSize = true;
            this.radioButton_otv4.Location = new System.Drawing.Point(22, 206);
            this.radioButton_otv4.Name = "radioButton_otv4";
            this.radioButton_otv4.Size = new System.Drawing.Size(85, 17);
            this.radioButton_otv4.TabIndex = 4;
            this.radioButton_otv4.TabStop = true;
            this.radioButton_otv4.Text = "radioButton3";
            this.radioButton_otv4.UseVisualStyleBackColor = true;
            // 
            // Form_go_test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 314);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.groupBox_vopros);
            this.Controls.Add(this.label_about);
            this.Controls.Add(this.label_time_end);
            this.Controls.Add(this.label_time_now);
            this.Controls.Add(this.progressBar_timer);
            this.Name = "Form_go_test";
            this.Text = "Form_go_test";
            this.Load += new System.EventHandler(this.Form_go_test_Load);
            this.groupBox_vopros.ResumeLayout(false);
            this.groupBox_vopros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar_timer;
        private System.Windows.Forms.Label label_time_now;
        private System.Windows.Forms.Label label_time_end;
        private System.Windows.Forms.Label label_about;
        private System.Windows.Forms.GroupBox groupBox_vopros;
        private System.Windows.Forms.Label label_vopros_text;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.RadioButton radioButton_otv4;
        private System.Windows.Forms.RadioButton radioButton_otv3;
        private System.Windows.Forms.RadioButton radioButton_otv2;
        private System.Windows.Forms.RadioButton radioButton_otv1;
    }
}