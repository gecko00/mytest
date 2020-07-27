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
    public partial class Form2_Add : Form
    {
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

        int questions_id = 0;

        int added_questions = 15;
        int timer = 15;

        public string folder_datas = "..\\..\\Datas\\";

        public Form2_Add()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            question = new question_data[100];
        }

        /* Кнопка - Добавить вопрос */
        private void button_vopros_add_Click(object sender, EventArgs e)
        {
            if(textBox_add_text.Text.ToString()=="")
            {
                show_error( "Введите вопрос" );
            }
            else if(textBox_otv1.Text.ToString()==""
                    || textBox_otv2.Text.ToString() == ""
                    || textBox_otv3.Text.ToString() == ""
                    || textBox_otv4.Text.ToString() == "")
            {
                show_error("Заполните все варианты ответов");
            }
            else if(radioButton_well1.Checked == false
                    && radioButton_well2.Checked == false
                    && radioButton_well3.Checked == false
                    && radioButton_well4.Checked == false)
            {
                show_error("Выберите правильный вариант ответа");
            }
            else
            {
                added_questions--;

                questions_id++;

                // max que
                if (added_questions <= 0)
                {
                    groupBox_addque.Visible = false;

                    label_error.Text = "Максимум 10 вопросов";
                    label_error.Visible = true;
                }

                if(questions_id > 99)
                {
                    Application.Restart();
                }

                question[questions_id].text = textBox_add_text.Text.ToString();
                question[questions_id].otvet1 = textBox_otv1.Text.ToString();
                question[questions_id].otvet2 = textBox_otv2.Text.ToString();
                question[questions_id].otvet3 = textBox_otv3.Text.ToString();
                question[questions_id].otvet4 = textBox_otv4.Text.ToString();
                
                if (radioButton_well1.Checked) question[questions_id].wel = "1";
                else if (radioButton_well2.Checked) question[questions_id].wel = "2";
                else if (radioButton_well3.Checked) question[questions_id].wel = "3";
                else if (radioButton_well4.Checked) question[questions_id].wel = "4";

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

        /* Показать ошибку */
        void show_error( string text )
        {
            label_error.Text = text;
            label_error.Visible = true;

            timer1.Start();
        }

        /* Скрыть ошибку */
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer--;

            if(timer<=0)
            {
                timer1.Stop();

                label_error.Text = "";
                label_error.Visible = false;

                timer = 15;
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

        /* Кнопка - Сохранить тест */
        private void button_save_Click(object sender, EventArgs e)
        {
            if (textBox_name.Text.ToString() == "")
            {
                show_error("Введите название теста");
            }
            else if(textBox_ocenka_5.Text.ToString() == ""
                    || textBox_ocenka_4.Text.ToString() == ""
                    || textBox_ocenka_3.Text.ToString() == "")
            {
                show_error("Введите критерии оценки");
            }
            else if(listBox_voprosy.Items.Count<1)
            {
                show_error("Список вопросов пуст");
            }
            else if(textBox_time.Text.ToString() == "")
            {
                show_error("Время теста не указано");
            }
            else
            {
                StreamReader reader = new StreamReader(folder_datas + "list.txt");

                int all = int.Parse(reader.ReadLine());
                bool writefile = true;
                string newList = "";

                for(int i=0; i< all; i++)
                {
                    string thisname = reader.ReadLine();

                    newList += thisname + "\r\n";

                    if (thisname == textBox_name.Text.ToString())
                    {
                        writefile = false;
                        break;
                    }
                }

                newList += textBox_name.Text.ToString() + "\r\n";

                reader.Close();

                if(writefile)
                {
                    StreamWriter sw = new StreamWriter(folder_datas + "list.txt");

                    sw.WriteLine((all + 1).ToString());
                    sw.WriteLine(newList);
                    sw.Close();

                    // новый тест
                    string newtestfile = textBox_name.Text.ToString()+"\r\n" 
                                         + textBox_time.Text.ToString() + "\r\n"
                                         + textBox_ocenka_5.Text.ToString() + " "
                                         + textBox_ocenka_4.Text.ToString() + " "
                                         + textBox_ocenka_3.Text.ToString() + "\r\n"
                                         + listBox_voprosy.Items.Count.ToString() + "\r\n";

                    for (int q = 0; q < listBox_voprosy.Items.Count; q++)
                    {
                        int id_q = search_text( listBox_voprosy.Items[q].ToString() );

                        newtestfile += question[id_q].text + "\r\n"
                                + question[id_q].otvet1 + "\r\n"
                                + question[id_q].otvet2 + "\r\n"
                                + question[id_q].otvet3 + "\r\n"
                                + question[id_q].otvet4 + "\r\n"
                                + question[id_q].wel + "\r\n";
                    }

                    File.WriteAllText(folder_datas + textBox_name.Text.ToString() + ".txt", newtestfile);
                    File.WriteAllText(folder_datas + textBox_name.Text.ToString() + "_results.txt", "0\r\n");

                    this.Close();
                    MessageBox.Show("Тест создан");
                }
                else
                {
                    show_error("Тест с таким названием уже существует");
                }
            }
        }

        /* Получение index массива по значению texe */
        int search_text(string text)
        {
            for(int i = 0; i <16;i++)
            {
                if(question[i].text==text)
                {
                    return i;
                }
            }

            return 0;
        }
    }
}
