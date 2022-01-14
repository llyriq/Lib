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
    public partial class New_reader : Form
    {
        public New_reader()
        {
            InitializeComponent();
        }

        private void New_reader_Load(object sender, EventArgs e)
        {

        }

        private void Rd_return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Rd_add_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            try
            {
                if (main != null)
                {
                    DataRow Add_r = main.libraryDataSet.Информация_о_читателе.NewRow();
                    Add_r[0] = Rd_lastname.Text;
                    Add_r[1] = Rd_firstname.Text;
                    Add_r[2] = Rd_middlename.Text;
                    Add_r[3] = Rd_pasnum.Text;
                    Add_r[4] = Rd_passer.Text;
                    Add_r[5] = Rd_adress.Text;
                    Add_r[6] = Rd_phone.Text;
                    main.libraryDataSet.Информация_о_читателе.Rows.Add(Add_r);
                    main.информация_о_читателеTableAdapter.Update(main.libraryDataSet.Информация_о_читателе);
                    main.libraryDataSet.Информация_о_читателе.AcceptChanges();
                    main.DGVReaders.Refresh();

                    int reader_id = Convert.ToInt32(main.информация_о_читателеTableAdapter.FindReader(Rd_phone.Text));

                    DataRow Add_t = main.libraryDataSet.Информация_о_читательском_билете.NewRow();
                    Add_t[0] = Rd_lastname.Text;
                    Add_t[1] = Convert.ToInt32(Rd_tinum.Text);
                    Add_t[2] = 10;
                    Add_t[3] = 0;
                    Add_t[5] = reader_id;
                    main.libraryDataSet.Информация_о_читательском_билете.Rows.Add(Add_t);
                    main.информация_о_читательском_билетеTableAdapter.Update(main.libraryDataSet.Информация_о_читательском_билете);
                    main.libraryDataSet.Информация_о_читательском_билете.AcceptChanges();
                    main.DGVTickets.Refresh();
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
    }
}
