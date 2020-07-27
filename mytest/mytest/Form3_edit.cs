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
    public partial class Form3_edit : Form
    {
        string testName = "";
        string folder_datas = "";

        int questions = 0;
        int added_questions = 15;
        int timer = 15;

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

        bool edit_do = false;

        public Form3_edit()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            question = new question_data[100];
        }

        /* Загрузка теста */
        private void Form3_edit_Load(object sender, EventArgs e)
        {
            Form1 frm = (Form1)this.Owner;

            testName = textBox_name.Text = frm.testname;
            folder_datas = frm.folder_datas;

            this.Text = "Редктировать тест "+testName;

            StreamReader Test = new StreamReader(folder_datas + testName + ".txt");

            // name
            Test.ReadLine();

            // time
            textBox_time.Text = Test.ReadLine();

            // balls
            string[] balls = Test.ReadLine().Split(' ');

            textBox_ocenka_5.Text = balls[0].ToString();
            textBox_ocenka_4.Text = balls[1].ToString();
            textBox_ocenka_3.Text = balls[2].ToString();

            // questions
            questions = int.Parse(Test.ReadLine());

            for( int q = 0; q < questions; q++)
            {
                question[q].text = Test.ReadLine();
                question[q].otvet1 = Test.ReadLine();
                question[q].otvet2 = Test.ReadLine();
                question[q].otvet3 = Test.ReadLine();
                question[q].otvet4 = Test.ReadLine();
                question[q].wel = Test.ReadLine();

                listBox_voprosy.Items.Add(question[q].text);

                added_questions--;
            }

            Test.Close();

            if(added_questions<=0)
            {
                groupBox_addque.Visible = false;

                label_error.Text = "Максимум 10 вопросов";
                label_error.Visible = true;
            }
        }

        /* Кнопка - Удалить вопрос */
        private void button_remove_vop_Click(object sender, EventArgs e)
        {
            if (listBox_voprosy.SelectedItem == null) return;

            listBox_voprosy.Items.Remove(listBox_voprosy.SelectedItem);

            added_questions++;

            if (added_questions > 0)
            {
                groupBox_addque.Visible = true;

                label_error.Text = "";
                label_error.Visible = false;
            }
        }

        /* Показать ошибку */
        void show_error(string text)
        {
            label_error.Text = text;
            label_error.Visible = true;

            timer1.Start();
        }

        /* Скрыть ошибку */
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer--;

            if (timer <= 0)
            {
                timer1.Stop();

                label_error.Text = "";
                label_error.Visible = false;

                timer = 15;
            }
        }
        
        /* Получение index массива по значению texe */
        int search_text(string text)
        {
            for (int i = 0; i < 16; i++)
            {
                if (question[i].text == text)
                {
                    return i;
                }
            }

            return 0;
        }

        /* Кнопка - Добавить вопрос */
        private void button_vopros_add_Click(object sender, EventArgs e)
        {
            if (textBox_add_text.Text.ToString() == "")
            {
                show_error("Введите вопрос");
            }
            else if (textBox_otv1.Text.ToString() == ""
                    || textBox_otv2.Text.ToString() == ""
                    || textBox_otv3.Text.ToString() == ""
                    || textBox_otv4.Text.ToString() == "")
            {
                show_error("Заполните все варианты ответов");
            }
            else if (radioButton_well1.Checked == false
                    && radioButton_well2.Checked == false
                    && radioButton_well3.Checked == false
                    && radioButton_well4.Checked == false)
            {
                show_error("Выберите правильный вариант ответа");
            }
            else
            {
                added_questions--;
                edit_do = false;
                questions++;

                // max que
                if (added_questions <= 0)
                {
                    groupBox_addque.Visible = false;

                    label_error.Text = "Максимум 10 вопросов";
                    label_error.Visible = true;
                }

                if (questions > 99)
                {
                    Application.Restart();
                }

                question[questions].text = textBox_add_text.Text.ToString();
                question[questions].otvet1 = textBox_otv1.Text.ToString();
                question[questions].otvet2 = textBox_otv2.Text.ToString();
                question[questions].otvet3 = textBox_otv3.Text.ToString();
                question[questions].otvet4 = textBox_otv4.Text.ToString();

                if (radioButton_well1.Checked) question[questions].wel = "1";
                else if (radioButton_well2.Checked) question[questions].wel = "2";
                else if (radioButton_well3.Checked) question[questions].wel = "3";
                else if (radioButton_well4.Checked) question[questions].wel = "4";

                listBox_voprosy.Items.Add(textBox_add_text.Text.ToString());

                textBox_add_text.Text = textBox_otv1.Text
                                      = textBox_otv2.Text
                                      = textBox_otv3.Text
                                      = textBox_otv4.Text = "";

                radioButton_well1.Checked = radioButton_well2.Checked
                                          = radioButton_well3.Checked
                                          = radioButton_well4.Checked = false;
            }
        }

        /* Выбран вопрос для редактирования */
        private void listBox_voprosy_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox_voprosy.SelectedItem == null)
            {
                return;
            }

            if(edit_do==true)
            {
                show_error("Сохраните предыдущий вопрос");

                return;
            }

            edit_do = true;

            string Qname = listBox_voprosy.SelectedItem.ToString();

            listBox_voprosy.Items.Remove(Qname);

            added_questions++;

            if (added_questions > 0)
            {
                groupBox_addque.Visible = true;

                label_error.Text = "";
                label_error.Visible = false;

                int id_q = search_text(Qname);

                textBox_add_text.Text = question[id_q].text;
                textBox_otv1.Text = question[id_q].otvet1;
                textBox_otv2.Text = question[id_q].otvet2;
                textBox_otv3.Text = question[id_q].otvet3;
                textBox_otv4.Text = question[id_q].otvet4;

                switch (question[id_q].wel)
                {
                    case "1": radioButton_well1.Checked = true; break;
                    case "2": radioButton_well2.Checked = true; break;
                    case "3": radioButton_well3.Checked = true; break;
                    case "4": radioButton_well4.Checked = true; break;
                }

                question[id_q].text = "";
            }
        }

        /* Кнопка - Сохранить тест */
        private void button_save_Click(object sender, EventArgs e)
        {
            if (textBox_name.Text.ToString() == "")
            {
                show_error("Введите название теста");
            }
            else if (textBox_ocenka_5.Text.ToString() == ""
                    || textBox_ocenka_4.Text.ToString() == ""
                    || textBox_ocenka_3.Text.ToString() == "")
            {
                show_error("Введите критерии оценки");
            }
            else if (listBox_voprosy.Items.Count < 1)
            {
                show_error("Список вопросов пуст");
            }
            else if (textBox_time.Text.ToString() == "")
            {
                show_error("Время теста не указано");
            }
            else
            {
                string newtestfile = textBox_name.Text.ToString() + "\r\n"
                                         + textBox_time.Text.ToString() + "\r\n"
                                         + textBox_ocenka_5.Text.ToString() + " "
                                         + textBox_ocenka_4.Text.ToString() + " "
                                         + textBox_ocenka_3.Text.ToString() + "\r\n"
                                         + listBox_voprosy.Items.Count.ToString() + "\r\n";

                for (int q = 0; q < listBox_voprosy.Items.Count; q++)
                {
                    int id_q = search_text(listBox_voprosy.Items[q].ToString());

                    newtestfile += question[id_q].text + "\r\n"
                                + question[id_q].otvet1 + "\r\n"
                                + question[id_q].otvet2 + "\r\n"
                                + question[id_q].otvet3 + "\r\n"
                                + question[id_q].otvet4 + "\r\n"
                                + question[id_q].wel + "\r\n";
                }

                File.WriteAllText(folder_datas + testName + ".txt", newtestfile);

                this.Close();

                MessageBox.Show("Тест сохранён");
            }
        }
    }
}
