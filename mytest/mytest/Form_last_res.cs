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
    public partial class Form_last_res : Form
    {
        Form1 frm;

        string[] balls;

        public Form_last_res()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }

        /* Загрузка формы */
        private void Form_last_res_Load(object sender, EventArgs e)
        {
            frm = (Form1)this.Owner;

            this.Text = "Результаты " + frm.testname;

            StreamReader Test = new StreamReader(frm.folder_datas + frm.testname + ".txt");

            // name, time
            Test.ReadLine(); Test.ReadLine();

            // balls
            balls = Test.ReadLine().Split(' ');

            label_info.Text = "Имя: " + frm.gl_my_name + "\r\n"
                            + "Группа: " + frm.gl_my_group + "\r\n"
                            + "Потрачено времени: " + frm.gl_my_time + " сек.\r\n"
                            + "Правильных ответов: " + frm.gl_my_points;

            // 2
            if(frm.gl_my_points<int.Parse(balls[2]))
            {
                label_ocenka.Text = "2";
                label_ocenka.ForeColor = Color.Red;
            }
            // 3
            else if(frm.gl_my_points < int.Parse(balls[1]))
            {
                label_ocenka.Text = "3";
                label_ocenka.ForeColor = Color.Black;
            }
            // 4
            else if (frm.gl_my_points < int.Parse(balls[0]))
            {
                label_ocenka.Text = "4";
                label_ocenka.ForeColor = Color.Gray;
            }
            else
            {
                label_ocenka.Text = "5";
                label_ocenka.ForeColor = Color.Green;
            }

            WriteRes(); 
        }

        /* Записать результат */
        void WriteRes()
        {
            StreamReader listTests = new StreamReader(frm.folder_datas + frm.testname + "_results.txt");

            int all = int.Parse(listTests.ReadLine());

            string newList = "";

            for (int i = 0; i < all; i++)
            {
                newList += listTests.ReadLine() + "\r\n";
            }

            listTests.Close();

            newList += frm.gl_my_name + " " 
                       + frm.gl_my_group + " " 
                       + frm.gl_my_points + " " 
                       + frm.gl_my_time + " "
                       + label_ocenka.Text + "\r\n";

            StreamWriter sw = new StreamWriter(frm.folder_datas + frm.testname + "_results.txt");

            sw.WriteLine((all + 1).ToString());
            sw.WriteLine(newList);
            sw.Close();

            Console.WriteLine("Записано");
        }

        /* Кнопка - Закрыть */
        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
