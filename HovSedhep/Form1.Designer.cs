namespace HovSedhep
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnClose = new Button();
            label1 = new Label();
            btnTable = new Button();
            btnMenu = new Button();
            btnHistory = new Button();
            pnlActivity = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1924, 43);
            panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.AutoSize = true;
            btnClose.Location = new Point(1879, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(33, 35);
            btnClose.TabIndex = 1;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(283, 32);
            label1.TabIndex = 0;
            label1.Text = "HovSedhep POS System";
            // 
            // btnTable
            // 
            btnTable.BackColor = Color.DarkGray;
            btnTable.FlatAppearance.BorderColor = Color.Gray;
            btnTable.FlatAppearance.BorderSize = 2;
            btnTable.FlatStyle = FlatStyle.Flat;
            btnTable.Font = new Font("Microsoft JhengHei", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTable.ForeColor = Color.White;
            btnTable.Location = new Point(69, 124);
            btnTable.Name = "btnTable";
            btnTable.Size = new Size(196, 205);
            btnTable.TabIndex = 1;
            btnTable.Text = "Table Seating";
            btnTable.UseVisualStyleBackColor = false;
            btnTable.Click += btnTable_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.DarkGray;
            btnMenu.FlatAppearance.BorderColor = Color.Gray;
            btnMenu.FlatAppearance.BorderSize = 2;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Microsoft JhengHei", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenu.ForeColor = Color.White;
            btnMenu.Location = new Point(69, 441);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(196, 205);
            btnMenu.TabIndex = 1;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnHistory
            // 
            btnHistory.BackColor = Color.DarkGray;
            btnHistory.FlatAppearance.BorderColor = Color.Gray;
            btnHistory.FlatAppearance.BorderSize = 2;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Microsoft JhengHei", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHistory.ForeColor = Color.White;
            btnHistory.Location = new Point(69, 766);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(196, 205);
            btnHistory.TabIndex = 1;
            btnHistory.Text = "History";
            btnHistory.UseVisualStyleBackColor = false;
            btnHistory.Click += btnHistory_Click;
            // 
            // pnlActivity
            // 
            pnlActivity.Dock = DockStyle.Right;
            pnlActivity.ForeColor = Color.Black;
            pnlActivity.Location = new Point(271, 43);
            pnlActivity.Name = "pnlActivity";
            pnlActivity.Size = new Size(1653, 1063);
            pnlActivity.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1106);
            Controls.Add(pnlActivity);
            Controls.Add(btnHistory);
            Controls.Add(btnMenu);
            Controls.Add(btnTable);
            Controls.Add(panel1);
            ForeColor = Color.Firebrick;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnClose;
        private Label label1;
        private Button btnTable;
        private Button btnMenu;
        private Button btnHistory;
        private Panel pnlActivity;
    }
}
