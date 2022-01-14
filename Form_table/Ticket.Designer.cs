namespace Kursovoi_proekt
{
    partial class Ticket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ticket));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.Ti_debts = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Ti_readerrating = new System.Windows.Forms.TextBox();
            this.Ti_ticketnum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Ti_lastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Ti_readerid = new System.Windows.Forms.TextBox();
            this.Rd_return = new System.Windows.Forms.Button();
            this.Rd_cng = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.00719F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.99281F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Ti_debts, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Ti_readerrating, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Ti_ticketnum, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Ti_lastname, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Ti_readerid, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 15);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(481, 164);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(4, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 36);
            this.label4.TabIndex = 1;
            this.label4.Text = "Задолжности";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Ti_debts
            // 
            this.Ti_debts.Dock = System.Windows.Forms.DockStyle.Right;
            this.Ti_debts.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ti_debts.Location = new System.Drawing.Point(202, 132);
            this.Ti_debts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Ti_debts.Name = "Ti_debts";
            this.Ti_debts.Size = new System.Drawing.Size(275, 23);
            this.Ti_debts.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(4, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Рейтинг читателя";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Ti_readerrating
            // 
            this.Ti_readerrating.Dock = System.Windows.Forms.DockStyle.Right;
            this.Ti_readerrating.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ti_readerrating.Location = new System.Drawing.Point(202, 100);
            this.Ti_readerrating.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Ti_readerrating.Name = "Ti_readerrating";
            this.Ti_readerrating.Size = new System.Drawing.Size(275, 23);
            this.Ti_readerrating.TabIndex = 8;
            // 
            // Ti_ticketnum
            // 
            this.Ti_ticketnum.Dock = System.Windows.Forms.DockStyle.Right;
            this.Ti_ticketnum.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ti_ticketnum.Location = new System.Drawing.Point(202, 4);
            this.Ti_ticketnum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Ti_ticketnum.Name = "Ti_ticketnum";
            this.Ti_ticketnum.Size = new System.Drawing.Size(275, 23);
            this.Ti_ticketnum.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(4, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "Номер билета";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(4, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Ti_lastname
            // 
            this.Ti_lastname.Dock = System.Windows.Forms.DockStyle.Right;
            this.Ti_lastname.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ti_lastname.Location = new System.Drawing.Point(202, 68);
            this.Ti_lastname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Ti_lastname.Name = "Ti_lastname";
            this.Ti_lastname.Size = new System.Drawing.Size(275, 23);
            this.Ti_lastname.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(4, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Код читателя";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Ti_readerid
            // 
            this.Ti_readerid.Dock = System.Windows.Forms.DockStyle.Right;
            this.Ti_readerid.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ti_readerid.Location = new System.Drawing.Point(202, 36);
            this.Ti_readerid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Ti_readerid.Name = "Ti_readerid";
            this.Ti_readerid.Size = new System.Drawing.Size(275, 23);
            this.Ti_readerid.TabIndex = 9;
            // 
            // Rd_return
            // 
            this.Rd_return.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rd_return.Location = new System.Drawing.Point(272, 186);
            this.Rd_return.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Rd_return.Name = "Rd_return";
            this.Rd_return.Size = new System.Drawing.Size(227, 38);
            this.Rd_return.TabIndex = 3;
            this.Rd_return.Text = "Отмена";
            this.Rd_return.UseVisualStyleBackColor = true;
            this.Rd_return.Click += new System.EventHandler(this.Rd_return_Click);
            // 
            // Rd_cng
            // 
            this.Rd_cng.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rd_cng.Location = new System.Drawing.Point(16, 186);
            this.Rd_cng.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Rd_cng.Name = "Rd_cng";
            this.Rd_cng.Size = new System.Drawing.Size(227, 38);
            this.Rd_cng.TabIndex = 4;
            this.Rd_cng.Text = "Изменить";
            this.Rd_cng.UseVisualStyleBackColor = true;
            this.Rd_cng.Click += new System.EventHandler(this.Rd_cng_Click);
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(515, 239);
            this.Controls.Add(this.Rd_cng);
            this.Controls.Add(this.Rd_return);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Ticket";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Читательский билет";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Ticket_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Ti_lastname;
        private System.Windows.Forms.TextBox Ti_debts;
        private System.Windows.Forms.TextBox Ti_readerid;
        private System.Windows.Forms.TextBox Ti_readerrating;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Rd_return;
        private System.Windows.Forms.Button Rd_cng;
        private System.Windows.Forms.TextBox Ti_ticketnum;
        private System.Windows.Forms.Label label5;
    }
}