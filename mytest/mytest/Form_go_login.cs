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
    public partial class Form_go_login : Form
    {
        int timer = 15;

        Form1 frm;

        public Form_go_login()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }

        /* Загрузка формы */
        private void Form_go_login_Load(object sender, EventArgs e)
        {
            frm = (Form1)this.Owner;

            StreamReader Test = new StreamReader(frm.folder_datas + frm.testname + ".txt");

            label_test_info.Text = Test.ReadLine() + "\r\n"
                                   + "Время: "+Test.ReadLine()+" мин.\r\n";

            Test.ReadLine();

            label_test_info.Text += "Вопросов " + Test.ReadLine();

        }

        /* Кнопка - Начать */
        private void button_go_Click(object sender, EventArgs e)
        {
            if (textBox_name.Text.ToString() == "")
            {
                show_error("Укажите имя");
            }
            else if (textBox_group.Text.ToString() == "")
            {
                show_error("Укажите группу");
            }
            else
            {
                frm.startTest(textBox_name.Text.ToString(), textBox_group.Text.ToString());

                this.Close();
            }
        }

        /* Показать ошибку */
        void show_error(string text)
        {
            label_error.ForeColor = Color.Red;
            label_error.Text = text;
            label_error.Visible = true;

            timer1.Start();
        }

        /* Скрыть ошибку */
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer--;
            Console.WriteLine(timer);
            if (timer <= 0)
            {
                timer1.Stop();

                label_error.Text = "";
                label_error.Visible = false;

                timer = 15;
            }
        }
    }
}
