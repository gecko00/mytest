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
    public partial class Form1 : Form
    {
        string metod = "";
        public string testname = "";

        public string folder_datas = "..\\..\\Datas\\";

        public string gl_my_name = "";
        public string gl_my_group = "";
        public int gl_my_points = 0;
        public int gl_my_time = 0;

        public Form1()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }

        /* Кнопка - Пройти тест */
        private void button1_go_Click(object sender, EventArgs e)
        {
            label1_desc.Text = "Выберите тест:";
            label1_desc.Visible = true;

            metod = "go";

            loadTest();
        }

        /* Кнопка - Показать результаты теста */
        private void button1_results_Click(object sender, EventArgs e)
        {
            label1_desc.Text = "Выберите тест для просмотра результатов:";
            label1_desc.Visible = true;

            metod = "results";

            loadTest();
        }

        /* Кнопка - Добавить тест */
        private void button1_add_Click(object sender, EventArgs e)
        {
            Form add = new Form2_Add();
            add.Show();
        }

        /* Кнопка - Удалить тест */
        private void button1_remove_Click(object sender, EventArgs e)
        {
            label1_desc.Text = "Выберите тест для удаления:";
            label1_desc.Visible = true;

            metod = "remove";

            loadTest();
        }

        /* Кнопка - Редактировать */
        private void button1_edit_Click(object sender, EventArgs e)
        {
            label1_desc.Text = "Выберите тест для редактирования:";
            label1_desc.Visible = true;

            metod = "edit";

            loadTest();
        }

        /* Загрузить все тесты в таблицу */
        public void loadTest()
        {
            dataGridView_list.Rows.Clear();

            StreamReader reader = new StreamReader(folder_datas + "list.txt");

            int all = int.Parse(reader.ReadLine());
            
            for( int i = 0; i < all; i++ )
            {
                string TestName = reader.ReadLine();

                StreamReader testFile = new StreamReader(folder_datas + TestName + ".txt");

                testFile.ReadLine(); testFile.ReadLine(); testFile.ReadLine();

                string TestQues = testFile.ReadLine();

                testFile.Close();
               
                StreamReader testResults = new StreamReader(folder_datas + TestName + "_results.txt");

                string countResults = testResults.ReadLine();

                testResults.Close();
                
                dataGridView_list.Rows.Add(TestName, TestQues, countResults);
            }

            reader.Close();

            dataGridView_list.Visible = true;
            button_update.Visible = true;
        }

        /* Клик по ячейке */
        private void dataGridView_list_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_list.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
            {
                return;
            }

            string selTestName = dataGridView_list.Rows[e.RowIndex].Cells[0].Value.ToString();

            switch( metod )
            {
                /* - пройти */
                case "go":

                    testname = selTestName;

                    Form fGo = new Form_go_login();

                    fGo.Owner = this;
                    fGo.Show();

                    break;

                /* - результаты */
                case "results":

                    testname = selTestName;

                    Form fRes = new Form_results();

                    fRes.Owner = this;
                    fRes.Show();

                    break;

                /* - редактировать */
                case "edit":

                    testname = selTestName;

                    Form edit = new Form3_edit();

                    edit.Owner = this;
                    edit.Show();

                    break;

                /* - удалить */
                case "remove":

                    var result = MessageBox.Show("Удалить тест ?", selTestName,
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        testRemove(selTestName);
                    }

                    break;
            }

        }

        /* Удаление теста */
        void testRemove( string selTestName)
        {
            Console.WriteLine("remove " + selTestName);

            // файлы вопросов и результатов
            File.Delete(folder_datas + selTestName + ".txt");
            File.Delete(folder_datas + selTestName + "_results.txt");

            // список тестов
            StreamReader readerList = new StreamReader(folder_datas + "list.txt");

            int all = int.Parse(readerList.ReadLine());

            string newList = "";

            for (int i = 0; i < all; i++)
            {
                string thisname = readerList.ReadLine();

                if (thisname == selTestName)
                {
                    continue;
                }

                newList += thisname + "\r\n";
            }

            readerList.Close();

            StreamWriter sw = new StreamWriter(folder_datas + "list.txt");

            sw.WriteLine((all - 1).ToString());
            sw.WriteLine(newList);
            sw.Close();

            MessageBox.Show("Тест удалён");

            loadTest();
        }

        /* Кнопка - Обновить */
        private void button_update_Click(object sender, EventArgs e)
        {
            loadTest();
        }

        /* Начать тест */
        public void startTest(string my_name, string my_group)
        {
            gl_my_name = my_name;
            gl_my_group = my_group;

            Form fGoTest = new Form_go_test();

            fGoTest.Owner = this;
            fGoTest.Show();
        }

        /* Закончить тест, показать оценку */
        public void endTestShowRes()
        {
            Form fRes = new Form_last_res();

            fRes.Owner = this;
            fRes.Show();
        }
    }
}
