namespace HovSedhep
{
    partial class HistoryUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel4 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            cmbTable = new ComboBox();
            dteDate = new DateTimePicker();
            btnApply = new Button();
            label4 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            panel5 = new Panel();
            dataGridView2 = new DataGridView();
            panel6 = new Panel();
            label5 = new Label();
            panel7 = new Panel();
            dataGridView3 = new DataGridView();
            panel8 = new Panel();
            label6 = new Label();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.DodgerBlue;
            panel4.Controls.Add(label2);
            panel4.Location = new Point(82, 7);
            panel4.Name = "panel4";
            panel4.Size = new Size(121, 39);
            panel4.TabIndex = 21;
            // 
            // label2
            // 
            label2.BackColor = Color.DodgerBlue;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(121, 39);
            label2.TabIndex = 1;
            label2.Text = "Filter";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(cmbTable);
            panel3.Controls.Add(dteDate);
            panel3.Controls.Add(btnApply);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(54, 25);
            panel3.Name = "panel3";
            panel3.Size = new Size(1545, 158);
            panel3.TabIndex = 20;
            // 
            // cmbTable
            // 
            cmbTable.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTable.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbTable.FormattingEnabled = true;
            cmbTable.Location = new Point(284, 96);
            cmbTable.Name = "cmbTable";
            cmbTable.Size = new Size(403, 40);
            cmbTable.TabIndex = 5;
            // 
            // dteDate
            // 
            dteDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dteDate.Location = new Point(284, 21);
            dteDate.Name = "dteDate";
            dteDate.Size = new Size(403, 39);
            dteDate.TabIndex = 4;
            // 
            // btnApply
            // 
            btnApply.BackColor = SystemColors.ActiveCaption;
            btnApply.FlatStyle = FlatStyle.Flat;
            btnApply.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApply.Location = new Point(777, 91);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(173, 49);
            btnApply.TabIndex = 2;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = false;
            btnApply.Click += btnApply_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(66, 97);
            label4.Name = "label4";
            label4.Size = new Size(148, 32);
            label4.TabIndex = 0;
            label4.Text = "Table Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(69, 26);
            label3.Name = "label3";
            label3.Size = new Size(67, 32);
            label3.TabIndex = 0;
            label3.Text = "Date";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(82, 205);
            panel1.Name = "panel1";
            panel1.Size = new Size(172, 39);
            panel1.TabIndex = 23;
            // 
            // label1
            // 
            label1.BackColor = Color.DodgerBlue;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(172, 39);
            label1.TabIndex = 1;
            label1.Text = "Transaction";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(54, 223);
            panel2.Name = "panel2";
            panel2.Size = new Size(1545, 226);
            panel2.TabIndex = 22;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1491, 163);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(dataGridView2);
            panel5.Location = new Point(54, 491);
            panel5.Name = "panel5";
            panel5.Size = new Size(1545, 226);
            panel5.TabIndex = 22;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(27, 35);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(1491, 163);
            dataGridView2.TabIndex = 1;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // panel6
            // 
            panel6.BackColor = Color.DodgerBlue;
            panel6.Controls.Add(label5);
            panel6.Location = new Point(82, 473);
            panel6.Name = "panel6";
            panel6.Size = new Size(111, 39);
            panel6.TabIndex = 23;
            // 
            // label5
            // 
            label5.BackColor = Color.DodgerBlue;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(111, 39);
            label5.TabIndex = 1;
            label5.Text = "Order";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(dataGridView3);
            panel7.Location = new Point(54, 757);
            panel7.Name = "panel7";
            panel7.Size = new Size(1545, 226);
            panel7.TabIndex = 22;
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView3.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(27, 36);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.RowHeadersVisible = false;
            dataGridView3.RowHeadersWidth = 62;
            dataGridView3.Size = new Size(1491, 163);
            dataGridView3.TabIndex = 1;
            dataGridView3.CellClick += dataGridView1_CellClick;
            // 
            // panel8
            // 
            panel8.BackColor = Color.DodgerBlue;
            panel8.Controls.Add(label6);
            panel8.Location = new Point(82, 739);
            panel8.Name = "panel8";
            panel8.Size = new Size(172, 39);
            panel8.TabIndex = 23;
            // 
            // label6
            // 
            label6.BackColor = Color.DodgerBlue;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(172, 39);
            label6.TabIndex = 1;
            label6.Text = "Order Detail";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HistoryUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel8);
            Controls.Add(panel6);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panel7);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Name = "HistoryUC";
            Size = new Size(1653, 1063);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            panel8.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private Label label2;
        private Panel panel3;
        private Button btnApply;
        private Label label4;
        private Label label3;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Panel panel5;
        private Panel panel6;
        private Label label5;
        private Panel panel7;
        private DataGridView dataGridView3;
        private Panel panel8;
        private Label label6;
        private ComboBox cmbTable;
        private DateTimePicker dteDate;
        private DataGridView dataGridView2;
    }
}
