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
    public partial class Form_go_test : Form
    {
        Form1 frm;

        int test_start_time = 0;
        int test_timer = 0;

        int test_quetions = 0;

        int this_quetion = 0;

        struct question_data
        {
            public string text;
            public string otvet1;
            public string otvet2;
            public string otvet3;
            public string otvet4;
            public string wel;
        };

        question_data[] question;

        int my_balls = 0;

        public Form_go_test()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }

        /* Загрузка формы */
        private void Form_go_test_Load(object sender, EventArgs e)
        {
            frm = (Form1)this.Owner;

            this.Text = frm.testname;

            StreamReader Test = new StreamReader(frm.folder_datas + frm.testname + ".txt");

            Test.ReadLine();

            test_timer = test_start_time = int.Parse(Test.ReadLine()) * 60;

            // balls
            Test.ReadLine();

            test_quetions = int.Parse(Test.ReadLine());
            
            // quetions
            question = new question_data[test_quetions];

            for (int q = 0; q < test_quetions; q++)
            {
                question[q].text = Test.ReadLine();
                question[q].otvet1 = Test.ReadLine();
                question[q].otvet2 = Test.ReadLine();
                question[q].otvet3 = Test.ReadLine();
                question[q].otvet4 = Test.ReadLine();
                question[q].wel = Test.ReadLine();
            }

            Test.Close();

            label_time_end.Text = test_start_time.ToString() + " сек.";

            label_about.Text = frm.gl_my_name + " " + frm.gl_my_group;

            timer1.Interval = 1000;
            timer1.Start();

            showQuetion();
        }

        /* Показать вопрос */
        void showQuetion()
        {
            groupBox_vopros.Text = "Вопрос "+ (this_quetion+1).ToString() +" из "+ test_quetions.ToString();

            label_vopros_text.Text = question[this_quetion].text;
            radioButton_otv1.Text = question[this_quetion].otvet1;
            radioButton_otv2.Text = question[this_quetion].otvet2;
            radioButton_otv3.Text = question[this_quetion].otvet3;
            radioButton_otv4.Text = question[this_quetion].otvet4;
        }

        /* Кнопка - Дальше */
        private void button_next_Click(object sender, EventArgs e)
        {
            // провить результат
            string my_otvet = "";

            if (radioButton_otv1.Checked)
            {
                my_otvet = "1";
                radioButton_otv1.Checked = false;
            }
            else if (radioButton_otv2.Checked)
            {
                my_otvet = "2";
                radioButton_otv2.Checked = false;
            }
            else if (radioButton_otv3.Checked)
            {
                my_otvet = "3";
                radioButton_otv3.Checked = false;
            }
            else if (radioButton_otv4.Checked)
            {
                my_otvet = "4";
                radioButton_otv4.Checked = false;
            }

            if(my_otvet == question[this_quetion].wel)
            {
                my_balls++;
                Console.WriteLine("Правильно");
            }

            // показать слудеющий вопрос или закончить
            this_quetion++;

            if (this_quetion >= test_quetions)
            {
                endTest();
            }
            else
            {
                showQuetion();
            }

        }

        /* Закончить тест */
        void endTest()
        {
            timer1.Stop();

            frm.gl_my_points = my_balls;
            frm.gl_my_time = test_start_time - test_timer;

            frm.endTestShowRes();

            this.Close();
        }

        /* Таймер */
        private void timer1_Tick(object sender, EventArgs e)
        {
            test_timer = test_timer -1;

            progressBar_timer.Value = test_start_time - test_timer;

            label_time_now.Text = (test_start_time - test_timer).ToString();

            if (test_timer <= 0)
            {
                MessageBox.Show("Время вышло");
                endTest();
            }
        }
    }
}
