using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovoi_proekt
{
    public partial class Book_give : Form
    {
        public bool add_tr;

        public Book_give()
        {
            InitializeComponent();
        }

        private void Book_give_Load(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                int l = Convert.ToInt32(main.информация_об_автореTableAdapter.SumAuthor());
                if (l == 0)
                {
                    main.StatusLabel.Text = "Не найдены авторы.";
                    StreamWriter Log = new StreamWriter(@"Log.txt", true);
                    string new_log = $"Не найдены авторы. Ошибка №1\n";
                    Log.WriteLine(new_log);
                    Log.Close();
                    this.Close();
                }
                for (int i = 1; i <= l; i++)
                {
                    string author;
                    DataRow Load = main.libraryDataSet.Информация_об_авторе.Rows.Find(i);
                    author = Convert.ToString(Load[0]);
                    Bg_authorname.Items.Add(author);
                }

                if (add_tr == true)
                {
                    this.Add_button.Visible = true;
                    this.Cng_button.Visible = false;
                }
                else
                {
                    this.Add_button.Visible = false;
                    this.Cng_button.Visible = true;
                    try
                    {
                        int selectedRowIndex = main.DGVBook_give.SelectedRows[0].Index;
                        int id = 0;
                        bool converted = Int32.TryParse(main.DGVBook_give[0, selectedRowIndex].Value.ToString(), out id);
                        if (converted == false)
                            return;
                        DataRow Load = main.libraryDataSet.Информация_о_выдаче.Rows.Find(id);
                        Bg_dategive.Value = Convert.ToDateTime(Load[0]);
                        Bg_datereturn.Value = Convert.ToDateTime(Load[1]);
                        Bg_booktitle.Text = Convert.ToString(Load[2]);
                        Bg_bookprice.Text = Convert.ToString(Load[3]);
                        Bg_tickreturn.Text = Convert.ToString(Load[4]);

                        Bg_bookid.Text = Convert.ToString(Load[6]);
                        Bg_ticketid.Text = Convert.ToString(Load[7]);
                        Bg_authorid.Text = Convert.ToString(Load[8]);
                        Bg_authorname.SelectedIndex = Convert.ToInt32(Bg_authorid.Text) - 1;
                    }
                    catch (System.ArgumentOutOfRangeException s)
                    {
                        main.StatusLabel.Text = "Не выбрана строка.";
                        StreamWriter Log = new StreamWriter(@"Log.txt", true);
                        string new_log = $"Не выбрана строка. Исключение {s}\n";
                        Log.WriteLine(new_log);
                        Log.Close();
                        this.Close();
                    }
                }
            }
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            try
            {
                if (main != null)
                {
                    DataRow Add = main.libraryDataSet.Информация_о_выдаче.NewRow();
                    Add[0] = Bg_dategive.Value;
                    Add[1] = Bg_datereturn.Value;
                    Add[2] = Bg_booktitle.Text;
                    Add[3] = Convert.ToDecimal(Bg_bookprice.Text);
                    Add[4] = Convert.ToInt32(Bg_tickreturn.Text);

                    Add[6] = Convert.ToInt32(Bg_bookid.Text);
                    Add[7] = Convert.ToInt32(Bg_ticketid.Text);
                    Add[8] = Convert.ToInt32(Bg_authorid.Text);
                    main.libraryDataSet.Информация_о_выдаче.Rows.Add(Add);
                    main.информация_о_выдачеTableAdapter.Update(main.libraryDataSet.Информация_о_выдаче);
                    main.libraryDataSet.Информация_о_выдаче.AcceptChanges();
                    main.DGVBook_give.Refresh();
                    main.StatusLabel.Text = "Строка добавлена.";
                }
                this.Close();
            }
            catch (System.FormatException s)
            {
                main.StatusLabel.Text = "Неверный формат ввода данных.";
                StreamWriter Log = new StreamWriter(@"Log.txt", true);
                string new_log = $"Неверный формат ввода данных. Исключение {s}\n";
                Log.WriteLine(new_log);
                Log.Close();
            }
            catch (System.OverflowException s)
            {
                main.StatusLabel.Text = $"Задано слишком большое значение.";
                StreamWriter Log = new StreamWriter(@"Log.txt", true);
                string new_log = ($"Переполнение переменной. Исключение {s}\n");
                Log.WriteLine(new_log);
                Log.Close();
            }
            catch (System.Data.ConstraintException s)
            {
                main.StatusLabel.Text = $"В таблице уже имеется такое уникальное значение.";
                StreamWriter Log = new StreamWriter(@"Log.txt", true);
                string new_log = ($"В таблице уже имеется такое уникальное значение. Исключение {s}\n");
                Log.WriteLine(new_log);
                Log.Close();
            }
        }

        private void Cng_button_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            try
            {
                if (main != null)
                {
                    int selectedRowIndex = main.DGVBook_give.SelectedRows[0].Index;
                    int id = 0;
                    bool converted = Int32.TryParse(main.DGVBook_give[0, selectedRowIndex].Value.ToString(), out id);
                    if (converted == false)
                        return;
                    DataRow Load = main.libraryDataSet.Информация_о_выдаче.Rows.Find(id);
                    Load[0] = Bg_dategive.Value;
                    Load[1] = Bg_datereturn.Value;
                    Load[2] = Bg_booktitle.Text;
                    Load[3] = Convert.ToDecimal(Bg_bookprice.Text);
                    Load[4] = Convert.ToInt32(Bg_tickreturn.Text);

                    Load[6] = Convert.ToInt32(Bg_bookid.Text);
                    Load[7] = Convert.ToInt32(Bg_ticketid.Text);
                    Load[8] = Convert.ToInt32(Bg_authorid.Text);
                    main.информация_о_выдачеTableAdapter.Update(main.libraryDataSet.Информация_о_выдаче);
                    main.libraryDataSet.Информация_о_выдаче.AcceptChanges();
                    main.DGVBook_give.Refresh();
                    main.StatusLabel.Text = "Строка изменена.";
                }
                this.Close();
            }
            catch (System.FormatException s)
            {
                main.StatusLabel.Text = "Неверный формат ввода данных.";
                StreamWriter Log = new StreamWriter(@"Log.txt", true);
                string new_log = $"Неверный формат ввода данных. Исключение {s}\n";
                Log.WriteLine(new_log);
                Log.Close();
            }
            catch (System.OverflowException s)
            {
                main.StatusLabel.Text = $"Задано слишком большое значение.";
                StreamWriter Log = new StreamWriter(@"Log.txt", true);
                string new_log = ($"Переполнение переменной. Исключение {s}\n");
                Log.WriteLine(new_log);
                Log.Close();
            }
            catch (System.Data.ConstraintException s)
            {
                main.StatusLabel.Text = $"В таблице уже имеется такое уникальное значение.";
                StreamWriter Log = new StreamWriter(@"Log.txt", true);
                string new_log = ($"В таблице уже имеется такое уникальное значение. Исключение {s}\n");
                Log.WriteLine(new_log);
                Log.Close();
            }
        }

        private void Return_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bg_authorname_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bg_authorid.Text = Convert.ToString(Bg_authorname.SelectedIndex + 1);
        }
    }
}
