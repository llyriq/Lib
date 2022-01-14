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
    public partial class Books : Form
    {
        public bool add_tr;

        public Books()
        {
            InitializeComponent();
        }

        private void Books_Load(object sender, EventArgs e)
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
                    Bk_authorname.Items.Add(author);
                }

                int m = Convert.ToInt32(main.информация_о_издательствеTableAdapter.SumPublisher());
                if (m == 0)
                {
                    main.StatusLabel.Text = "Не найдены издательства.";
                    StreamWriter Log = new StreamWriter(@"Log.txt", true);
                    string new_log = $"Не найдены издательства. Ошибка №2\n";
                    Log.WriteLine(new_log);
                    Log.Close();
                    this.Close();
                }
                for (int i = 1; i <= m; i++)
                {
                    string publ;
                    DataRow Load = main.libraryDataSet.Информация_о_издательстве.Rows.Find(i);
                    publ = Convert.ToString(Load[0]);
                    Bk_pubname.Items.Add(publ);
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


                        int selectedRowIndex = main.DGVBooks.SelectedRows[0].Index;
                        int id = 0;
                        bool converted = Int32.TryParse(main.DGVBooks[0, selectedRowIndex].Value.ToString(), out id);
                        if (converted == false)
                            return;
                        DataRow Load = main.libraryDataSet.Информация_о_книге.Rows.Find(id);
                        Bk_booktitle.Text = Convert.ToString(Load[0]);
                        Bk_numpages.Text = Convert.ToString(Load[1]);
                        Bk_bestseller.Text = Convert.ToString(Load[2]);
                        Bk_located.Text = Convert.ToString(Load[3]);
                        Bk_rating.Text = Convert.ToString(Load[4]);
                        Bk_aviable.Text = Convert.ToString(Load[5]);
                        int ch = 0;
                        for (int i = 0; i < l; i++)
                        {
                            Bk_authorname.SelectedIndex = i;
                            if (Convert.ToString(Load[6]) == Bk_authorname.SelectedItem.ToString())
                            {
                                ch = i;
                            }
                        }
                        Bk_authorname.SelectedIndex = ch;
                        Bk_pubid.Text = Convert.ToString(Load[8]);
                        Bk_pubname.SelectedIndex = Convert.ToInt32(Bk_pubid.Text) - 1;
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
                    DataRow Add = main.libraryDataSet.Информация_о_книге.NewRow();
                    Add[0] = Bk_booktitle.Text;
                    Add[1] = Convert.ToInt32(Bk_numpages.Text);
                    Add[2] = Bk_bestseller.Text;
                    Add[3] = Convert.ToInt32(Bk_located.Text);
                    Add[4] = Convert.ToSingle(Bk_rating.Text);
                    Add[5] = Bk_aviable.Text;
                    Add[6] = Bk_authorname.SelectedItem.ToString();
                    Add[8] = Convert.ToInt32(Bk_pubid.Text);
                    main.libraryDataSet.Информация_о_книге.Rows.Add(Add);
                    main.информация_о_книгеTableAdapter.Update(main.libraryDataSet.Информация_о_книге);
                    main.libraryDataSet.Информация_о_книге.AcceptChanges();
                    main.DGVBooks.Refresh();
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
                    int selectedRowIndex = main.DGVBooks.SelectedRows[0].Index;
                    int id = 0;
                    bool converted = Int32.TryParse(main.DGVBooks[0, selectedRowIndex].Value.ToString(), out id);
                    if (converted == false)
                        return;
                    DataRow Load = main.libraryDataSet.Информация_о_книге.Rows.Find(id);
                    Load[0] = Bk_booktitle.Text;
                    Load[1] = Convert.ToInt32(Bk_numpages.Text);
                    Load[2] = Bk_bestseller.Text;
                    Load[3] = Convert.ToInt32(Bk_located.Text);
                    Load[4] = Convert.ToSingle(Bk_rating.Text);
                    Load[5] = Bk_aviable.Text;
                    Load[6] = Bk_authorname.SelectedItem.ToString();
                    Load[8] = Convert.ToInt32(Bk_pubid.Text);
                    main.информация_о_книгеTableAdapter.Update(main.libraryDataSet.Информация_о_книге);
                    main.libraryDataSet.Информация_о_книге.AcceptChanges();
                    main.DGVBooks.Refresh();
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

        private void Bk_pubname_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bk_pubid.Text = Convert.ToString(Bk_pubname.SelectedIndex + 1);
        }
    }
}
