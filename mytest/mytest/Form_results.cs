using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace mytest
{
    public partial class Form_results : Form
    {
        Form1 frm;

        string[] info;

        public Form_results()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }

        /* Загрузка формы */
        private void Form_results_Load(object sender, EventArgs e)
        {
            frm = (Form1)this.Owner;

            this.Text = "Результаты " + frm.testname;

            StreamReader Results = new StreamReader(frm.folder_datas + frm.testname + "_results.txt");

            int all = int.Parse(Results.ReadLine());

            for (int i = 0; i < all; i++)
            {
                info = Results.ReadLine().Split(' ');

                dataGridView1.Rows.Add( info[0],
                                        info[1],
                                        info[2],
                                        info[3] + " сек.",
                                        info[4] );
            }

            Results.Close();
        }

        /* Кнопка - Закрыть */
        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
