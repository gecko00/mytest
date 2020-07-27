namespace mytest
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1_go = new System.Windows.Forms.Button();
            this.button1_results = new System.Windows.Forms.Button();
            this.button1_add = new System.Windows.Forms.Button();
            this.dataGridView_list = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vopros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.res = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1_desc = new System.Windows.Forms.Label();
            this.button1_edit = new System.Windows.Forms.Button();
            this.button1_remove = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_list)).BeginInit();
            this.SuspendLayout();
            // 
            // button1_go
            // 
            this.button1_go.Location = new System.Drawing.Point(62, 32);
            this.button1_go.Name = "button1_go";
            this.button1_go.Size = new System.Drawing.Size(127, 23);
            this.button1_go.TabIndex = 0;
            this.button1_go.Text = "Пройти тест";
            this.button1_go.UseVisualStyleBackColor = true;
            this.button1_go.Click += new System.EventHandler(this.button1_go_Click);
            // 
            // button1_results
            // 
            this.button1_results.Location = new System.Drawing.Point(62, 109);
            this.button1_results.Name = "button1_results";
            this.button1_results.Size = new System.Drawing.Size(127, 23);
            this.button1_results.TabIndex = 1;
            this.button1_results.Text = "Результаты";
            this.button1_results.UseVisualStyleBackColor = true;
            this.button1_results.Click += new System.EventHandler(this.button1_results_Click);
            // 
            // button1_add
            // 
            this.button1_add.Location = new System.Drawing.Point(62, 61);
            this.button1_add.Name = "button1_add";
            this.button1_add.Size = new System.Drawing.Size(127, 23);
            this.button1_add.TabIndex = 2;
            this.button1_add.Text = "Добавить тест";
            this.button1_add.UseVisualStyleBackColor = true;
            this.button1_add.Click += new System.EventHandler(this.button1_add_Click);
            // 
            // dataGridView_list
            // 
            this.dataGridView_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.vopros,
            this.res});
            this.dataGridView_list.Location = new System.Drawing.Point(242, 58);
            this.dataGridView_list.Name = "dataGridView_list";
            this.dataGridView_list.Size = new System.Drawing.Size(438, 150);
            this.dataGridView_list.TabIndex = 3;
            this.dataGridView_list.Visible = false;
            this.dataGridView_list.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_list_CellDoubleClick);
            // 
            // name
            // 
            this.name.FillWeight = 200F;
            this.name.Frozen = true;
            this.name.HeaderText = "Название теста";
            this.name.MaxInputLength = 42767;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 200;
            // 
            // vopros
            // 
            this.vopros.Frozen = true;
            this.vopros.HeaderText = "Вопросов";
            this.vopros.Name = "vopros";
            this.vopros.ReadOnly = true;
            // 
            // res
            // 
            this.res.Frozen = true;
            this.res.HeaderText = "Результатов";
            this.res.Name = "res";
            this.res.ReadOnly = true;
            // 
            // label1_desc
            // 
            this.label1_desc.AutoSize = true;
            this.label1_desc.Location = new System.Drawing.Point(242, 32);
            this.label1_desc.Name = "label1_desc";
            this.label1_desc.Size = new System.Drawing.Size(35, 13);
            this.label1_desc.TabIndex = 4;
            this.label1_desc.Text = "label1";
            this.label1_desc.Visible = false;
            // 
            // button1_edit
            // 
            this.button1_edit.Location = new System.Drawing.Point(62, 138);
            this.button1_edit.Name = "button1_edit";
            this.button1_edit.Size = new System.Drawing.Size(127, 23);
            this.button1_edit.TabIndex = 5;
            this.button1_edit.Text = "Редактировать тест";
            this.button1_edit.UseVisualStyleBackColor = true;
            this.button1_edit.Click += new System.EventHandler(this.button1_edit_Click);
            // 
            // button1_remove
            // 
            this.button1_remove.Location = new System.Drawing.Point(62, 167);
            this.button1_remove.Name = "button1_remove";
            this.button1_remove.Size = new System.Drawing.Size(127, 23);
            this.button1_remove.TabIndex = 6;
            this.button1_remove.Text = "Удалить тест";
            this.button1_remove.UseVisualStyleBackColor = true;
            this.button1_remove.Click += new System.EventHandler(this.button1_remove_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(605, 27);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 7;
            this.button_update.Text = "Обновить";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Visible = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 220);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button1_remove);
            this.Controls.Add(this.button1_edit);
            this.Controls.Add(this.label1_desc);
            this.Controls.Add(this.dataGridView_list);
            this.Controls.Add(this.button1_add);
            this.Controls.Add(this.button1_results);
            this.Controls.Add(this.button1_go);
            this.Name = "Form1";
            this.Text = "Тесты";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_go;
        private System.Windows.Forms.Button button1_results;
        private System.Windows.Forms.Button button1_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn vopros;
        private System.Windows.Forms.DataGridViewTextBoxColumn res;
        private System.Windows.Forms.Button button1_edit;
        private System.Windows.Forms.Button button1_remove;
        public System.Windows.Forms.DataGridView dataGridView_list;
        public System.Windows.Forms.Label label1_desc;
        private System.Windows.Forms.Button button_update;
    }
}

