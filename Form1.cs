using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Kursovoi_proekt
{
    public partial class Form1 : Form
    {
        public DataRow Add;
        public DataRow Cng;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet.Информация_о_издательстве". При необходимости она может быть перемещена или удалена.
            this.информация_о_издательствеTableAdapter.Fill(this.libraryDataSet.Информация_о_издательстве);
            this.информация_об_автореTableAdapter.Fill(this.libraryDataSet.Информация_об_авторе);
            this.информация_о_книгеTableAdapter.Fill(this.libraryDataSet.Информация_о_книге);
            this.информация_о_выдачеTableAdapter.Fill(this.libraryDataSet.Информация_о_выдаче);
            this.информация_о_читательском_билетеTableAdapter.Fill(this.libraryDataSet.Информация_о_читательском_билете);
            this.информация_о_читателеTableAdapter.Fill(this.libraryDataSet.Информация_о_читателе);

            StreamReader Log_load = new StreamReader(@"Log.txt", true);
            while (!Log_load.EndOfStream)
            {
                Log_list.Items.Add(Log_load.ReadLine());
            }
            Log_load.Close();

            toolStrip1.Visible = true;
            TB_inf_ser.Visible = false;
            TB_ser_pas.Visible = false;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabControl.SelectedIndex == 0)
                {
                    int selectedRowIndex = this.DGVReaders.SelectedRows[0].Index;
                    int id = 0;
                    bool converted = Int32.TryParse(this.DGVReaders[0, selectedRowIndex].Value.ToString(), out id);
                    if (converted == false)
                        return;
                    DataRow Del = this.libraryDataSet.Информация_о_читателе.Rows.Find(id);
                    this.libraryDataSet.Информация_о_читателе.Rows.Remove(Del);
                    this.информация_о_читателеTableAdapter.Update(this.libraryDataSet.Информация_о_читателе);
                    this.libraryDataSet.Информация_о_читателе.AcceptChanges();
                    this.информация_о_читателеTableAdapter.DeleteReader(id);
                    this.DGVReaders.Refresh();
                }
                if (tabControl.SelectedIndex == 1)
                {
                    int selectedRowIndex = this.DGVTickets.SelectedRows[0].Index;
                    int id = 0;
                    bool converted = Int32.TryParse(this.DGVTickets[0, selectedRowIndex].Value.ToString(), out id);
                    if (converted == false)
                        return;
                    DataRow Del = this.libraryDataSet.Информация_о_читательском_билете.Rows.Find(id);
                    this.libraryDataSet.Информация_о_читательском_билете.Rows.Remove(Del);
                    this.информация_о_читательском_билетеTableAdapter.Update(this.libraryDataSet.Информация_о_читательском_билете);
                    this.libraryDataSet.Информация_о_читательском_билете.AcceptChanges();
                    this.информация_о_читательском_билетеTableAdapter.DeleteTicket(id);
                    this.DGVTickets.Refresh();
                }
                if (tabControl.SelectedIndex == 2)
                {
                    int selectedRowIndex = this.DGVBook_give.SelectedRows[0].Index;
                    int id = 0;
                    bool converted = Int32.TryParse(this.DGVBook_give[0, selectedRowIndex].Value.ToString(), out id);
                    if (converted == false)
                        return;
                    DataRow Del = this.libraryDataSet.Информация_о_выдаче.Rows.Find(id);
                    this.libraryDataSet.Информация_о_выдаче.Rows.Remove(Del);
                    this.информация_о_выдачеTableAdapter.Update(this.libraryDataSet.Информация_о_выдаче);
                    this.libraryDataSet.Информация_о_выдаче.AcceptChanges();
                    this.информация_о_выдачеTableAdapter.DeleteBook_give(id);
                    this.DGVBook_give.Refresh();
                }
                if (tabControl.SelectedIndex == 3)
                {
                    int selectedRowIndex = this.DGVBooks.SelectedRows[0].Index;
                    int id = 0;
                    bool converted = Int32.TryParse(this.DGVBooks[0, selectedRowIndex].Value.ToString(), out id);
                    if (converted == false)
                        return;
                    DataRow Del = this.libraryDataSet.Информация_о_книге.Rows.Find(id);
                    this.libraryDataSet.Информация_о_книге.Rows.Remove(Del);
                    this.информация_о_книгеTableAdapter.Update(this.libraryDataSet.Информация_о_книге);
                    this.libraryDataSet.Информация_о_книге.AcceptChanges();
                    this.информация_о_книгеTableAdapter.DeleteBook(id);
                    this.DGVBooks.Refresh();
                }
                if (tabControl.SelectedIndex == 4)
                {
                    int selectedRowIndex = this.DGVAuthor.SelectedRows[0].Index;
                    int id = 0;
                    bool converted = Int32.TryParse(this.DGVAuthor[0, selectedRowIndex].Value.ToString(), out id);
                    if (converted == false)
                        return;
                    DataRow Del = this.libraryDataSet.Информация_об_авторе.Rows.Find(id);
                    this.libraryDataSet.Информация_об_авторе.Rows.Remove(Del);
                    this.информация_об_автореTableAdapter.Update(this.libraryDataSet.Информация_об_авторе);
                    this.libraryDataSet.Информация_об_авторе.AcceptChanges();
                    this.информация_об_автореTableAdapter.DeleteAuthor(id);
                    this.DGVAuthor.Refresh();
                }
                if (tabControl.SelectedIndex == 5)
                {
                    int selectedRowIndex = this.DGVPublisher.SelectedRows[0].Index;
                    int id = 0;
                    bool converted = Int32.TryParse(this.DGVPublisher[0, selectedRowIndex].Value.ToString(), out id);
                    if (converted == false)
                        return;
                    DataRow Del = this.libraryDataSet.Информация_о_издательстве.Rows.Find(id);
                    this.libraryDataSet.Информация_о_издательстве.Rows.Remove(Del);
                    this.информация_о_издательствеTableAdapter.Update(this.libraryDataSet.Информация_о_издательстве);
                    this.libraryDataSet.Информация_о_издательстве.AcceptChanges();
                    this.информация_о_издательствеTableAdapter.DeletePublisher(id);
                    this.DGVPublisher.Refresh();
                }
                StatusLabel.Text = "Строка удалена.";
            }
            catch (System.ArgumentOutOfRangeException s)
            {
                this.StatusLabel.Text = "Не выбрана строка.";
                StreamWriter Log = new StreamWriter(@"Log.txt", true);
                string new_log = $"Не выбрана строка. Исключение {s}\n";
                Log.WriteLine(new_log);
                Log.Close();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabControl.SelectedIndex == 0)
                {
                    New_reader add_window = new New_reader();
                    add_window.Owner = this;
                    add_window.Show();
                }
                if (tabControl.SelectedIndex == 1)
                {
                    New_reader add_window = new New_reader();
                    add_window.Owner = this;
                    add_window.Show();
                }
                if (tabControl.SelectedIndex == 2)
                {
                    Book_give add_window = new Book_give();
                    add_window.add_tr = true;
                    add_window.Owner = this;
                    add_window.Show();
                }
                if (tabControl.SelectedIndex == 3)
                {
                    Books add_window = new Books();
                    add_window.add_tr = true;
                    add_window.Owner = this;
                    add_window.Show();
                }
                if (tabControl.SelectedIndex == 4)
                {
                    Author add_window = new Author();
                    add_window.add_tr = true;
                    add_window.Owner = this;
                    add_window.Show();
                }
                if (tabControl.SelectedIndex == 5)
                {
                    Publisher add_window = new Publisher();
                    add_window.add_tr = true;
                    add_window.Owner = this;
                    add_window.Show();
                }
            }
            catch (System.ObjectDisposedException s) { }
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabControl.SelectedIndex == 0)
                {
                    Readers add_window = new Readers();
                    add_window.Owner = this;
                    add_window.Show();
                }
                if (tabControl.SelectedIndex == 1)
                {
                    Ticket add_window = new Ticket();
                    add_window.Owner = this;
                    add_window.Show();
                }
                if (tabControl.SelectedIndex == 2)
                {
                    Book_give add_window = new Book_give();
                    add_window.add_tr = false;
                    add_window.Owner = this;
                    add_window.Show();
                }
                if (tabControl.SelectedIndex == 3)
                {
                    Books add_window = new Books();
                    add_window.add_tr = false;
                    add_window.Owner = this;
                    add_window.Show();
                }
                if (tabControl.SelectedIndex == 4)
                {
                    Author add_window = new Author();
                    add_window.add_tr = false;
                    add_window.Owner = this;
                    add_window.Show();
                }
                if (tabControl.SelectedIndex == 5)
                {
                    Publisher add_window = new Publisher();
                    add_window.add_tr = false;
                    add_window.Owner = this;
                    add_window.Show();
                }
            }
            catch (System.ObjectDisposedException s){}
        }
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 6)
            {
                toolStrip1.Visible = false;
            }
            else
            {
                toolStrip1.Visible = true;
            }

            Log_list.Items.Clear();
            StreamReader Log_load = new StreamReader(@"Log.txt", true);
            while (!Log_load.EndOfStream)
            {
                Log_list.Items.Add(Log_load.ReadLine());
            }
            Log_load.Close();

            b_pubname.Items.Clear();
            int m = Convert.ToInt32(this.информация_о_издательствеTableAdapter.SumPublisher());
            for (int i = 1; i <= m; i++)
            {
                string publ;
                DataRow Load = this.libraryDataSet.Информация_о_издательстве.Rows.Find(i);
                publ = Convert.ToString(Load[0]);
                b_pubname.Items.Add(publ);
            }
        }

        private void open_log_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", @"Log.txt");
        }

        private void clear_logs_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"Log.txt", "");
            Log_list.Items.Clear();
        }

        private void Reader_find_Click(object sender, EventArgs e)
        {
            try
            {
                if (CB_find_reader.SelectedIndex == 0) //паспорт
                {
                    int id = Convert.ToInt32(this.информация_о_читателеTableAdapter.FindReader_pas(TB_find_reader.Text, TB_ser_pas.Text));
                    DataRow Load0 = this.libraryDataSet.Информация_о_читателе.Rows.Find(id);
                    TB_find_id.Text = Convert.ToString(Load0[7]);
                }
                if (CB_find_reader.SelectedIndex == 1) //телефон
                {
                    int id = Convert.ToInt32(this.информация_о_читателеTableAdapter.FindReader(TB_find_reader.Text));
                    DataRow Load1 = this.libraryDataSet.Информация_о_читателе.Rows.Find(id);
                    TB_find_id.Text = Convert.ToString(Load1[7]);
                }
                if (CB_find_reader.SelectedIndex == 2) //билет
                {
                    int? tn = Convert.ToInt32(TB_find_reader.Text);
                    int id = Convert.ToInt32(this.информация_о_читательском_билетеTableAdapter.FindTicket(tn));
                    DataRow Load2 = this.libraryDataSet.Информация_о_читательском_билете.Rows.Find(id);
                    TB_find_id.Text = Convert.ToString(Load2[4]);
                }
                
            }
            catch (System.FormatException s)
            {
                this.StatusLabel.Text = "Неверный формат ввода данных.";
                StreamWriter Log = new StreamWriter(@"Log.txt", true);
                string new_log = $"Неверный формат ввода данных. Исключение {s}\n";
                Log.WriteLine(new_log);
                Log.Close();
            }
            catch (System.OverflowException s)
            {
                this.StatusLabel.Text = $"Задано слишком большое значение.";
                StreamWriter Log = new StreamWriter(@"Log.txt", true);
                string new_log = ($"Переполнение переменной. Исключение {s}\n");
                Log.WriteLine(new_log);
                Log.Close();
            }
            catch (System.NullReferenceException s)
            {
                this.StatusLabel.Text = $"Данные неверны или отсутствуют.";
                StreamWriter Log = new StreamWriter(@"Log.txt", true);
                string new_log = ($"Данные неверны или отсутствуют. Исключение {s}\n");
                Log.WriteLine(new_log);
                Log.Close();
            }
        }

        private void CB_find_reader_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_find_reader.SelectedIndex == 0)
            {
                TB_inf_ser.Visible = true;
                TB_ser_pas.Visible = true;
            }
            else
            {
                TB_inf_ser.Visible = false;
                TB_ser_pas.Visible = false;
            }
        }

        private void Book_find_Click(object sender, EventArgs e)
        {
            try
            {
                int? pid = Convert.ToInt32(TB_pubbook.Text);
                int id = Convert.ToInt32(this.информация_о_книгеTableAdapter.FindBook(TB_name_book.Text, pid));
                DataRow Load = this.libraryDataSet.Информация_о_книге.Rows.Find(id);
                TB_find_book.Text = Convert.ToString(Load[7]);
            }
            catch (System.FormatException s)
            {
                this.StatusLabel.Text = "Неверный формат ввода данных.";
                StreamWriter Log = new StreamWriter(@"Log.txt", true);
                string new_log = $"Неверный формат ввода данных. Исключение {s}\n";
                Log.WriteLine(new_log);
                Log.Close();
            }
            catch (System.OverflowException s)
            {
                this.StatusLabel.Text = $"Задано слишком большое значение.";
                StreamWriter Log = new StreamWriter(@"Log.txt", true);
                string new_log = ($"Переполнение переменной. Исключение {s}\n");
                Log.WriteLine(new_log);
                Log.Close();
            }
            catch (System.NullReferenceException s)
            {
                this.StatusLabel.Text = $"Данные неверны или отсутствуют.";
                StreamWriter Log = new StreamWriter(@"Log.txt", true);
                string new_log = ($"Данные неверны или отсутствуют. Исключение {s}\n");
                Log.WriteLine(new_log);
                Log.Close();
            }
        }

        private void b_pubname_SelectedIndexChanged(object sender, EventArgs e)
        {
            TB_pubbook.Text = Convert.ToString(b_pubname.SelectedIndex + 1);
        }
    }
}
