using HovSedhep.Helper;
using HovSedhep.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HovSedhep.Helper;

namespace HovSedhep
{
    public partial class DialogTable : Form
    {
        public enum DialogTableMode
        {
            Assign,
            Seating
        }

        private TableProperty _data;
        private DialogTableMode _mode;
        private int _tableID;
        private string _tableName;


        public DialogTable(int tableID, string tableName, DialogTableMode mode, TableProperty? data)
        {
            InitializeComponent();
            load_Waitress();
            _data = data;
            _mode = mode;
            _tableID = tableID;
            _tableName = tableName;
            nmrSize.Maximum = getMaxPax();
            load_UI(tableName);
            lblTable.Text = getTitle();



            btnCancel.Click += cancel_Dialog;
            btnClose.Click += cancel_Dialog;
        }
        private void load_Waitress()
        {
            string query = "select EmployeeID, Name from Employees where Role = 'Waitress'";
            cmbWaitress.DataSource = DBHelper.ExecuteQuery(query);
            cmbWaitress.ValueMember = "EmployeeID";
            cmbWaitress.DisplayMember = "Name";
            cmbWaitress.SelectedIndex = -1;
        }
        private int getMaxPax()
        {
            return DBHelper.ExecuteReader("select Capacity from RestaurantTables where TableID = @tid",
                dr => dr.IsDBNull(0) ? 0 : dr.GetInt32(0),
                new SqlParameter("@tid", _tableID)
            ).FirstOrDefault();
        }
        private string getTitle()
        {
            return _mode == DialogTableMode.Assign
                ? $"Assign Table - [{_tableName}]"
                : $"Table Seating Detail - [{_tableName}]";
        }
        private void load_UI(string tableName)
        {
            if (_mode == DialogTableMode.Seating)
            {
                cmbWaitress.SelectedValue = _data.Waitress;
                txtName.Text = _data.CustomerName;
                txtName.Enabled = false;
                cmbWaitress.Enabled = false;
                nmrSize.Enabled = false;
            }
            else { btnCancelTable.Visible = false; btnFinish.Visible = false; }
        }
        private void cancel_Dialog(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (UIHelper.Chek_Blok(this)) return;

            string query = @"
                        declare @NewTableId int;
                        insert into Transactions (TableID, CustomerName) values (@tid, @cn)
                        set @NewTableId = scope_identity()
                        insert into Orders (TransactionID, EmployeeID) values (@NewTableId, @eid)";
            int i = DBHelper.ExecuteNonQuery(query,
                new SqlParameter("@tid", _tableID),
                new SqlParameter("@cn", txtName.Text),
                new SqlParameter("@eid", cmbWaitress.SelectedValue)
            );
            if (i > 0) MessageBox.Show("Success Assign Table", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            string query = "update Transactions set Status = 'Completed' where TableID = @tid and Status = 'Ongoing'";
            int i = DBHelper.ExecuteNonQuery(query,
                new SqlParameter("@tid", _tableID)
            );
            if (i > 0) MessageBox.Show("Success Finish Table", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancelTable_Click(object sender, EventArgs e)
        {
            string query = "update Transactions set Status = 'Cancelled' where TableID = @tid and Status = 'Ongoing'";
            int i = DBHelper.ExecuteNonQuery(query,
                new SqlParameter("@tid", _tableID)
            );
            if (i > 0) MessageBox.Show("Success Cancel Table", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
