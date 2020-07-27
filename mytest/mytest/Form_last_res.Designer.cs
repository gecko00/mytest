namespace mytest
{
    partial class Form_last_res
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
            this.label_info = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.label_ocenka = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Location = new System.Drawing.Point(12, 46);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(35, 13);
            this.label_info.TabIndex = 0;
            this.label_info.Text = "label1";
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(279, 131);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 1;
            this.button_close.Text = "Закрыть";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // label_ocenka
            // 
            this.label_ocenka.AutoSize = true;
            this.label_ocenka.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ocenka.Location = new System.Drawing.Point(237, 46);
            this.label_ocenka.Name = "label_ocenka";
            this.label_ocenka.Size = new System.Drawing.Size(27, 29);
            this.label_ocenka.TabIndex = 2;
            this.label_ocenka.Text = "0";
            this.label_ocenka.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Оценка";
            // 
            // Form_last_res
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 166);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_ocenka);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.label_info);
            this.Name = "Form_last_res";
            this.Text = "Form_last_res";
            this.Load += new System.EventHandler(this.Form_last_res_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Label label_ocenka;
        private System.Windows.Forms.Label label1;
    }
}