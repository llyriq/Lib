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
    public partial class Author : Form
    {
        public bool add_tr;

        public Author()
        {
            InitializeComponent();
        }

        private void Author_Load(object sender, EventArgs e)
        {
            if (add_tr == true)
            {
                this.Add_button.Visible = true;
                this.Cng_button.Visible = false;
            }
            else
            {
                this.Add_button.Visible = false;
                this.Cng_button.Visible = true;
                Form1 main = this.Owner as Form1;
                try
                {
                    if (main != null)
                    {
                        int selectedRowIndex = main.DGVAuthor.SelectedRows[0].Index;
                        int id = 0;
                        bool converted = Int32.TryParse(main.DGVAuthor[0, selectedRowIndex].Value.ToString(), out id);
                        if (converted == false)
                            return;
                        DataRow Load = main.libraryDataSet.Информация_об_авторе.Rows.Find(id);
                        At_lastname.Text = Convert.ToString(Load[0]);
                        At_numbook.Text = Convert.ToString(Load[1]);
                        At_ratingbooks.Text = Convert.ToString(Load[2]);
                        At_bestsellers.Text = Convert.ToString(Load[3]);
                        At_mostpopular.Text = Convert.ToString(Load[4]);
                    }
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

        private void Add_button_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            try
            {
                if (main != null)
                {
                    DataRow Add = main.libraryDataSet.Информация_об_авторе.NewRow();
                    Add[0] = At_lastname.Text;
                    Add[1] = Convert.ToInt32(At_numbook.Text);
                    Add[2] = At_ratingbooks.Text;
                    Add[3] = Convert.ToInt32(At_bestsellers.Text);
                    Add[4] = At_mostpopular.Text;

                    main.libraryDataSet.Информация_об_авторе.Rows.Add(Add);
                    main.информация_об_автореTableAdapter.Update(main.libraryDataSet.Информация_об_авторе);
                    main.libraryDataSet.Информация_об_авторе.AcceptChanges();
                    main.DGVAuthor.Refresh();
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
                    int selectedRowIndex = main.DGVAuthor.SelectedRows[0].Index;
                    int id = 0;
                    bool converted = Int32.TryParse(main.DGVAuthor[0, selectedRowIndex].Value.ToString(), out id);
                    if (converted == false)
                        return;
                    DataRow Load = main.libraryDataSet.Информация_об_авторе.Rows.Find(id);
                    Load[0] = At_lastname.Text;
                    Load[1] = Convert.ToInt32(At_numbook.Text);
                    Load[2] = At_ratingbooks.Text;
                    Load[3] = Convert.ToInt32(At_bestsellers.Text);
                    Load[4] = At_mostpopular.Text;
                    main.информация_об_автореTableAdapter.Update(main.libraryDataSet.Информация_об_авторе);
                    main.libraryDataSet.Информация_об_авторе.AcceptChanges();
                    main.DGVAuthor.Refresh();
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
    }
}
