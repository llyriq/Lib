namespace Kursovoi_proekt
{
    partial class Book_give
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book_give));
            this.Add_button = new System.Windows.Forms.Button();
            this.Return_button = new System.Windows.Forms.Button();
            this.Cng_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Bg_ticketid = new System.Windows.Forms.TextBox();
            this.Bg_tickreturn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Bg_booktitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Bg_bookprice = new System.Windows.Forms.TextBox();
            this.Bg_bookid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Bg_dategive = new System.Windows.Forms.DateTimePicker();
            this.Bg_datereturn = new System.Windows.Forms.DateTimePicker();
            this.Bg_authorid = new System.Windows.Forms.TextBox();
            this.Bg_authorname = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Add_button
            // 
            this.Add_button.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_button.Location = new System.Drawing.Point(12, 221);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(170, 31);
            this.Add_button.TabIndex = 1;
            this.Add_button.Text = "Добавить";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Return_button
            // 
            this.Return_button.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Return_button.Location = new System.Drawing.Point(204, 221);
            this.Return_button.Name = "Return_button";
            this.Return_button.Size = new System.Drawing.Size(170, 31);
            this.Return_button.TabIndex = 3;
            this.Return_button.Text = "Отмена";
            this.Return_button.UseVisualStyleBackColor = true;
            this.Return_button.Click += new System.EventHandler(this.Return_button_Click);
            // 
            // Cng_button
            // 
            this.Cng_button.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cng_button.Location = new System.Drawing.Point(12, 221);
            this.Cng_button.Name = "Cng_button";
            this.Cng_button.Size = new System.Drawing.Size(170, 31);
            this.Cng_button.TabIndex = 4;
            this.Cng_button.Text = "Изменить";
            this.Cng_button.UseVisualStyleBackColor = true;
            this.Cng_button.Visible = false;
            this.Cng_button.Click += new System.EventHandler(this.Cng_button_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 292F));
            this.tableLayoutPanel2.Controls.Add(this.Bg_ticketid, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.Bg_tickreturn, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Bg_booktitle, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Bg_bookprice, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.Bg_bookid, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.Bg_dategive, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.Bg_datereturn, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.Bg_authorid, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.Bg_authorname, 1, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(362, 203);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // Bg_ticketid
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.Bg_ticketid, 2);
            this.Bg_ticketid.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.Bg_ticketid.Location = new System.Drawing.Point(147, 178);
            this.Bg_ticketid.Name = "Bg_ticketid";
            this.Bg_ticketid.Size = new System.Drawing.Size(210, 20);
            this.Bg_ticketid.TabIndex = 20;
            // 
            // Bg_tickreturn
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.Bg_tickreturn, 2);
            this.Bg_tickreturn.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.Bg_tickreturn.Location = new System.Drawing.Point(147, 153);
            this.Bg_tickreturn.Name = "Bg_tickreturn";
            this.Bg_tickreturn.Size = new System.Drawing.Size(210, 20);
            this.Bg_tickreturn.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(3, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Дата выдачи";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Наименование книги";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Bg_booktitle
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.Bg_booktitle, 2);
            this.Bg_booktitle.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.Bg_booktitle.Location = new System.Drawing.Point(147, 3);
            this.Bg_booktitle.Name = "Bg_booktitle";
            this.Bg_booktitle.Size = new System.Drawing.Size(210, 20);
            this.Bg_booktitle.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(3, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Код автора";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(3, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Стоимость книги";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Bg_bookprice
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.Bg_bookprice, 2);
            this.Bg_bookprice.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.Bg_bookprice.Location = new System.Drawing.Point(147, 28);
            this.Bg_bookprice.Name = "Bg_bookprice";
            this.Bg_bookprice.Size = new System.Drawing.Size(210, 20);
            this.Bg_bookprice.TabIndex = 9;
            // 
            // Bg_bookid
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.Bg_bookid, 2);
            this.Bg_bookid.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.Bg_bookid.Location = new System.Drawing.Point(147, 53);
            this.Bg_bookid.Name = "Bg_bookid";
            this.Bg_bookid.Size = new System.Drawing.Size(210, 20);
            this.Bg_bookid.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Код книги";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(3, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Дата возврата";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(3, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Билет возвратившего";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(3, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 23);
            this.label9.TabIndex = 16;
            this.label9.Text = "Код билета";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Bg_dategive
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.Bg_dategive, 2);
            this.Bg_dategive.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.Bg_dategive.Location = new System.Drawing.Point(147, 103);
            this.Bg_dategive.Name = "Bg_dategive";
            this.Bg_dategive.Size = new System.Drawing.Size(210, 20);
            this.Bg_dategive.TabIndex = 21;
            this.Bg_dategive.Value = new System.DateTime(2015, 5, 15, 0, 0, 0, 0);
            // 
            // Bg_datereturn
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.Bg_datereturn, 2);
            this.Bg_datereturn.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.Bg_datereturn.Location = new System.Drawing.Point(147, 128);
            this.Bg_datereturn.Name = "Bg_datereturn";
            this.Bg_datereturn.Size = new System.Drawing.Size(210, 20);
            this.Bg_datereturn.TabIndex = 22;
            this.Bg_datereturn.Value = new System.DateTime(2015, 6, 2, 0, 0, 0, 0);
            // 
            // Bg_authorid
            // 
            this.Bg_authorid.BackColor = System.Drawing.SystemColors.Window;
            this.Bg_authorid.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.Bg_authorid.Location = new System.Drawing.Point(311, 78);
            this.Bg_authorid.Name = "Bg_authorid";
            this.Bg_authorid.ReadOnly = true;
            this.Bg_authorid.Size = new System.Drawing.Size(46, 20);
            this.Bg_authorid.TabIndex = 8;
            // 
            // Bg_authorname
            // 
            this.Bg_authorname.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.Bg_authorname.FormattingEnabled = true;
            this.Bg_authorname.Location = new System.Drawing.Point(147, 78);
            this.Bg_authorname.Name = "Bg_authorname";
            this.Bg_authorname.Size = new System.Drawing.Size(158, 22);
            this.Bg_authorname.TabIndex = 23;
            this.Bg_authorname.SelectedIndexChanged += new System.EventHandler(this.Bg_authorname_SelectedIndexChanged);
            // 
            // Book_give
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(386, 264);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.Cng_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.Return_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Book_give";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Выдача книги";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Book_give_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button Return_button;
        private System.Windows.Forms.Button Cng_button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox Bg_ticketid;
        private System.Windows.Forms.TextBox Bg_tickreturn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Bg_booktitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Bg_bookprice;
        private System.Windows.Forms.TextBox Bg_bookid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker Bg_dategive;
        private System.Windows.Forms.DateTimePicker Bg_datereturn;
        private System.Windows.Forms.TextBox Bg_authorid;
        private System.Windows.Forms.ComboBox Bg_authorname;
    }
}