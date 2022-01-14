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
    public partial class Readers : Form
    {
        public Readers()
        {
            InitializeComponent(); 
        }

        private void Readers_Load(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            try
            {
                if (main != null)
                {
                    int selectedRowIndex = main.DGVReaders.SelectedRows[0].Index;
                    int id = 0;
                    bool converted = Int32.TryParse(main.DGVReaders[0, selectedRowIndex].Value.ToString(), out id);
                    if (converted == false)
                        return;
                    DataRow Load = main.libraryDataSet.Информация_о_читателе.Rows.Find(id);
                    Rd_lastname.Text = Convert.ToString(Load[0]);
                    Rd_firstname.Text = Convert.ToString(Load[1]);
                    Rd_middlename.Text = Convert.ToString(Load[2]);
                    Rd_pasnum.Text = Convert.ToString(Load[3]);
                    Rd_passer.Text = Convert.ToString(Load[4]);
                    Rd_adress.Text = Convert.ToString(Load[5]);
                    Rd_phone.Text = Convert.ToString(Load[6]);
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

        private void Rd_return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Rd_cng_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            try
            {
                if (main != null)
                {
                    int selectedRowIndex = main.DGVReaders.SelectedRows[0].Index;
                    int id = 0;
                    bool converted = Int32.TryParse(main.DGVReaders[0, selectedRowIndex].Value.ToString(), out id);
                    if (converted == false)
                        return;
                    DataRow Load = main.libraryDataSet.Информация_о_читателе.Rows.Find(id);
                    Load[0] = Rd_lastname.Text;
                    Load[1] = Rd_firstname.Text;
                    Load[2] = Rd_middlename.Text;
                    Load[3] = Rd_pasnum.Text;
                    Load[4] = Rd_passer.Text;
                    Load[5] = Rd_adress.Text;
                    Load[6] = Rd_phone.Text;
                    main.информация_о_читателеTableAdapter.Update(main.libraryDataSet.Информация_о_читателе);
                    main.libraryDataSet.Информация_о_читателе.AcceptChanges();
                    main.DGVReaders.Refresh();
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
    }
}
