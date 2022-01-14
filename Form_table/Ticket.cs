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
    public partial class Ticket : Form
    {
        public Ticket()
        {
            InitializeComponent();
        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            try
            {
                if (main != null)
                {
                    int selectedRowIndex = main.DGVTickets.SelectedRows[0].Index;
                    int id = 0;
                    bool converted = Int32.TryParse(main.DGVTickets[0, selectedRowIndex].Value.ToString(), out id);
                    if (converted == false)
                        return;
                    DataRow Load = main.libraryDataSet.Информация_о_читательском_билете.Rows.Find(id);
                    Ti_lastname.Text = Convert.ToString(Load[0]);
                    Ti_ticketnum.Text = Convert.ToString(Load[1]);
                    Ti_readerrating.Text = Convert.ToString(Load[2]);
                    Ti_debts.Text = Convert.ToString(Load[3]);
                    Ti_readerid.Text = Convert.ToString(Load[5]);
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

        private void Rd_cng_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            try
            {
                if (main != null)
                {
                    int selectedRowIndex = main.DGVTickets.SelectedRows[0].Index;
                    int id = 0;
                    bool converted = Int32.TryParse(main.DGVTickets[0, selectedRowIndex].Value.ToString(), out id);
                    if (converted == false)
                        return;
                    DataRow Load = main.libraryDataSet.Информация_о_читательском_билете.Rows.Find(id);
                    Load[0] = Ti_lastname.Text;
                    Load[1] = Convert.ToInt32(Ti_ticketnum.Text);
                    Load[2] = Convert.ToInt32(Ti_readerrating.Text);
                    Load[3] = Convert.ToInt32(Ti_debts.Text);
                    Load[5] = Convert.ToInt32(Ti_readerid.Text);
                    main.информация_о_читательском_билетеTableAdapter.Update(main.libraryDataSet.Информация_о_читательском_билете);
                    main.libraryDataSet.Информация_о_читательском_билете.AcceptChanges();
                    main.DGVTickets.Refresh();
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

        private void Rd_return_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
