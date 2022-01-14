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
    public partial class Publisher : Form
    {
        public bool add_tr;

        public Publisher()
        {
            InitializeComponent();
        }

        private void Publisher_Load(object sender, EventArgs e)
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
                        int selectedRowIndex = main.DGVPublisher.SelectedRows[0].Index;
                        int id = 0;
                        bool converted = Int32.TryParse(main.DGVPublisher[0, selectedRowIndex].Value.ToString(), out id);
                        if (converted == false)
                            return;
                        DataRow Load = main.libraryDataSet.Информация_о_издательстве.Rows.Find(id);
                        Pb_publisher.Text = Convert.ToString(Load[0]);
                        Pb_city.Text = Convert.ToString(Load[1]);
                        Pb_mail.Text = Convert.ToString(Load[2]);
                        Pb_website.Text = Convert.ToString(Load[3]);
                        Pb_phone.Text = Convert.ToString(Load[4]);
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
                    DataRow Add = main.libraryDataSet.Информация_о_издательстве.NewRow();
                    Add[0] = Pb_publisher.Text;
                    Add[1] = Pb_city.Text;
                    Add[2] = Pb_mail.Text;
                    Add[3] = Pb_website.Text;
                    Add[4] = Pb_phone.Text;

                    main.libraryDataSet.Информация_о_издательстве.Rows.Add(Add);
                    main.информация_о_издательствеTableAdapter.Update(main.libraryDataSet.Информация_о_издательстве);
                    main.libraryDataSet.Информация_о_издательстве.AcceptChanges();
                    main.DGVPublisher.Refresh();
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
                    int selectedRowIndex = main.DGVPublisher.SelectedRows[0].Index;
                    int id = 0;
                    bool converted = Int32.TryParse(main.DGVPublisher[0, selectedRowIndex].Value.ToString(), out id);
                    if (converted == false)
                        return;
                    DataRow Load = main.libraryDataSet.Информация_о_издательстве.Rows.Find(id);
                    Load[0] = Pb_publisher.Text;
                    Load[1] = Pb_city.Text;
                    Load[2] = Pb_mail.Text;
                    Load[3] = Pb_website.Text;
                    Load[4] = Pb_phone.Text;
                    main.информация_о_издательствеTableAdapter.Update(main.libraryDataSet.Информация_о_издательстве);
                    main.libraryDataSet.Информация_о_издательстве.AcceptChanges();
                    main.DGVPublisher.Refresh();
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
