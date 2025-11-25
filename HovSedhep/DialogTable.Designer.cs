namespace HovSedhep
{
    partial class DialogTable
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
            panel1 = new Panel();
            lblTable = new Label();
            btnClose = new Button();
            btnCancel = new Button();
            btnOk = new Button();
            cmbWaitress = new ComboBox();
            nmrSize = new NumericUpDown();
            txtName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnFinish = new Button();
            btnCancelTable = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrSize).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTable);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(737, 43);
            panel1.TabIndex = 6;
            // 
            // lblTable
            // 
            lblTable.AutoSize = true;
            lblTable.Font = new Font("Segoe UI Black", 13F, FontStyle.Bold);
            lblTable.ForeColor = SystemColors.WindowFrame;
            lblTable.Location = new Point(12, 6);
            lblTable.Name = "lblTable";
            lblTable.Size = new Size(228, 36);
            lblTable.TabIndex = 1;
            lblTable.Text = "Assign Table - []";
            // 
            // btnClose
            // 
            btnClose.AutoSize = true;
            btnClose.Dock = DockStyle.Right;
            btnClose.ForeColor = Color.Red;
            btnClose.Location = new Point(689, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(48, 43);
            btnClose.TabIndex = 0;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Khaki;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(483, 306);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(189, 49);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnOk
            // 
            btnOk.BackColor = SystemColors.ActiveCaption;
            btnOk.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOk.Location = new Point(71, 306);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(189, 49);
            btnOk.TabIndex = 14;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // cmbWaitress
            // 
            cmbWaitress.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbWaitress.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            cmbWaitress.FormattingEnabled = true;
            cmbWaitress.Location = new Point(335, 78);
            cmbWaitress.Name = "cmbWaitress";
            cmbWaitress.Size = new Size(337, 44);
            cmbWaitress.TabIndex = 12;
            // 
            // nmrSize
            // 
            nmrSize.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            nmrSize.Location = new Point(335, 223);
            nmrSize.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            nmrSize.Name = "nmrSize";
            nmrSize.Size = new Size(335, 42);
            nmrSize.TabIndex = 11;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            txtName.Location = new Point(335, 152);
            txtName.Name = "txtName";
            txtName.Size = new Size(335, 42);
            txtName.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label3.Location = new Point(71, 227);
            label3.Name = "label3";
            label3.Size = new Size(110, 36);
            label3.TabIndex = 7;
            label3.Text = "Pax Size";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label2.Location = new Point(71, 156);
            label2.Name = "label2";
            label2.Size = new Size(207, 36);
            label2.TabIndex = 8;
            label2.Text = "Customer Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label1.Location = new Point(71, 84);
            label1.Name = "label1";
            label1.Size = new Size(115, 36);
            label1.TabIndex = 9;
            label1.Text = "Waitress";
            // 
            // btnFinish
            // 
            btnFinish.BackColor = SystemColors.ActiveCaption;
            btnFinish.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFinish.Location = new Point(483, 305);
            btnFinish.Name = "btnFinish";
            btnFinish.Size = new Size(189, 49);
            btnFinish.TabIndex = 15;
            btnFinish.Text = "Finish Table";
            btnFinish.UseVisualStyleBackColor = false;
            btnFinish.Click += btnFinish_Click;
            // 
            // btnCancelTable
            // 
            btnCancelTable.BackColor = Color.Khaki;
            btnCancelTable.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelTable.Location = new Point(71, 305);
            btnCancelTable.Name = "btnCancelTable";
            btnCancelTable.Size = new Size(189, 49);
            btnCancelTable.TabIndex = 16;
            btnCancelTable.Text = "Cancel Table";
            btnCancelTable.UseVisualStyleBackColor = false;
            btnCancelTable.Click += btnCancelTable_Click;
            // 
            // DialogTable
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 369);
            Controls.Add(btnCancelTable);
            Controls.Add(btnFinish);
            Controls.Add(panel1);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(cmbWaitress);
            Controls.Add(nmrSize);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DialogTable";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DialogTable";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrSize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblTable;
        private Button btnClose;
        private Button btnCancel;
        private Button btnOk;
        private ComboBox cmbWaitress;
        private NumericUpDown nmrSize;
        private TextBox txtName;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnFinish;
        private Button btnCancelTable;
    }
}